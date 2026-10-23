// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DiagnoseInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DiagnoseInstanceResponseBodyResult Result { get; set; }
        public class DiagnoseInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The timestamp when the diagnostic report was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1535745731000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The diagnostic mode. Valid values: RULE and AGENT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RULE</para>
            /// </summary>
            [NameInMap("diagnosisMode")]
            [Validation(Required=false)]
            public string DiagnosisMode { get; set; }

            /// <summary>
            /// <para>The instance ID of the diagnosed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-n6w1o1x0w001c****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The list of diagnostic item details. This parameter may be empty if details are not required.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DiagnoseInstanceResponseBodyResultItems> Items { get; set; }
            public class DiagnoseInstanceResponseBodyResultItems : TeaModel {
                /// <summary>
                /// <para>The description of the diagnostic conclusion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Everything is normal</para>
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The diagnostic details. This parameter is empty if details are not required.</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public Dictionary<string, object> Detail { get; set; }

                /// <summary>
                /// <para>The code of the diagnostic item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cluster.health</para>
                /// </summary>
                [NameInMap("item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The name of the diagnostic item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cluster health</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The health status of the diagnostic item. Valid values: GREEN, YELLOW, and RED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GREEN</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The handling suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Monitor GC</para>
                /// </summary>
                [NameInMap("suggest")]
                [Validation(Required=false)]
                public string Suggest { get; set; }

            }

            /// <summary>
            /// <para>The report ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trigger__2020-08-17T17:09:02</para>
            /// </summary>
            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The diagnostic status. Valid values: SUCCESS, FAILED, and RUNNING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
