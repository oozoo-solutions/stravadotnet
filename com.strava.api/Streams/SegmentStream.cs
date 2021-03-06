﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace com.strava.api.Streams
{
    /// <summary>
    /// Streams is the Strava term for the raw data associated with an activity. All streams for a given 
    /// activity or segment effort will be the same length and the values at a given index 
    /// correspond to the same time.
    /// </summary>
    public class SegmentStream
    {
        /// <summary>
        /// The type of stream.
        /// </summary>
        [JsonProperty("type")]
        private String Type { get; set; }

        /// <summary>
        /// The type of stream.
        /// </summary>
        public StreamType StreamType
        {
            get
            {
                if (Type.Equals("altitude"))
                {
                    return StreamType.Altitude;
                }
                if (Type.Equals("cadence"))
                {
                    return StreamType.Cadence;
                }
                if (Type.Equals("latlng"))
                {
                    return StreamType.LatLng;
                }
                if (Type.Equals("distance"))
                {
                    return StreamType.Distance;
                }
                if (Type.Equals("grade_smooth"))
                {
                    return StreamType.GradeSmooth;
                }
                if (Type.Equals("heartrate"))
                {
                    return StreamType.Heartrate;
                }
                if (Type.Equals("moving"))
                {
                    return StreamType.Moving;
                }
                if (Type.Equals("temp"))
                {
                    return StreamType.Temperature;
                }
                if (Type.Equals("time"))
                {
                    return StreamType.Time;
                }
                if (Type.Equals("velocity_smooth"))
                {
                    return StreamType.VelocitySmooth;
                }

                return StreamType.Watts;
            }
        }

        /// <summary>
        /// Array of stream values.
        /// </summary>
        [JsonProperty("data")]
        public List<object> Data { get; set; }

        /// <summary>
        /// Series type used for down sampling, will be present even if not used.
        /// </summary>
        [JsonProperty("series_type")]
        public String SeriesType { get; set; }

        /// <summary>
        /// Complete stream length
        /// </summary>
        [JsonProperty("original_size")]
        public int OriginalSize { get; set; }

        /// <summary>
        /// Resolution of the stream.
        /// 'low', 'medium' or 'high'
        /// </summary>
        [JsonProperty("resolution")]
        public string Resolution { get; set; }
    }
}
