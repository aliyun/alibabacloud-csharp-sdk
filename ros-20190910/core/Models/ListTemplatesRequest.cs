// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>Filter.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListTemplatesRequestFilters> Filters { get; set; }
        public class ListTemplatesRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter. You can choose one or more names for the query. Value range:  </para>
            /// <list type="bullet">
            /// <item><description>Categories: Template categories  </description></item>
            /// <item><description>DeployTypes: Deployment types  </description></item>
            /// <item><description>ApplicationScenes: Application scenarios  </description></item>
            /// <item><description>BasicServices: Basic services  </description></item>
            /// <item><description>ResourceTypes: Resource types  </description></item>
            /// <item><description>TemplateNames: Template names</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Categories</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of filter values.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>Whether to query tag information. Values:  </para>
        /// <list type="bullet">
        /// <item><description>Enabled: Query.  </description></item>
        /// <item><description>Disabled (default): Do not query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public string IncludeTags { get; set; }

        /// <summary>
        /// <para>The page number of the template list.<br>Start value: 1.<br>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paginated query.<br>Value range: 1~50.<br>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.<br>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.html">What is a Resource Group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The sharing type of the template.  </para>
        /// <para>Values:  </para>
        /// <list type="bullet">
        /// <item><description>Private (default): The template is owned by the user.  </description></item>
        /// <item><description>Shared: The template is shared by other users.  </description></item>
        /// <item><description>Official: The template is officially shared.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Private</para>
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// <para>Tags. A maximum of 20 tags are supported.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTemplatesRequestTag> Tag { get; set; }
        public class ListTemplatesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. This parameter is effective only when ShareType is Private.  </para>
            /// <para>A maximum of 20 tag keys are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. This parameter is effective only when ShareType is Private.  </para>
            /// <para>A maximum of 20 tag values are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deploy</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the template. This parameter is effective only when ShareType is Private.<br>The length must not exceed 255 characters and must start with a digit or a letter. It can contain digits, letters, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
