// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// 系统规定参数。取值：UntagResources。
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The type of the resources. Set the value to ALIYUN::LC::FLOW.
        /// 
        /// *   ALIYUN::LC::FLOW indicates Logic Composer workflows.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// system
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Specifies a maximum of 50 resource IDs.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
