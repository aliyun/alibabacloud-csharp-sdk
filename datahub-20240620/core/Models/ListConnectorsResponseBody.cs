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
                [NameInMap("ColumnFields")]
                [Validation(Required=false)]
                public string ColumnFields { get; set; }

                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                [NameInMap("ConnectorId")]
                [Validation(Required=false)]
                public string ConnectorId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("DoneTime")]
                [Validation(Required=false)]
                public string DoneTime { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("SubscriptionId")]
                [Validation(Required=false)]
                public string SubscriptionId { get; set; }

                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

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
