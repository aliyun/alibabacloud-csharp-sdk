// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataSourcesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataSourcesResponseBodyPagingInfo : TeaModel {
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<ListDataSourcesResponseBodyPagingInfoDataSources> DataSources { get; set; }
            public class ListDataSourcesResponseBodyPagingInfoDataSources : TeaModel {
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public List<ListDataSourcesResponseBodyPagingInfoDataSourcesDataSource> DataSource { get; set; }
                public class ListDataSourcesResponseBodyPagingInfoDataSourcesDataSource : TeaModel {
                    /// <summary>
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
                    /// <b>Example:</b>
                    /// <para>UrlMode</para>
                    /// </summary>
                    [NameInMap("ConnectionPropertiesMode")]
                    [Validation(Required=false)]
                    public string ConnectionPropertiesMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1648711113000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1624387842781448</para>
                    /// </summary>
                    [NameInMap("CreateUser")]
                    [Validation(Required=false)]
                    public string CreateUser { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>16035</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1648711113000</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1624387842781448</para>
                    /// </summary>
                    [NameInMap("ModifyUser")]
                    [Validation(Required=false)]
                    public string ModifyUser { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1648711121000:cn-beijing:odps:yongxunQA_beijing_standard</para>
                    /// </summary>
                    [NameInMap("QualifiedName")]
                    [Validation(Required=false)]
                    public string QualifiedName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7BE1433F-6D55-5D86-9344-CA6F7DD19B13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
