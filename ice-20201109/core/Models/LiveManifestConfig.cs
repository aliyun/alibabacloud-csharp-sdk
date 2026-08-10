// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class LiveManifestConfig : TeaModel {
        /// <summary>
        /// <para>The ad markers supported in the playlist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NONE: removes ad markers.</description></item>
        /// <item><description>DATE_RANGE: uses the EXT-X-DATERANGE tag defined in the HLS specification. This value is available when the endpoint protocol is HLS/HLS_CMAF.</description></item>
        /// <item><description>XML: uses the XML ad markers defined in the DASH specification. This value is available when the endpoint protocol is DASH.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("AdMarkers")]
        [Validation(Required=false)]
        public string AdMarkers { get; set; }

        /// <summary>
        /// <para>The interval (in seconds) for inserting the EXT-X-PROGRAM-DATE-TIME time tag. By default, the tag is not inserted. Valid values: 1 to 3600. This parameter applies to the HLS/HLS_CMAF protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DateTimeInterval")]
        [Validation(Required=false)]
        public int? DateTimeInterval { get; set; }

        /// <summary>
        /// <para>The maximum time-shift duration during live streaming. Unit: seconds. Valid values: 1 to 3600. Default value: 60. This parameter applies to DASH.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ManifestDuration")]
        [Validation(Required=false)]
        public int? ManifestDuration { get; set; }

        /// <summary>
        /// <para>The maximum input bitrate threshold (unit: bit/s). A video track must have a bitrate less than or equal to this threshold to be played from this endpoint. Valid values: integers greater than 0. By default, this parameter is empty and no maximum bitrate limit is set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000000</para>
        /// </summary>
        [NameInMap("MaxVideoBitrate")]
        [Validation(Required=false)]
        public int? MaxVideoBitrate { get; set; }

        /// <summary>
        /// <para>The minimum buffer time. Unit: seconds. Valid values: 1 to 30. Default value: 2 segment durations. This parameter applies only to DASH.</para>
        /// <remarks>
        /// <para> An excessively small minimum buffer time may cause playback stuttering. Set this parameter to a value no less than 2 segment durations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinBufferTime")]
        [Validation(Required=false)]
        public int? MinBufferTime { get; set; }

        /// <summary>
        /// <para>The minimum update interval. Unit: seconds. Valid values: 1 to 3600. Default value: 2 segment durations. This parameter applies to DASH.</para>
        /// <remarks>
        /// <para> Set this parameter to a value less than the minimum buffer time. An excessively large value may cause DASH playback stuttering.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinUpdatePeriod")]
        [Validation(Required=false)]
        public int? MinUpdatePeriod { get; set; }

        /// <summary>
        /// <para>The minimum input bitrate threshold (unit: bit/s). A video track must have a bitrate greater than or equal to this threshold to be played from this endpoint. Valid values: integers greater than 0. By default, this parameter is empty and no minimum bitrate is set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("MinVideoBitrate")]
        [Validation(Required=false)]
        public int? MinVideoBitrate { get; set; }

        [NameInMap("PartHoldBackMs")]
        [Validation(Required=false)]
        public int? PartHoldBackMs { get; set; }

        /// <summary>
        /// <para>The suggested presentation delay. Unit: seconds. Valid values: 1 to 60. Default value: 3 segment durations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PresentationDelay")]
        [Validation(Required=false)]
        public int? PresentationDelay { get; set; }

        /// <summary>
        /// <para>The number of segments. This parameter applies to the HLS/HLS_CMAF protocol. By default, the channel configuration is used. Valid values: 2 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SegmentCount")]
        [Validation(Required=false)]
        public int? SegmentCount { get; set; }

        /// <summary>
        /// <para>The segment template. Currently, only NUMBER_TIMELINE (default) is supported. This parameter applies to DASH.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NUMBER_TIMELINE</para>
        /// </summary>
        [NameInMap("SegmentTemplateFormat")]
        [Validation(Required=false)]
        public string SegmentTemplateFormat { get; set; }

        /// <summary>
        /// <para>The stream sorting rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ORIGINAL: retains the original order of the input sub-manifest.</description></item>
        /// <item><description>VIDEO_BITRATE_ASCENDING: sorts by video stream bitrate in ascending order.</description></item>
        /// <item><description>VIDEO_BITRATE_DESCENDING: sorts by video stream bitrate in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ORIGINAL</para>
        /// </summary>
        [NameInMap("StreamOrder")]
        [Validation(Required=false)]
        public string StreamOrder { get; set; }

    }

}
