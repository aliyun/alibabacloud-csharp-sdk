// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the domain name.</para>
        /// </summary>
        [NameInMap("DomainInfo")]
        [Validation(Required=false)]
        public ModifyDomainResponseBodyDomainInfo DomainInfo { get; set; }
        public class ModifyDomainResponseBodyDomainInfo : TeaModel {
            /// <summary>
            /// <para>The CNAME that is assigned by WAF to the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxcvdaf.****.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The domain name whose access configurations you modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The ID of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com-waf">www.aliyundoc.com-waf</a></para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
