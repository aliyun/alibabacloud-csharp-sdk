// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListResourceTypesRequest : TeaModel {
        /// <summary>
        /// <para>The entity type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><para>All: all resource types.</para>
        /// </description></item>
        /// <item><description><para>Resource (default): regular resource types. For more information, see <a href="https://help.aliyun.com/document_detail/28863.html">Resources</a>.</para>
        /// </description></item>
        /// <item><description><para>DataSource: data source resource types. For more information, see <a href="https://help.aliyun.com/document_detail/404753.html">Data source resources</a>.</para>
        /// </description></item>
        /// <item><description><para>Module: modules.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Resource</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The resource type provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ROS (default): Resource Orchestration Service.</description></item>
        /// <item><description>Self: the user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ROS</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The resource type. The value can contain uppercase and lowercase letters, digits, colons (:), and asterisks (\*). If an asterisk is used, fuzzy match is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MODULE::MyOrganization::MyService::MyUsecase</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
