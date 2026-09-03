// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRecordFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the recording files.</para>
        /// </summary>
        [NameInMap("RecordFiles")]
        [Validation(Required=false)]
        public List<DescribeRecordFileResponseBodyRecordFiles> RecordFiles { get; set; }
        public class DescribeRecordFileResponseBodyRecordFiles : TeaModel {
            /// <summary>
            /// <para>The Cloud Desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-7yulhw1g1attet7d2</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the Cloud Desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fvt-ecd</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The name of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The event details.</para>
            /// </summary>
            [NameInMap("EventDetails")]
            [Validation(Required=false)]
            public List<DescribeRecordFileResponseBodyRecordFilesEventDetails> EventDetails { get; set; }
            public class DescribeRecordFileResponseBodyRecordFilesEventDetails : TeaModel {
                /// <summary>
                /// <para>The event details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\n\t\&quot;messageInfo\&quot; : \&quot;mouse_move\&quot;,\n\t\&quot;messageType\&quot; : \&quot;UserInput\&quot;\n}\n&quot;</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <para>The time when the event occurred. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public int? EventTime { get; set; }

                /// <summary>
                /// <para>The event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UserInput</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

            }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task3</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The size of the file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The ID of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-**</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The time when the recording ended. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T06:02:25Z</para>
            /// </summary>
            [NameInMap("RecordEndTime")]
            [Validation(Required=false)]
            public string RecordEndTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the screen recording file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774656000000</para>
            /// </summary>
            [NameInMap("RecordExpire")]
            [Validation(Required=false)]
            public long? RecordExpire { get; set; }

            /// <summary>
            /// <para>The time when the recording started. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T06:02:25Z</para>
            /// </summary>
            [NameInMap("RecordStartTime")]
            [Validation(Required=false)]
            public string RecordStartTime { get; set; }

            /// <summary>
            /// <para>The type of the screen recording file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>alltime: full-time recording.</description></item>
            /// <item><description>period: interval recording.</description></item>
            /// <item><description>event: event-based recording.</description></item>
            /// <item><description>session: session recording.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RecordType")]
            [Validation(Required=false)]
            public int? RecordType { get; set; }

            /// <summary>
            /// <para>The region where the recorded Cloud Desktop is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-f3s3dgt8dtb0vlqc8</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resource</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The status of the screen recording file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: uploaded.</description></item>
            /// <item><description>1: uploading.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05C2791F-41A7-5E7C-B5E4-1401FD0E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
