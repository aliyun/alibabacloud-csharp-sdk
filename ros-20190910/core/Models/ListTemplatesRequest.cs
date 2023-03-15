// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplatesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the information about tags. Default value: Disabled. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public string IncludeTags { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// For more information about resource groups, see the "Resource Group" section of the [What is Resource Management?](~~94475~~) topic.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The sharing type of the template.
        /// 
        /// Default value: Private. Valid values:
        /// 
        /// *   Private: The template belongs to the template owner.
        /// *   Shared: The template is shared with other users.
        /// *   Official: The template is the shared template of the official version.
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTemplatesRequestTag> Tag { get; set; }
        public class ListTemplatesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N. This parameter takes effect only when the ShareType parameter is set to Private.
            /// 
            /// You can specify up to 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag N. This parameter takes effect only when the ShareType parameter is set to Private.
            /// 
            /// You can specify up to 20 tag values.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The name of the template. This parameter takes effect only when the ShareType parameter is set to Private.
        /// 
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or letter.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
