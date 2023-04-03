// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UntagResourcesRequest : TeaModel {
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The language in which you want the values of some response parameters to be returned. These response parameters support multiple languages.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// Resource Type
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Specifies whether to remove all tags from the specified resource. Default value: false. This parameter takes effect only when the TagKey.N parameter is not specified. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
