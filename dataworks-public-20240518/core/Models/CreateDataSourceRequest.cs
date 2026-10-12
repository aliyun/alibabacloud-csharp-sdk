// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The specific connection configuration of the data source, including the endpoint, access identity, and environment context. The envType property of this object specifies the data source environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Dev: Development environment.</description></item>
        /// <item><description>Prod: Production environment.</description></item>
        /// </list>
        /// <para>Different data source types have different property specifications in different configuration patterns (ConnectionPropertiesMode). For more information, see <a href="https://help.aliyun.com/document_detail/2852465.html">ConnectionProperties</a>.</para>
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
        /// <para>The category in which the data source is added. Different data source types have different subtypes and parameter constraints. For example, a MySQL data source supports the following modes:</para>
        /// <list type="bullet">
        /// <item><description>InstanceMode: Instance mode.</description></item>
        /// <item><description>UrlMode: Connection string mode.</description></item>
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
        /// <para>The description of the data source. The description can be up to 3,000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a holo datasource</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the data source. The name can contain letters, digits, and underscores (_), and cannot start with a digit or an underscore. The name can be up to 255 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_holo_datasource</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://dataworks.console.aliyun.com/overview">DataWorks console</a> and go to the Workspace Management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace used for this API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The type of the data source. More than 70 data source types are supported. References: <a href="https://help.aliyun.com/document_detail/2852465.html">Data source types</a>.</para>
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
