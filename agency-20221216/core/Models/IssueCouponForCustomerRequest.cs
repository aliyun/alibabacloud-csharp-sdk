// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class IssueCouponForCustomerRequest : TeaModel {
        /// <summary>
        /// <para>The language parameter. Default value: none. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The reason for applying for the coupon. The reason can be up to 500 characters in length. Example: Apply for a coupon for Customer XXX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apply for a coupon for Customer XXX, who is XXXX</para>
        /// </summary>
        [NameInMap("ApplicationReason")]
        [Validation(Required=false)]
        public string ApplicationReason { get; set; }

        /// <summary>
        /// <para>The ID of the coupon template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5075915</para>
        /// </summary>
        [NameInMap("CouponTemplateId")]
        [Validation(Required=false)]
        public long? CouponTemplateId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to use the POC privilege quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Uses the POC privilege quota. If all submitted accounts are marked as approval-exempt, the current coupon application skips the approval process, and the POC privilege quota in your partner benefit package is deducted.</description></item>
        /// <item><description>false: Does not use the POC privilege quota. Regardless of the approval-exempt status of the submitted accounts, your POC coupon benefit quota remains unchanged. In this case, the application follows the standard coupon application approval process.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsUseBenefit")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? IsUseBenefit { get; set; }

        /// <summary>
        /// <para>The list of UIDs. Separate multiple UIDs with commas (,). Example: 111,2222.</para>
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
