// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplatesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the tag information. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled (default)
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public string IncludeTags { get; set; }

        /// <summary>
        /// The page number.\\
        /// Pages start from page 1.\\
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.\\
        /// Valid values: 1 to 50.\\
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group.\\
        /// For more information about resource groups, see the "Resource Group" section of [What is Resource Management?](https://help.aliyun.com/document_detail/94475.html)
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The sharing type of the template.
        /// 
        /// Valid values:
        /// 
        /// *   Private (default): The template belongs to the template owner.
        /// *   Shared: The template is shared with other users.
        /// *   Official: The template is the shared template of the official version.
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// The tags. You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTemplatesRequestTag> Tag { get; set; }
        public class ListTemplatesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. This parameter takes effect only when ShareType is set to Private.
            /// 
            /// You can specify up to 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. This parameter takes effect only when ShareType is set to Private.
            /// 
            /// You can specify up to 20 tag values.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The template name. This parameter takes effect only when ShareType is set to Private. The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). The name must start with a digit or letter.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
