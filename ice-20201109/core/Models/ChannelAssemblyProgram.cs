// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ChannelAssemblyProgram : TeaModel {
        /// <summary>
        /// <para>The ad breaks.</para>
        /// </summary>
        [NameInMap("AdBreaks")]
        [Validation(Required=false)]
        public List<ChannelAssemblyProgramAdBreaks> AdBreaks { get; set; }
        public class ChannelAssemblyProgramAdBreaks : TeaModel {
            /// <summary>
            /// <para>The name of the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyChannel</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

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
            /// <para>1000</para>
            /// </summary>
            [NameInMap("OffsetMillis")]
            [Validation(Required=false)]
            public long? OffsetMillis { get; set; }

            /// <summary>
            /// <para>The name of the program.</para>
            /// 
            /// <b>Example:</b>
            /// <para>program_name</para>
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
            /// <para>MyAdSource</para>
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
        /// <para>The ARN of the program.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ims:mediaweaver:<regionId>:<userId>:program/myChannel/MyProgram</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// <para>The name of the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyChannel</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>Extracts a clip from the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{StartOffsetMillis: 213123, EndOffsetMillis: 213134}</para>
        /// </summary>
        [NameInMap("ClipRange")]
        [Validation(Required=false)]
        public string ClipRange { get; set; }

        /// <summary>
        /// <para>The time when the program was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-02T00:58:19Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the program was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-02T00:58:19Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

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

        /// <summary>
        /// <para>The program transition method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;: &quot;RELATIVE&quot;, &quot;RelativePosition&quot;: &quot;AFTER_PROGRAM&quot;, &quot;RelativeProgram&quot;: &quot;program2&quot;}</para>
        /// </summary>
        [NameInMap("Transition")]
        [Validation(Required=false)]
        public string Transition { get; set; }

    }

}
