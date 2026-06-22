// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GrantSwitchAgreementRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether you agree to the data migration from the Hong Kong (China) region to the Singapore data center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Agree.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disagree.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAgree")]
        [Validation(Required=false)]
        public bool? IsAgree { get; set; }

        /// <summary>
        /// <para>Specifies whether the user confirms that the data migration from the Hong Kong (China) region to the Singapore data center has been completed.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Confirmed. The user has confirmed that the data migration from the Hong Kong (China) region to the Singapore data center has been completed, and the notification pop-up window no longer needs to be displayed.</description></item>
        /// <item><description><b>false</b>: Not confirmed. The user has not confirmed that the data migration from the Hong Kong (China) region to the Singapore data center has been completed, and the notification pop-up window still needs to be displayed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("IsConfirmed")]
        [Validation(Required=false)]
        public bool? IsConfirmed { get; set; }

        /// <summary>
        /// <para>Specifies whether to schedule data migration of data from the Hong Kong (China) region to the Singapore data center within 24 hours. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Schedule the switch within 24 hours.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not schedule. For users who have cloud services in the Hong Kong (China) region, data migration will be automatically completed on March 5, 2026. For users who do not have cloud services in the Hong Kong (China) region, data migration will be automatically completed on November 17, 2025.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsImmediate")]
        [Validation(Required=false)]
        public bool? IsImmediate { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The switch type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sg_switch</b>: data migration from the Hong Kong (China) region to the Singapore data center.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg_switch</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
