// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class UpgradeServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DB0F536-B3BE-4F0D-BD29-E83FB56D550C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The new parameters required for the service upgrade. This parameter is returned only when DryRun is set to true. Include these parameters in the request when you perform the upgrade.</para>
        /// </summary>
        [NameInMap("UpgradeRequiredParameters")]
        [Validation(Required=false)]
        public List<string> UpgradeRequiredParameters { get; set; }

    }

}
