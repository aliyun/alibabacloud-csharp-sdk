// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class CreateIpamResponseBody : TeaModel {
        [NameInMap("DefaultResourceDiscoveryAssociationId")]
        [Validation(Required=false)]
        public string DefaultResourceDiscoveryAssociationId { get; set; }

        [NameInMap("DefaultResourceDiscoveryId")]
        [Validation(Required=false)]
        public string DefaultResourceDiscoveryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ipam-ccxbnsbhew0d6t****</para>
        /// </summary>
        [NameInMap("IpamId")]
        [Validation(Required=false)]
        public string IpamId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ipam-scope-8wiontzmiy6cg0****</para>
        /// </summary>
        [NameInMap("PrivateDefaultScopeId")]
        [Validation(Required=false)]
        public string PrivateDefaultScopeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ipam-scope-r5c5c7bmym1brc****</para>
        /// </summary>
        [NameInMap("PublicDefaultScopeId")]
        [Validation(Required=false)]
        public string PublicDefaultScopeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED39DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceDiscoveryAssociationCount")]
        [Validation(Required=false)]
        public int? ResourceDiscoveryAssociationCount { get; set; }

    }

}
