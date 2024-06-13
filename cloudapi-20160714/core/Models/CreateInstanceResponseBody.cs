// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        /// <summary>
        /// Instance ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Request ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the tag exists. Valid values: **true** and **false**.
        /// </summary>
        [NameInMap("TagStatus")]
        [Validation(Required=false)]
        public bool? TagStatus { get; set; }

    }

}
