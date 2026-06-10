// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRecordFileResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the screen recording files.</para>
        /// </summary>
        [NameInMap("RecordFiles")]
        [Validation(Required=false)]
        public List<DescribeRecordFileResponseBodyRecordFiles> RecordFiles { get; set; }
        public class DescribeRecordFileResponseBodyRecordFiles : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-7yulhw1g1attet7d2</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud desktop.</para>
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
                /// <para>The time when the event occurred.</para>
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
            /// <para>The name of the screen recording file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task3</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file size. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-**</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The time when the screen recording ended. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format and is displayed in UTC.</para>
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
            /// <para>The time when the screen recording started. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T06:02:25Z</para>
            /// </summary>
            [NameInMap("RecordStartTime")]
            [Validation(Required=false)]
            public string RecordStartTime { get; set; }

            /// <summary>
            /// <para>The recording type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>alltime</c>: continuous screen recording.</para>
            /// </description></item>
            /// <item><description><para><c>period</c>: interval screen recording.</para>
            /// </description></item>
            /// <item><description><para><c>event</c>: event-triggered screen recording.</para>
            /// </description></item>
            /// <item><description><para><c>session</c>: session-based screen recording.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>period</para>
            /// </summary>
            [NameInMap("RecordType")]
            [Validation(Required=false)]
            public int? RecordType { get; set; }

            /// <summary>
            /// <para>The ID of the region where the cloud desktop resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-f3s3dgt8dtb0vlqc8</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resource</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The upload status of the screen recording file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: uploaded.</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: uploading.</para>
            /// </description></item>
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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
