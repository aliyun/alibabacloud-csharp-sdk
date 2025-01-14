// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the data source.</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public GetDataSourceResponseBodyDataSource DataSource { get; set; }
        public class GetDataSourceResponseBodyDataSource : TeaModel {
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
            /// <para>The mode in which the data source is added. The mode varies based on the data source type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InstanceMode: instance mode</description></item>
            /// <item><description>UrlMode: connection string mode</description></item>
            /// <item><description>CdhMode: CDH cluster mode</description></item>
            /// </list>
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
            /// <para>1698286929333</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who adds the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1107550004253538</para>
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
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16738</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The time when the data source was last modified. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1698286929333</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who modifies the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1107550004253538</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

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
            /// <para>The ID of the workspace with which the data source is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52660</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The unique business key of the data source. For example, the unique business key of a Hologres data source is in the <c>${tenantOwnerId}:${regionId}:${type}:${instanceId}:${database}</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1107550004253538:cn-beijing:holo:hgprecn-cn-x0r3oun4k001:testdb</para>
            /// </summary>
            [NameInMap("QualifiedName")]
            [Validation(Required=false)]
            public string QualifiedName { get; set; }

            /// <summary>
            /// <para>The type of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hologres</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9252F32F-D855-549E-8898-61CF5A733050</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
