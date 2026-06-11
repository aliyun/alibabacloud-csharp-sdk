// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class TrialOrderEligibilityVO : TeaModel {
        /// <summary>
        /// <para>Contains details about the eligibility status, such as the reason for ineligibility.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the user is eligible for the trial.</para>
        /// </summary>
        [NameInMap("Valid")]
        [Validation(Required=false)]
        public bool? Valid { get; set; }

    }

}
