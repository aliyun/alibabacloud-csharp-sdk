// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class RecoveryContent : TeaModel {
        /// <summary>
        /// <para>The validity period configuration after authentication-based recovery. This parameter is used when RecoveryActions includes auth.</para>
        /// </summary>
        [NameInMap("AuthReportInterval")]
        [Validation(Required=false)]
        public AuthReportInterval AuthReportInterval { get; set; }

        /// <summary>
        /// <para>The set of recovery methods after mitigation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto</b>: Automatic recovery.</description></item>
        /// <item><description><b>auth</b>: Recovery after the user completes authentication.</description></item>
        /// <item><description><b>console</b>: Manual recovery by an administrator in the console.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecoveryActions")]
        [Validation(Required=false)]
        public List<string> RecoveryActions { get; set; }

    }

}
