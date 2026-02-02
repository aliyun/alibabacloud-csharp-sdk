// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntElementVerifyV2Request : TeaModel {
        /// <summary>
        /// <para>Enterprise Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****有限公司</para>
        /// </summary>
        [NameInMap("EntName")]
        [Validation(Required=false)]
        public string EntName { get; set; }

        /// <summary>
        /// <para>Type of enterprise element verification.</para>
        /// <list type="bullet">
        /// <item><description>ENT_2META: Two-element verification (enterprise name + unified social credit code)</description></item>
        /// <item><description>ENT_3META: Three-element verification (enterprise name + unified social credit code + legal person\&quot;s name or organization head)</description></item>
        /// <item><description>ENT_4META: Four-element verification (enterprise name + unified social credit code + legal person\&quot;s name or organization head + legal person\&quot;s ID number)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENT_2META</para>
        /// </summary>
        [NameInMap("InfoVerifyType")]
        [Validation(Required=false)]
        public string InfoVerifyType { get; set; }

        /// <summary>
        /// <para>Legal Person\&quot;s ID Number. Required for four-element scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1******************9</para>
        /// </summary>
        [NameInMap("LegalPersonCertNo")]
        [Validation(Required=false)]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// <para>Legal Person\&quot;s Name. Required for three-element and four-element scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张**</para>
        /// </summary>
        [NameInMap("LegalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// <para>Unified Social Credit Code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91330106673959****</para>
        /// </summary>
        [NameInMap("LicenseNo")]
        [Validation(Required=false)]
        public string LicenseNo { get; set; }

        /// <summary>
        /// <para>A unique business identifier defined by the merchant side, used for subsequent problem localization and troubleshooting. Supports a combination of letters and numbers, with a maximum length of 32 characters. Please ensure uniqueness.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c35****</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Merchant-side user ID. Supports a combination of letters and numbers, with a maximum length of 32 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mch7x9a2b4c8d3e5f6g1h2i3j4k5****</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>Custom scene code, defined by the user to distinguish between different business scenarios. Supports a combination of letters, numbers, and underscores, with a maximum length of 32 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000006</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>Whether user authorization has been obtained.</para>
        /// <list type="bullet">
        /// <item><description>1: Authorization obtained</description></item>
        /// <item><description>0: No authorization obtained</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserAuthorization")]
        [Validation(Required=false)]
        public string UserAuthorization { get; set; }

    }

}
