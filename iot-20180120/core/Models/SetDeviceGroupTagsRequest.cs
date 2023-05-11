// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class SetDeviceGroupTagsRequest : TeaModel {
        /// <summary>
        /// The ID of the group. The ID is the globally unique identifier (GUID) for the group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The type of the group.
        /// 
        /// You do not need to configure this parameter.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The ID of the instance. On the **Overview** page in the IoT Platform console, you can view the **ID** of the instance.
        /// 
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// >*   If the **Overview** page or instance ID is not displayed in the IoT Platform console, you do not need to configure this parameter.
        /// 
        /// For more information about the instance, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The tag data in the JSON format. The TagString parameter specifies multiple tags in the format of key-value pairs. You must specify **tagKey** and **tagValue** for each tag.
        /// 
        /// *   **tagKey**: the tag key. The key must be 2 to 30 characters in length, and can contain letters, digits, and periods (.).
        /// *   **tagValue**: the tag value. Each value can contain letters, digits, underscores (\_), and hyphens (-). The value must be 1 to 128 characters in length.
        /// 
        /// Separate multiple tags with commas (,). Example: `[{"tagKey":"h1","tagValue":"rr"},{"tagKey":"7h","tagValue":"rr"}]`
        /// 
        /// If you specify a new value for an existing tag, the new tag value overwrites the original value.
        /// 
        /// If you want to delete a tag, you do not need to specify the key and value for the tag.
        /// 
        /// **
        /// 
        /// **Important** `abc` is a key that is reserved by IoT Platform. You cannot set **tagKey** to abc. If you set `tagKey` to abc, the abc tag is automatically filtered when you query tags.
        /// </summary>
        [NameInMap("TagString")]
        [Validation(Required=false)]
        public string TagString { get; set; }

    }

}
