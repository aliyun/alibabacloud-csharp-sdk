// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeDiagnoseReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDiagnoseReportResponseBodyResult Result { get; set; }
        public class DescribeDiagnoseReportResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1535745731000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("diagnoseItems")]
            [Validation(Required=false)]
            public List<DescribeDiagnoseReportResponseBodyResultDiagnoseItems> DiagnoseItems { get; set; }
            public class DescribeDiagnoseReportResponseBodyResultDiagnoseItems : TeaModel {
                [NameInMap("detail")]
                [Validation(Required=false)]
                public DescribeDiagnoseReportResponseBodyResultDiagnoseItemsDetail Detail { get; set; }
                public class DescribeDiagnoseReportResponseBodyResultDiagnoseItemsDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Check whether the number of replica shards is optimal and easy to maintain</para>
                    /// </summary>
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of Replica Shards</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>You may need to adjust the numbers of replica shards of some indices as follows: [geoname08 : 0 -&gt; 1][geoname09 : 0 -&gt; 1][geonametest01 : 0 -&gt; 1]</para>
                    /// </summary>
                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>You can call the following function in the Elasticsearch API....</para>
                    /// </summary>
                    [NameInMap("suggest")]
                    [Validation(Required=false)]
                    public string Suggest { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ES_API</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>YELLOW</para>
                /// </summary>
                [NameInMap("health")]
                [Validation(Required=false)]
                public string Health { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IndexAliasUseDiagnostic</para>
                /// </summary>
                [NameInMap("item")]
                [Validation(Required=false)]
                public string Item { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>YELLOW</para>
            /// </summary>
            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>es-cn-abc</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>trigger__2020-08-17T17:09:02</para>
            /// </summary>
            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

        }

    }

}
