import * as React from "react";
import * as MapGL from "react-map-gl";

export interface MapProps extends React.Props<any> {
  width: number;
  height: number;
  viewport: MapGLViewport;
}

export interface MapComponentState {}

export default class Map extends React.Component<MapProps, MapComponentState> {
  public render() {
    return (
      <MapGL
	width={this.props.width}
	height={this.props.height}
	latitude={this.props.viewport.latitude}
	longitude={this.props.viewport.longitude}
      />
    )
  }
}