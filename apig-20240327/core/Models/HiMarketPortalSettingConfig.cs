// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketPortalSettingConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically approve developer registration requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoApproveDevelopers")]
        [Validation(Required=false)]
        public bool? AutoApproveDevelopers { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically approve API subscription requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoApproveSubscriptions")]
        [Validation(Required=false)]
        public bool? AutoApproveSubscriptions { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable username-password authentication (built-in authentication).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("builtinAuthEnabled")]
        [Validation(Required=false)]
        public bool? BuiltinAuthEnabled { get; set; }

    }

}
