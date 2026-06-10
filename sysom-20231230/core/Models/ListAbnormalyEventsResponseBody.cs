// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAbnormalyEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, authorization succeeded.  </description></item>
        /// <item><description>Any other status code indicates authorization failed. When authorization fails, check the <c>message</c> field for detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return Result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAbnormalyEventsResponseBodyData> Data { get; set; }
        public class ListAbnormalyEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1725801090000</para>
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>Detailed description of the anomalous item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>节点发生OOM, 可查看OOM发生原因</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Diagnosis status (1 indicates diagnosis ready, 2 indicates running, 3 indicates completed, 4 indicates undiagnosable, 5 indicates failed)</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("diag_status")]
            [Validation(Required=false)]
            public int? DiagStatus { get; set; }

            /// <summary>
            /// <para>End time of the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1725797727754</para>
            /// </summary>
            [NameInMap("end_at")]
            [Validation(Required=false)]
            public long? EndAt { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9d00ut2ska3mlyhn6j</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            /// <summary>
            /// <para>Name of the anomalous item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>节点CPU使用率检测</para>
            /// </summary>
            [NameInMap("item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// <para>Level of the anomalous item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>potential</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>Namespace where the pod is located</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>List of operations for the abnormal item</para>
            /// </summary>
            [NameInMap("opts")]
            [Validation(Required=false)]
            public List<ListAbnormalyEventsResponseBodyDataOpts> Opts { get; set; }
            public class ListAbnormalyEventsResponseBodyDataOpts : TeaModel {
                /// <summary>
                /// <para>Operation Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>diagnose</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>Diagnosis result of the abnormal item</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public ListAbnormalyEventsResponseBodyDataOptsResult Result { get; set; }
                public class ListAbnormalyEventsResponseBodyDataOptsResult : TeaModel {
                    /// <summary>
                    /// <para>Diagnosis status</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>Diagnosis details URL</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/diagnose/result/PhfFg456</para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>Diagnosis Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Pod name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-pod</para>
            /// </summary>
            [NameInMap("pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// <para>Raw metrics</para>
            /// </summary>
            [NameInMap("raw_metrics")]
            [Validation(Required=false)]
            public ListAbnormalyEventsResponseBodyDataRawMetrics RawMetrics { get; set; }
            public class ListAbnormalyEventsResponseBodyDataRawMetrics : TeaModel {
                /// <summary>
                /// <para>End Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1761814928</para>
                /// </summary>
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                /// <summary>
                /// <para>List of metric values.</para>
                /// </summary>
                [NameInMap("metrics")]
                [Validation(Required=false)]
                public List<string> Metrics { get; set; }

                /// <summary>
                /// <para>Start Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1761814928</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

            }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Type of abnormal item</para>
            /// 
            /// <b>Example:</b>
            /// <para>saturation</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>UUID corresponding to the anomalous activity</para>
            /// 
            /// <b>Example:</b>
            /// <para>43f05b46-1034-42e8-a528-6e5ca1108277</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>Error code description; empty if no error</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
