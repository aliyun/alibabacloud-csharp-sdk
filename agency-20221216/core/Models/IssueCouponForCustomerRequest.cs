// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class IssueCouponForCustomerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>为客户XXX审批优惠券，该客户是XXXX</para>
        /// </summary>
        [NameInMap("ApplicationReason")]
        [Validation(Required=false)]
        public string ApplicationReason { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5075915</para>
        /// </summary>
        [NameInMap("CouponTemplateId")]
        [Validation(Required=false)]
        public long? CouponTemplateId { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("IsUseBenefit")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? IsUseBenefit { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111,2222</para>
        /// </summary>
        [NameInMap("Uidlist")]
        [Validation(Required=false)]
        public string Uidlist { get; set; }

    }

}
