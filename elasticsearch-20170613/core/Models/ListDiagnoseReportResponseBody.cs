// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDiagnoseReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The response headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDiagnoseReportResponseBodyHeaders Headers { get; set; }
        public class ListDiagnoseReportResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The total number of records returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDiagnoseReportResponseBodyResult> Result { get; set; }
        public class ListDiagnoseReportResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The timestamp when the report was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1535745731000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The list of diagnostic items in the report.</para>
            /// </summary>
            [NameInMap("diagnoseItems")]
            [Validation(Required=false)]
            public List<ListDiagnoseReportResponseBodyResultDiagnoseItems> DiagnoseItems { get; set; }
            public class ListDiagnoseReportResponseBodyResultDiagnoseItems : TeaModel {
                /// <summary>
                /// <para>The details of the diagnostic item.</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public ListDiagnoseReportResponseBodyResultDiagnoseItemsDetail Detail { get; set; }
                public class ListDiagnoseReportResponseBodyResultDiagnoseItemsDetail : TeaModel {
                    /// <summary>
                    /// <para>The description of the diagnostic item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check whether the number of replica shards is optimal and easy to maintain</para>
                    /// </summary>
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The full name of the diagnostic item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of Replica Shards</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The diagnostic result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>You may need to adjust the numbers of replica shards of some indices as follows:  [geoname08 : 0 -&gt; 1][geoname09 : 0 -&gt; 1][geonametest01 : 0 -&gt; 1]</para>
                    /// </summary>
                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <para>The diagnostic suggestion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>You can call the following function in the Elasticsearch API....</para>
                    /// </summary>
                    [NameInMap("suggest")]
                    [Validation(Required=false)]
                    public string Suggest { get; set; }

                    /// <summary>
                    /// <para>The type of the diagnostic result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>TEXT: text description</description></item>
                    /// <item><description>CONSOLE_API: console-triggered</description></item>
                    /// <item><description>ES_API: API-triggered.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ES_API</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The health status of the diagnostic item. Valid values: GREEN, YELLOW, RED, and UNKNOWN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YELLOW</para>
                /// </summary>
                [NameInMap("health")]
                [Validation(Required=false)]
                public string Health { get; set; }

                /// <summary>
                /// <para>The name of the diagnostic item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IndexAliasUseDiagnostic</para>
                /// </summary>
                [NameInMap("item")]
                [Validation(Required=false)]
                public string Item { get; set; }

            }

            [NameInMap("diagnosisMode")]
            [Validation(Required=false)]
            public string DiagnosisMode { get; set; }

            /// <summary>
            /// <para>The overall health status of the cluster in the report. Valid values: GREEN, YELLOW, RED, and UNKNOWN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YELLOW</para>
            /// </summary>
            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            /// <summary>
            /// <para>The instance ID of the diagnosed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-abc</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListDiagnoseReportResponseBodyResultItems> Items { get; set; }
            public class ListDiagnoseReportResponseBodyResultItems : TeaModel {
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("detail")]
                [Validation(Required=false)]
                public Dictionary<string, object> Detail { get; set; }

                [NameInMap("item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("suggest")]
                [Validation(Required=false)]
                public string Suggest { get; set; }

            }

            /// <summary>
            /// <para>The report ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trigger__2020-08-17T17:09:02f</para>
            /// </summary>
            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The diagnostic status. Valid values: SUCCESS, FAILED, and RUNNING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The trigger method of the health diagnostics. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM: automatically triggered by the system</description></item>
            /// <item><description>INNER: internally triggered</description></item>
            /// <item><description>USER: manually triggered by the user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

        }

    }

}
