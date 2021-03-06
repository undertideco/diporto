import * as React from 'react';
import { Link } from 'react-router-dom';
import CategoryList from '../CategoryList';

interface PlaceListItemProps {
  place?: Place
  index: number
}

const PlaceListItem: React.SFC<PlaceListItemProps> = (props) => {
  const { place } = props;

  const placePhotoUrl = (place.photos && place.photos.length !== 0) ? `/api/photos/${place.photos[0].id}` : 'https://s3-us-west-1.amazonaws.com/jurvis/placeholder_img.svg'

  const photoStyle = {
    "background": `url(${placePhotoUrl}) center`
  }

  return (
    <div className="flex bt bb b--light-gray pv3">
      <div className="flex w-70">
        <div className="w-20 pa2" style={{flexShrink: 0}}>
          <div className="aspect-ratio aspect-ratio--1x1">
            <div className="aspect-ratio--object cover br2" style={photoStyle}></div>
          </div>
        </div>
        <div className="flex flex-column">
          <Link className="link blue lh-title" to={`/place/${place.id}`}>
            <span className="fw7 lh-title underline-hover">{props.index + 1}. {place.name}</span>
          </Link>
          {place.categories && place.categories.length > 0 && <CategoryList categories={place.categories}/>}
          {place.reviews && place.reviews.length > 0 && <span className="f6 i lh-copy">"{place.reviews[0].text}"</span>}
        </div>
            </div>
            <div className="w-30 pa3">
        <span>{place.phone}</span>
        <address>{place.address}</address>
      </div>
    </div>
  )
}

export default PlaceListItem;