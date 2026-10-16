// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class DisableControlPolicyResponseBody : TeaModel {
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
        /// <para>PendingDisable</para>
        /// </summary>
        [NameInMap("EnablementStatus")]
        [Validation(Required=false)]
        public string EnablementStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C709979-451D-4C92-835D-7DDCCAA562E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
