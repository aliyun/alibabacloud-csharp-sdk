// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeKeyVersionRequest : TeaModel {
        /// <summary>
        /// The globally unique ID of the CMK.
        /// 
        /// You can also set this parameter to an alias that is bound to the CMK. For more information, see [Alias overview](https://help.aliyun.com/document_detail/68522.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The globally unique ID of the CMK version.
        /// 
        /// You can call the [ListKeyVersions](https://help.aliyun.com/document_detail/133966.html) operation to query the versions of the CMK.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

    }

}
