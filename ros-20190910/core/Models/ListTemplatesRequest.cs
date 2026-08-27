// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The filter.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListTemplatesRequestFilters> Filters { get; set; }
        public class ListTemplatesRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter name. You can select one or more names to query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Categories: template category</para>
            /// </description></item>
            /// <item><description><para>DeployTypes: deployment type</para>
            /// </description></item>
            /// <item><description><para>ApplicationScenes: application scenario</para>
            /// </description></item>
            /// <item><description><para>BasicServices: basic service</para>
            /// </description></item>
            /// <item><description><para>ResourceTypes: resource type</para>
            /// </description></item>
            /// <item><description><para>TemplateNames: template name</para>
            /// </description></item>
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
        /// <para>Specifies whether to query tag information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Enabled: queries tag information.</para>
        /// </description></item>
        /// <item><description><para>Disabled (default): does not query tag information.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public string IncludeTags { get; set; }

        /// <summary>
        /// <para>The page number of the template list.<br> The value starts from 1.<br> Default value: 1.<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query.<br> Valid values: 1 to 50.<br> Default value: 10.<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.<br> For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.html">What is a resource group?</a>.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The share type of the template.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Private (default): The template is owned by the user.</para>
        /// </description></item>
        /// <item><description><para>Shared: The template is shared by other users.</para>
        /// </description></item>
        /// <item><description><para>Official: The template is a shared official template.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Private</para>
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// <para>The tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTemplatesRequestTag> Tag { get; set; }
        public class ListTemplatesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. This parameter takes effect only when ShareType is set to Private.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. This parameter takes effect only when ShareType is set to Private.</para>
            /// <para>You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deploy</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the template. This parameter takes effect only when ShareType is set to Private. The name can be up to 255 characters in length. It must start with a digit or a letter and can contain digits, letters, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
