// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all tags from the specified resource groups or members. Valid values:
        /// 
        /// *   false (default value)
        /// *   true
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The ID of a resource group or member.
        /// 
        /// You can specify a maximum of 50 IDs.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the objects from which you want to remove tags. Valid values:
        /// 
        /// *   ResourceGroup: resource group. This is the default value.
        /// *   Account: member.
        /// 
        /// >  This parameter is required if you remove tags from members in a resource directory.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// A tag key.
        /// 
        /// You can specify a maximum of 20 tag keys.
        /// 
        /// >  If you set the `All` parameter to `true`, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
