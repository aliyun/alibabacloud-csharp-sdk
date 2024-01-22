// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateNamespaceVpcRequest : TeaModel {
        [NameInMap("NameSpaceShortId")]
        [Validation(Required=false)]
        public string NameSpaceShortId { get; set; }

        /// <summary>
        /// vpc-2ze0i263cnn311nvj\*\*\*\*
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
