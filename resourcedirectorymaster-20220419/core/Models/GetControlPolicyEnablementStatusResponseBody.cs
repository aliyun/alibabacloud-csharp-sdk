// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetControlPolicyEnablementStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the Control Policy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The feature is enabled.</description></item>
        /// <item><description>PendingEnable: The feature is being enabled.</description></item>
        /// <item><description>Disabled: The feature is disabled.</description></item>
        /// <item><description>PendingDisable: The feature is being disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("EnablementStatus")]
        [Validation(Required=false)]
        public string EnablementStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1DC39A4E-3B52-4EFE-9F93-4897D7FFA0C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
