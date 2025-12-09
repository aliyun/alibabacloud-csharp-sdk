// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GrantSwitchAgreementRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether to agree to migrate the client connections from overseas servers to the Singapore center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAgree")]
        [Validation(Required=false)]
        public bool? IsAgree { get; set; }

        /// <summary>
        /// <para>Has the user confirmed the migration of Hong Kong region data to Singapore data center</para>
        /// <list type="bullet">
        /// <item><description><para><b>true:</b> The user has confirmed that Hong Kong region data has been migrated to the Singapore data center. No notification popup needs to be displayed subsequently.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>:The user has not confirmed that Hong Kong region data has been migrated to the Singapore data center. Notification popup still needs to be displayed subsequently.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsConfirmed")]
        [Validation(Required=false)]
        public bool? IsConfirmed { get; set; }

        /// <summary>
        /// <para>Whether to schedule the migration of data from the Hong Kong region to the Singapore data center within 24 hours. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Schedule the switch within 24 hours.</description></item>
        /// <item><description><b>false</b>: Do not schedule. Users with cloud products in the Hong Kong region will be automatically migrated on March 5, 2026; users without cloud products in the Hong Kong region will be automatically migrated on November 17, 2025.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsImmediate")]
        [Validation(Required=false)]
        public bool? IsImmediate { get; set; }

        /// <summary>
        /// <para>The language type for requests and responses. The default value is <b>zh</b>. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Switching type. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>sg_switch</b>: Migrate client connections from overseas servers to Singapore</description></item>
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
