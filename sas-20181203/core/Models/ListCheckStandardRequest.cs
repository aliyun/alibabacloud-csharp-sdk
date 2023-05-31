// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckStandardRequest : TeaModel {
        /// <summary>
        /// The instance IDs of the cloud services to which the check items belong.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The subtypes of cloud services.
        /// </summary>
        [NameInMap("InstanceSubTypes")]
        [Validation(Required=false)]
        public List<string> InstanceSubTypes { get; set; }

        /// <summary>
        /// The asset types of cloud services.
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The cloud service providers. Valid values:
        /// 
        /// *   **ALIYUN**: Alibaba Cloud
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
