// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DiscoverEventSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// <para>A value of 200 indicates success.</para>
        /// <para>Other values indicate an error. For more information, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DiscoverEventSourceResponseBodyData Data { get; set; }
        public class DiscoverEventSourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The discovery results for the MySQL source.</para>
            /// </summary>
            [NameInMap("SourceMySQLDiscovery")]
            [Validation(Required=false)]
            public DiscoverEventSourceResponseBodyDataSourceMySQLDiscovery SourceMySQLDiscovery { get; set; }
            public class DiscoverEventSourceResponseBodyDataSourceMySQLDiscovery : TeaModel {
                /// <summary>
                /// <para>The database names, in JSON array format.</para>
                /// </summary>
                [NameInMap("DatabaseNames")]
                [Validation(Required=false)]
                public List<string> DatabaseNames { get; set; }

                /// <summary>
                /// <para>The estimated number of rows. Unit: rows.</para>
                /// </summary>
                [NameInMap("EstimatedRows")]
                [Validation(Required=false)]
                public long? EstimatedRows { get; set; }

                /// <summary>
                /// <para>The number of days before binary logs (binlogs) expire. Unit: days.</para>
                /// </summary>
                [NameInMap("ExpireLogsDays")]
                [Validation(Required=false)]
                public int? ExpireLogsDays { get; set; }

                /// <summary>
                /// <para>Sample table content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;is_active\&quot;:\&quot;1\&quot;,\&quot;name\&quot;:\&quot;0c0c5d1a-e844-44a8-902d-4f62cbcb0479\&quot;,\&quot;id\&quot;:\&quot;21\&quot;},{\&quot;is_active\&quot;:\&quot;1\&quot;,\&quot;name\&quot;:\&quot;18ef033e-70bb-4795-8222-6cfb54f38f26\&quot;,\&quot;id\&quot;:\&quot;22\&quot;}]</para>
                /// </summary>
                [NameInMap("SimpleData")]
                [Validation(Required=false)]
                public string SimpleData { get; set; }

                /// <summary>
                /// <para>The database table names.</para>
                /// </summary>
                [NameInMap("TableNames")]
                [Validation(Required=false)]
                public List<string> TableNames { get; set; }

                /// <summary>
                /// <para>The table properties.</para>
                /// </summary>
                [NameInMap("TableSchema")]
                [Validation(Required=false)]
                public DiscoverEventSourceResponseBodyDataSourceMySQLDiscoveryTableSchema TableSchema { get; set; }
                public class DiscoverEventSourceResponseBodyDataSourceMySQLDiscoveryTableSchema : TeaModel {
                    /// <summary>
                    /// <para>The column information.</para>
                    /// </summary>
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<DiscoverEventSourceResponseBodyDataSourceMySQLDiscoveryTableSchemaColumns> Columns { get; set; }
                    public class DiscoverEventSourceResponseBodyDataSourceMySQLDiscoveryTableSchemaColumns : TeaModel {
                        /// <summary>
                        /// <para>An auxiliary parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>auto_increment</para>
                        /// </summary>
                        [NameInMap("Extra")]
                        [Validation(Required=false)]
                        public string Extra { get; set; }

                        /// <summary>
                        /// <para>The column name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>id</para>
                        /// </summary>
                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public string Field { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the column can be empty. The return values are as follows:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>YES</b>: The column can be empty.</para>
                        /// </description></item>
                        /// <item><description><para><b>NO</b>: The column cannot be empty.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NO</para>
                        /// </summary>
                        [NameInMap("IsNull")]
                        [Validation(Required=false)]
                        public string IsNull { get; set; }

                        /// <summary>
                        /// <para>The primary key type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PRI</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The property type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>int</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The table name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>map</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// <para>The maximum idle time for a non-interactive connection. Unit: seconds.</para>
                /// </summary>
                [NameInMap("WaitTimeout")]
                [Validation(Required=false)]
                public int? WaitTimeout { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7043799-F4DA-5290-9249-97C35987****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. A \<c>true\\</c> value means the operation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
