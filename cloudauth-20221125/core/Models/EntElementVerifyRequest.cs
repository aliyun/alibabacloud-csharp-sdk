// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntElementVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Enterprise name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>***有限公司</para>
        /// </summary>
        [NameInMap("EntName")]
        [Validation(Required=false)]
        public string EntName { get; set; }

        /// <summary>
        /// <para>Type of enterprise element verification.</para>
        /// <list type="bullet">
        /// <item><description>ENT_2META: Two elements</description></item>
        /// <item><description>ENT_3META: Three elements</description></item>
        /// <item><description>ENT_4META: Four elements</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENT_2META</para>
        /// </summary>
        [NameInMap("InfoVerifyType")]
        [Validation(Required=false)]
        public string InfoVerifyType { get; set; }

        /// <summary>
        /// <para>Legal representative\&quot;s ID number. Required for the four-element scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>370105*****3892</para>
        /// </summary>
        [NameInMap("LegalPersonCertNo")]
        [Validation(Required=false)]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// <para>Legal representative\&quot;s name. Required for three-element and four-element scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张**</para>
        /// </summary>
        [NameInMap("LegalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// <para>Business license number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32132***328932</para>
        /// </summary>
        [NameInMap("LicenseNo")]
        [Validation(Required=false)]
        public string LicenseNo { get; set; }

        /// <summary>
        /// <para>A unique business identifier defined by the merchant for subsequent troubleshooting. It supports a combination of letters and numbers, with a maximum length of 32 characters. Please ensure uniqueness.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32198****193000</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Merchant-side user ID. Supports a combination of letters and numbers, with a maximum length of 32 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>432***421</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>Scene code. Supports a combination of letters, numbers, and underscores, with a maximum length of 32 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>withdraw</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>Whether user authorization is obtained.</para>
        /// <list type="bullet">
        /// <item><description>1: Authorized</description></item>
        /// <item><description>0: Not authorized</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserAuthorization")]
        [Validation(Required=false)]
        public string UserAuthorization { get; set; }

    }

}
