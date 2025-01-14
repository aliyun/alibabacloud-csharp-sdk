// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class RevokeEndpointAclShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>allow</para>
        /// </summary>
        [NameInMap("AclStrategy")]
        [Validation(Required=false)]
        public string AclStrategy { get; set; }

        [NameInMap("CidrList")]
        [Validation(Required=false)]
        public string CidrListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

    }

}
