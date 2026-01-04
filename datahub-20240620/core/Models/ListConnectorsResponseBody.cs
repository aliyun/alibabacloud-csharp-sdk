// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Datahub20240620.Models
{
    public class ListConnectorsResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public ListConnectorsResponseBodyList List { get; set; }
        public class ListConnectorsResponseBodyList : TeaModel {
            [NameInMap("Connector")]
            [Validation(Required=false)]
            public List<ListConnectorsResponseBodyListConnector> Connector { get; set; }
            public class ListConnectorsResponseBodyListConnector : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[\&quot;field1\&quot;,\&quot;field2\&quot;]</para>
                /// </summary>
                [NameInMap("ColumnFields")]
                [Validation(Required=false)]
                public string ColumnFields { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;Table\&quot;:\&quot;r3\&quot;,\&quot;Endpoint\&quot;:\&quot;<a href="https://Device-data.cn-beijing.ots-internal.aliyuncs.com%5C%5C%22,%5C%5C%22Instance%5C%5C%22:%5C%5C%22Device-data%5C%5C%22,%5C%5C%22WriteMode%5C%5C%22:%5C%5C%22PUT%5C%5C%22,%5C%5C%22AuthMode%5C%5C%22:%5C%5C%22STS%5C%5C%22%7D">https://Device-data.cn-beijing.ots-internal.aliyuncs.com\\&quot;,\\&quot;Instance\\&quot;:\\&quot;Device-data\\&quot;,\\&quot;WriteMode\\&quot;:\\&quot;PUT\\&quot;,\\&quot;AuthMode\\&quot;:\\&quot;STS\\&quot;}</a></para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fa44384c-0ac5-4d3e-8acd-76e18636ab10</para>
                /// </summary>
                [NameInMap("ConnectorId")]
                [Validation(Required=false)]
                public string ConnectorId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1724041098000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1696648921408952</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-04 16:45:00</para>
                /// </summary>
                [NameInMap("DoneTime")]
                [Validation(Required=false)]
                public string DoneTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_project</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1745824636429WZ2EE</para>
                /// </summary>
                [NameInMap("SubscriptionId")]
                [Validation(Required=false)]
                public string SubscriptionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_topic</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SINK_ODPS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1708171905000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9892074a2a89600ae4b0d5a34fb99a3f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A20A7093-8FE0-058C-BE0C-3C8057D5F1A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
