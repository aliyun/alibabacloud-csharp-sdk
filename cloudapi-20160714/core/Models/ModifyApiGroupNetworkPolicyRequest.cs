// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyApiGroupNetworkPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the API group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The HTTPS security policy.
        /// </summary>
        [NameInMap("HttpsPolicy")]
        [Validation(Required=false)]
        public string HttpsPolicy { get; set; }

        /// <summary>
        /// Specifies whether to disable the public second-level domain name.
        /// </summary>
        [NameInMap("InnerDomainEnable")]
        [Validation(Required=false)]
        public bool? InnerDomainEnable { get; set; }

        /// <summary>
        /// Specifies whether to enable the virtual private cloud (VPC) second-level domain name.
        /// </summary>
        [NameInMap("InternetEnable")]
        [Validation(Required=false)]
        public bool? InternetEnable { get; set; }

        /// <summary>
        /// Specifies whether to enable IPv6. Valid values: **true** and **false**.
        /// </summary>
        [NameInMap("InternetIPV6Enable")]
        [Validation(Required=false)]
        public bool? InternetIPV6Enable { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// Specifies whether to enable the VPC domain name. Valid values:
        /// 
        /// *   TRUE
        /// *   FALSE
        /// </summary>
        [NameInMap("VpcIntranetEnable")]
        [Validation(Required=false)]
        public bool? VpcIntranetEnable { get; set; }

        /// <summary>
        /// Specifies whether to enable the self-calling domain name.
        /// </summary>
        [NameInMap("VpcSlbIntranetEnable")]
        [Validation(Required=false)]
        public bool? VpcSlbIntranetEnable { get; set; }

    }

}
