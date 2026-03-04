// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ChannelAssemblyScheduleData : TeaModel {
        /// <summary>
        /// <para>The information about ad breaks.</para>
        /// </summary>
        [NameInMap("AdBreaks")]
        [Validation(Required=false)]
        public List<ChannelAssemblyScheduleDataAdBreaks> AdBreaks { get; set; }
        public class ChannelAssemblyScheduleDataAdBreaks : TeaModel {
            /// <summary>
            /// <para>The SCTE-35 message type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SPLICE_INSERT</para>
            /// </summary>
            [NameInMap("MessageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// <para>The position to insert the ad marker, as an offset relative to the beginning of the program. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("OffsetMillis")]
            [Validation(Required=false)]
            public string OffsetMillis { get; set; }

            /// <summary>
            /// <para>The name of the source location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySourceLocation</para>
            /// </summary>
            [NameInMap("SourceLocationName")]
            [Validation(Required=false)]
            public string SourceLocationName { get; set; }

            /// <summary>
            /// <para>The name of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySource</para>
            /// </summary>
            [NameInMap("SourceName")]
            [Validation(Required=false)]
            public string SourceName { get; set; }

            /// <summary>
            /// <para>The SpliceInsert configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AvailNumber&quot;:0,&quot;AvailExpected&quot;:0,&quot;SpliceEventID&quot;:1,&quot;UniqueProgramID&quot;:0}</para>
            /// </summary>
            [NameInMap("SpliceInsertSettings")]
            [Validation(Required=false)]
            public string SpliceInsertSettings { get; set; }

            /// <summary>
            /// <para>The TimeSignal configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;segmentationEventID&quot;:0,&quot;segmentationUPIDType&quot;:14,&quot;segmentationUPID&quot;:&quot;upid&quot;,&quot;segmentationTypeID&quot;:48,&quot;segmentNumber&quot;:0,&quot;segmentsExpected&quot;:0,&quot;subSegmentNumber&quot;:1,&quot;subSegmentsExpected&quot;:0}</para>
            /// </summary>
            [NameInMap("TimeSignalSettings")]
            [Validation(Required=false)]
            public string TimeSignalSettings { get; set; }

        }

        /// <summary>
        /// <para>The scheduled playback duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("ApproximateDurationSeconds")]
        [Validation(Required=false)]
        public long? ApproximateDurationSeconds { get; set; }

        /// <summary>
        /// <para>The scheduled start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1989128002313</para>
        /// </summary>
        [NameInMap("ApproximateStartTime")]
        [Validation(Required=false)]
        public string ApproximateStartTime { get; set; }

        /// <summary>
        /// <para>The entry type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>program</para>
        /// </summary>
        [NameInMap("EntryType")]
        [Validation(Required=false)]
        public string EntryType { get; set; }

        /// <summary>
        /// <para>The name of the program.</para>
        /// 
        /// <b>Example:</b>
        /// <para>program1</para>
        /// </summary>
        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// <para>The name of the source location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySourceLocation</para>
        /// </summary>
        [NameInMap("SourceLocationName")]
        [Validation(Required=false)]
        public string SourceLocationName { get; set; }

        /// <summary>
        /// <para>The name of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySource</para>
        /// </summary>
        [NameInMap("SourceName")]
        [Validation(Required=false)]
        public string SourceName { get; set; }

        /// <summary>
        /// <para>The source type. Valid values: vodSource and liveSource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vodSource</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
