// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class SourceMNSParameters : TeaModel {
        /// <summary>
        /// IsBase64Decode
        /// </summary>
        [NameInMap("IsBase64Decode")]
        [Validation(Required=false)]
        public bool? IsBase64Decode { get; set; }

        /// <summary>
        /// QueueName
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// RegionId
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
