// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceTDEInfoResponseBody : TeaModel {
        /// <summary>
        /// The custom key of the instance.
        /// 
        /// The Bring Your Own Key (BYOK) feature allows you to manage and obtain your own encryption key. This feature is supported only in the following regions:
        /// 
        /// *   cn-hangzhou
        /// *   cn-shanghai
        /// *   cn-beijing
        /// *   cn-shenzhen
        /// *   cn-hongkong
        /// *   ap-southeast-1
        /// *   ap-southeast-3
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// The encryption algorithm.
        /// </summary>
        [NameInMap("EncryptorName")]
        [Validation(Required=false)]
        public string EncryptorName { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role to which you want to grant permissions.
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// The TDE status. Valid values:
        /// 
        /// *   **enabled**
        /// *   **disabled**
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
