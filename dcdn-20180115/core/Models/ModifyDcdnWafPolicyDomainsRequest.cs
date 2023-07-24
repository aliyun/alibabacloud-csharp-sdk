// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyDcdnWafPolicyDomainsRequest : TeaModel {
        /// <summary>
        /// The domain names that you want to bind to the protection policy. You can specify up to 50 domain names. Separate multiple domain names with commas (,).
        /// 
        /// > You can configure either **BindDomains** or **UnbindDomains**.
        /// </summary>
        [NameInMap("BindDomains")]
        [Validation(Required=false)]
        public string BindDomains { get; set; }

        /// <summary>
        /// The change method. Valid values:
        /// 
        /// *   0: replace
        /// *   1: add
        /// *   Default value: 0.
        /// 
        /// > 
        /// 
        /// *   This parameter takes effect only when you specify **BindDomains**. If you have bound a domain name indicated by **BindDomains** to the default protection policy, the `Policy.DefaultAndCustom.BindToSameDomain` error is returned.
        /// 
        /// *   You can only replace accelerated domain names that are bound to the default protection policy.
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public int? Method { get; set; }

        /// <summary>
        /// The ID of the protection policy. You can specify only one ID in each request.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// The domain names that you want to unbind from the protection policy. You can specify up to 50 domain names. Separate multiple domain names with commas (,).
        /// 
        /// > You can configure either **BindDomains** or **UnbindDomains**.
        /// </summary>
        [NameInMap("UnbindDomains")]
        [Validation(Required=false)]
        public string UnbindDomains { get; set; }

    }

}
