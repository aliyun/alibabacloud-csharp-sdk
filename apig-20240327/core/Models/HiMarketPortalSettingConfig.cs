// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketPortalSettingConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically approve new developer registrations. If set to <c>false</c>, you must manually approve each new developer.\
        /// \
        /// <b>Default</b>: <c>false</c>.\
        /// \</para>
        /// </summary>
        [NameInMap("autoApproveDevelopers")]
        [Validation(Required=false)]
        public bool? AutoApproveDevelopers { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically approve new API subscriptions. If set to <c>false</c>, you must manually approve each new subscription.\
        /// \
        /// <b>Default</b>: <c>false</c>.\
        /// \</para>
        /// </summary>
        [NameInMap("autoApproveSubscriptions")]
        [Validation(Required=false)]
        public bool? AutoApproveSubscriptions { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable built-in authentication. If set to <c>true</c>, users must sign in to access the portal.\
        /// \
        /// <b>Default</b>: <c>false</c>.\
        /// \</para>
        /// </summary>
        [NameInMap("builtinAuthEnabled")]
        [Validation(Required=false)]
        public bool? BuiltinAuthEnabled { get; set; }

    }

}
