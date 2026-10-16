// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetControlPolicyEnablementStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the control policy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The control policy feature is enabled.</description></item>
        /// <item><description>PendingEnable: The control policy feature is being enabled.</description></item>
        /// <item><description>Disabled: The control policy feature is disabled.</description></item>
        /// <item><description>PendingDisable: The control policy feature is being disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("EnablementStatus")]
        [Validation(Required=false)]
        public string EnablementStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1DC39A4E-3B52-4EFE-9F93-4897D7FFA0C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
