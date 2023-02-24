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
        /// You can also set this parameter to an alias that is bound to the CMK. For more information, see [Alias overview](~~68522~~).
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The globally unique ID of the CMK version.
        /// 
        /// You can call the [ListKeyVersions](~~133966~~) operation to query the versions of the CMK.
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

    }

}
