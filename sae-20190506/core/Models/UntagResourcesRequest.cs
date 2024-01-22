// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// false
        /// </summary>
        [NameInMap("DeleteAll")]
        [Validation(Required=false)]
        public bool? DeleteAll { get; set; }

        /// <summary>
        /// cn-beijing
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// \["d42921c4-5433-4abd-8075-0e536f8b\*\*\*\*"]
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// application
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// \["k1","k2"]
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeys { get; set; }

    }

}
