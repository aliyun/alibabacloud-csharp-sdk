// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataSourcesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataSourcesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The data source groups. Each element in the array indicates a data source group. Each data source group contains data sources in the development environment (if any) and the production environment.</para>
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<ListDataSourcesResponseBodyPagingInfoDataSources> DataSources { get; set; }
            public class ListDataSourcesResponseBodyPagingInfoDataSources : TeaModel {
                /// <summary>
                /// <para>The data sources. Each element is the information of a single data source with a unique data source ID.</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public List<ListDataSourcesResponseBodyPagingInfoDataSourcesDataSource> DataSource { get; set; }
                public class ListDataSourcesResponseBodyPagingInfoDataSourcesDataSource : TeaModel {
                    /// <summary>
                    /// <para>The connection configurations of the data source, including the connection address, access identity, and environment information. The envType parameter specifies the environment in which the data source is used. Valid values of the envType parameter:</para>
                    /// <list type="bullet">
                    /// <item><description>Dev: development environment</description></item>
                    /// <item><description>Prod: production environment</description></item>
                    /// </list>
                    /// <para>The parameters that you need to configure for the data source vary based on the mode in which the data source is added. For more information, see <a href="https://help.aliyun.com/document_detail/2852465.html">Data source connection information (ConnectionProperties)</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;envType&quot;: &quot;Prod&quot;,
                    ///     &quot;regionId&quot;: &quot;cn-beijing&quot;,
                    ///     &quot;instanceId&quot;: &quot;hgprecn-cn-x0r3oun4k001&quot;,
                    ///     &quot;database&quot;: &quot;testdb&quot;,
                    ///     &quot;securityProtocol&quot;: &quot;authTypeNone&quot;,
                    ///     &quot;authType&quot;: &quot;Executor&quot;,
                    ///     &quot;authIdentity&quot;: &quot;1107550004253538&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("ConnectionProperties")]
                    [Validation(Required=false)]
                    public object ConnectionProperties { get; set; }

                    /// <summary>
                    /// <para>The mode in which the data source is added. The mode varies based on the data source type. Valid values: InstanceMode, UrlMode, and CdhMode. The value InstanceMode indicates the instance mode. The value UrlMode indicates the connection string mode. The value CdhMode indicates the CDH cluster mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UrlMode</para>
                    /// </summary>
                    [NameInMap("ConnectionPropertiesMode")]
                    [Validation(Required=false)]
                    public string ConnectionPropertiesMode { get; set; }

                    /// <summary>
                    /// <para>The time when the data source was added. This value is a UNIX timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1648711113000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the user who adds the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1624387842781448</para>
                    /// </summary>
                    [NameInMap("CreateUser")]
                    [Validation(Required=false)]
                    public string CreateUser { get; set; }

                    /// <summary>
                    /// <para>The description of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The ID of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16035</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The time when the data source was last modified. This value is a UNIX timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1648711113000</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the user who modifies the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1624387842781448</para>
                    /// </summary>
                    [NameInMap("ModifyUser")]
                    [Validation(Required=false)]
                    public string ModifyUser { get; set; }

                    /// <summary>
                    /// <para>The unique business key of the data source. For example, the unique business key of a Hologres data source is in the <c>${tenantOwnerId}:${regionId}:${type}:${instanceId}:${database}</c> format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1648711121000:cn-beijing:odps:yongxunQA_beijing_standard</para>
                    /// </summary>
                    [NameInMap("QualifiedName")]
                    [Validation(Required=false)]
                    public string QualifiedName { get; set; }

                }

                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BE1433F-6D55-5D86-9344-CA6F7DD19B13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
