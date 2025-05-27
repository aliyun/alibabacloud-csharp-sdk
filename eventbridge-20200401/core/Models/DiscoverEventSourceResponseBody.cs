// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DiscoverEventSourceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DiscoverEventSourceResponseBodyData Data { get; set; }
        public class DiscoverEventSourceResponseBodyData : TeaModel {
            [NameInMap("SourceMySQLDiscovery")]
            [Validation(Required=false)]
            public DiscoverEventSourceResponseBodyDataSourceMySQLDiscovery SourceMySQLDiscovery { get; set; }
            public class DiscoverEventSourceResponseBodyDataSourceMySQLDiscovery : TeaModel {
                [NameInMap("DatabaseNames")]
                [Validation(Required=false)]
                public List<string> DatabaseNames { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;is_active\&quot;:\&quot;1\&quot;,\&quot;name\&quot;:\&quot;0c0c5d1a-e844-44a8-902d-4f62cbcb0479\&quot;,\&quot;id\&quot;:\&quot;21\&quot;},{\&quot;is_active\&quot;:\&quot;1\&quot;,\&quot;name\&quot;:\&quot;18ef033e-70bb-4795-8222-6cfb54f38f26\&quot;,\&quot;id\&quot;:\&quot;22\&quot;}]</para>
                /// </summary>
                [NameInMap("SimpleData")]
                [Validation(Required=false)]
                public string SimpleData { get; set; }

                [NameInMap("TableNames")]
                [Validation(Required=false)]
                public List<string> TableNames { get; set; }

                [NameInMap("TableSchema")]
                [Validation(Required=false)]
                public DiscoverEventSourceResponseBodyDataSourceMySQLDiscoveryTableSchema TableSchema { get; set; }
                public class DiscoverEventSourceResponseBodyDataSourceMySQLDiscoveryTableSchema : TeaModel {
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<DiscoverEventSourceResponseBodyDataSourceMySQLDiscoveryTableSchemaColumns> Columns { get; set; }
                    public class DiscoverEventSourceResponseBodyDataSourceMySQLDiscoveryTableSchemaColumns : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>auto_increment</para>
                        /// </summary>
                        [NameInMap("Extra")]
                        [Validation(Required=false)]
                        public string Extra { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>id</para>
                        /// </summary>
                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public string Field { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>NO</para>
                        /// </summary>
                        [NameInMap("IsNull")]
                        [Validation(Required=false)]
                        public string IsNull { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PRI</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>int</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>map</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C7043799-F4DA-5290-9249-97C35987****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
