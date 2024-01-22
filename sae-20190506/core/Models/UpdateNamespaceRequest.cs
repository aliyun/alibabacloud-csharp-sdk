// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateNamespaceRequest : TeaModel {
        [NameInMap("EnableMicroRegistration")]
        [Validation(Required=false)]
        public bool? EnableMicroRegistration { get; set; }

        /// <summary>
        /// The short ID of the namespace. You do not need to specify a region ID. We recommend that you configure this parameter. The value of this parameter can be up to 20 characters in length and can contain only lowercase letters and digits.
        /// </summary>
        [NameInMap("NameSpaceShortId")]
        [Validation(Required=false)]
        public string NameSpaceShortId { get; set; }

        /// <summary>
        /// The description of the namespace. The description cannot exceed 100 characters in length.
        /// </summary>
        [NameInMap("NamespaceDescription")]
        [Validation(Required=false)]
        public string NamespaceDescription { get; set; }

        /// <summary>
        /// The long ID of the namespace. If you configure this parameter, the long ID take effects and the value of the NameSpaceShortId parameter is ignored. To ensure compatibility, we recommend that you specify a short namespace ID. A long namespace ID follows the `<RegionId>:<NamespaceId>` format. The `NamespaceId` variable can contain only lowercase letters and digits. Example: `cn-beijing:test`. The value of the NamespaceId variable cannot exceed 32 characters in length. For more information about **RegionId**, you can call the [DescribeRegions](~~126213~~) operation to obtain the IDs of regions supported by SAE.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// The name of the namespace. The name cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

    }

}
