// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Receiving account, to assist in improving the risk assessment effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>321324***38293</para>
        /// </summary>
        [NameInMap("AccountNo")]
        [Validation(Required=false)]
        public string AccountNo { get; set; }

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
        /// <para>Enterprise element verification type, currently not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("InfoVerifyType")]
        [Validation(Required=false)]
        public string InfoVerifyType { get; set; }

        /// <summary>
        /// <para>Legal person\&quot;s ID number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>370105*****3892</para>
        /// </summary>
        [NameInMap("LegalPersonCertNo")]
        [Validation(Required=false)]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// <para>Legal person\&quot;s mobile phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1300***53</para>
        /// </summary>
        [NameInMap("LegalPersonMobile")]
        [Validation(Required=false)]
        public string LegalPersonMobile { get; set; }

        /// <summary>
        /// <para>Legal person\&quot;s name.</para>
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
        /// <para>A unique business identifier defined by the merchant, used for subsequent problem localization and troubleshooting. It supports a combination of letters and numbers, with a maximum length of 32 characters. Please ensure its uniqueness.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32198****193000</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Merchant-side user ID. It supports a combination of letters and numbers, with a maximum length of 32 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>432***421</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>Enterprise risk verification model version, required when RiskVerifyType is not empty. Currently supported:</para>
        /// <list type="bullet">
        /// <item><description>BASIC: Basic version</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("RiskModelVersion")]
        [Validation(Required=false)]
        public string RiskModelVersion { get; set; }

        /// <summary>
        /// <para>Enterprise risk verification type, at least one of InfoVerifyType or this must be selected. Currently supported:</para>
        /// <list type="bullet">
        /// <item><description>BUSINESS_ANTIFRAUD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUSINESS_ANTIFRAUD</para>
        /// </summary>
        [NameInMap("RiskVerifyType")]
        [Validation(Required=false)]
        public string RiskVerifyType { get; set; }

        /// <summary>
        /// <para>Scene code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>withdraw</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>Whether the user authorization is obtained.</para>
        /// <list type="bullet">
        /// <item><description><para>1: Authorized</para>
        /// </description></item>
        /// <item><description><para>0: Not authorized</para>
        /// </description></item>
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
