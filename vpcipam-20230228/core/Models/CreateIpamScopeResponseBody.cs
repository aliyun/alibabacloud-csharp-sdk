// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class CreateIpamScopeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ipam-scope-glfmcyldpm8lsy****</para>
        /// </summary>
        [NameInMap("IpamScopeId")]
        [Validation(Required=false)]
        public string IpamScopeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E897D16A-50EB-543F-B002-C5A26AB818FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
