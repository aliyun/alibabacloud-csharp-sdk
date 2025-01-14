// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The connection configurations of the data source, including the connection address, access identity, and environment information. The envType parameter specifies the environment in which the data source is used. Valid values of the envType parameter:</para>
        /// <list type="bullet">
        /// <item><description>Dev: development environment</description></item>
        /// <item><description>Prod: production environment</description></item>
        /// </list>
        /// <para>The parameters that you need to configure to the data source vary based on the mode in which the data source is added. For more information, see <a href="https://help.aliyun.com/document_detail/2852465.html">Data source connection information (ConnectionProperties)</a>.</para>
        /// <para>This parameter is required.</para>
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
        public string ConnectionProperties { get; set; }

        /// <summary>
        /// <para>The mode in which you want to add the data source. The mode varies based on the data source type. Valid values for MySQL data sources:</para>
        /// <list type="bullet">
        /// <item><description>InstanceMode: instance mode</description></item>
        /// <item><description>UrlMode: connection string mode</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UrlMode</para>
        /// </summary>
        [NameInMap("ConnectionPropertiesMode")]
        [Validation(Required=false)]
        public string ConnectionPropertiesMode { get; set; }

        /// <summary>
        /// <para>The description of the data source. The description cannot exceed 3,000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a holo datasource</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the data source. The name can be up to 255 characters in length and can contain letters, digits, and underscores (_). The name must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_holo_datasource</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The type of the data source. More than 70 types of data sources are supported in DataWorks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hologres</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
