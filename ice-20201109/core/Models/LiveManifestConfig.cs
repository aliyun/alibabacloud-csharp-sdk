// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class LiveManifestConfig : TeaModel {
        /// <summary>
        /// <para>The type of ad markers to include in the manifest.</para>
        /// <list type="bullet">
        /// <item><description>NONE: Removes all ad markers.</description></item>
        /// <item><description>DATE_RANGE: Inserts EXT-X-DATERANGE tags (HLS spec). Valid for HLS/HLS-CMAF endpoints.</description></item>
        /// <item><description>XML: Inserts XML-based ad markers (DASH spec). Valid for DASH endpoints.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("AdMarkers")]
        [Validation(Required=false)]
        public string AdMarkers { get; set; }

        /// <summary>
        /// <para>The interval, in seconds, at which to insert the EXT-X-PROGRAM-DATE-TIME tag into the playlist. By default, no tags are inserted. Valid values: 1 to 3600. Applies only to HLS and HLS-CMAF endpoints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DateTimeInterval")]
        [Validation(Required=false)]
        public int? DateTimeInterval { get; set; }

        /// <summary>
        /// <para>The duration of the startover window, in seconds. It defines the maximum time a viewer can seek backward in the live stream. Valid values: 1 to 3600. Default value: 60. Applies only to DASH endpoints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ManifestDuration")]
        [Validation(Required=false)]
        public int? ManifestDuration { get; set; }

        /// <summary>
        /// <para>The maximum bitrate threshold (in bits per second) that video tracks must be at or below to be available for playback from this endpoint. It must be a positive integer. If not set, no maximum bitrate is enforced.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000000</para>
        /// </summary>
        [NameInMap("MaxVideoBitrate")]
        [Validation(Required=false)]
        public int? MaxVideoBitrate { get; set; }

        /// <summary>
        /// <para>The minimum buffer time, in seconds. Valid values: 1 to 30. Default value: the duration of two segments. Applies only to DASH endpoints.</para>
        /// <para>Note: Setting this value too low may cause playback to stutter. We recommend a value no less than two segment durations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinBufferTime")]
        [Validation(Required=false)]
        public int? MinBufferTime { get; set; }

        /// <summary>
        /// <para>The minimum update period for the manifest, in seconds. Valid values: 1 to 3600. Default value: the duration of two segments. Applies only to DASH endpoints.</para>
        /// <para>Note: For smooth playback, set this value to be less than MinBufferTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinUpdatePeriod")]
        [Validation(Required=false)]
        public int? MinUpdatePeriod { get; set; }

        /// <summary>
        /// <para>The minimum bitrate threshold (in bits per second) that video tracks must be at or above to be available for playback from this endpoint. It must be a positive integer. If not set, no minimum bitrate is enforced.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("MinVideoBitrate")]
        [Validation(Required=false)]
        public int? MinVideoBitrate { get; set; }

        /// <summary>
        /// <para>The suggested presentation delay, in seconds. Valid values: 1 to 60. Default value: the duration of three segments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PresentationDelay")]
        [Validation(Required=false)]
        public int? PresentationDelay { get; set; }

        /// <summary>
        /// <para>The number of segments to include in the playlist. Applies to HLS and HLS-CMAF protocols. If not set, the channel\&quot;s default configuration is used. Valid values: 2 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SegmentCount")]
        [Validation(Required=false)]
        public int? SegmentCount { get; set; }

        /// <summary>
        /// <para>The format of the segment template. Only NUMBER_TIMELINE is supported (default). Applies only to DASH endpoints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NUMBER_TIMELINE</para>
        /// </summary>
        [NameInMap("SegmentTemplateFormat")]
        [Validation(Required=false)]
        public string SegmentTemplateFormat { get; set; }

        /// <summary>
        /// <para>The order of streams in the master playlist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ORIGINAL: Preserves the original order of the input streams.</description></item>
        /// <item><description>VIDEO_BITRATE_ASCENDING: sorts the streams in ascending order of bitrates, from lowest to highest.</description></item>
        /// <item><description>VIDEO_BITRATE_DESCENDING: sorts the streams in descending order of bitrates, from highest to lowest.</description></item>
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
