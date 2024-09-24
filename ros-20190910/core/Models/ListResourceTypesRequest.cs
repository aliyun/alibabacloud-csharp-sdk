// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListResourceTypesRequest : TeaModel {
        /// <summary>
        /// <para>The entity type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>All: all types of resources.</description></item>
        /// <item><description>Resource (default): regular resources. For more information, see <a href="https://help.aliyun.com/document_detail/28863.html">Resources</a>.</description></item>
        /// <item><description>DataSource: DataSource resources. For more information, see <a href="https://help.aliyun.com/document_detail/404753.html">DataSource resources</a>.</description></item>
        /// <item><description>Module: modules.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Resource</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The provider of the resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ROS (default): The resource type is provided by Resource Orchestration Service (ROS).</description></item>
        /// <item><description>Self: The resource type is provided by you.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ROS</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The resource type. The resource type can contain letters, digits, colons (:), and asterisks (\<em>). You can use an asterisk (\</em>) to perform a fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MODULE::MyOrganization::MyService::MyUsecase</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
