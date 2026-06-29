// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class CreateTokenPlanInviteLinkRequest : TeaModel {
        /// <summary>
        /// <para>The expiration period. Default value: DAYS_7. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAYS_7</description></item>
        /// <item><description>DAYS_30</description></item>
        /// <item><description>MONTHS_6</description></item>
        /// <item><description>YEAR_1</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAYS_7</para>
        /// </summary>
        [NameInMap("ExpireType")]
        [Validation(Required=false)]
        public string ExpireType { get; set; }

        /// <summary>
        /// <para>The SSO logon method bound to the invitation link. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SAML</description></item>
        /// <item><description>DINGTALK</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAML</para>
        /// </summary>
        [NameInMap("SsoSource")]
        [Validation(Required=false)]
        public string SsoSource { get; set; }

    }

}
