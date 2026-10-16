// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class EnableControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the control policy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: Enabled.</description></item>
        /// <item><description>PendingEnable: Being enabled.</description></item>
        /// <item><description>Disabled: Disabled.</description></item>
        /// <item><description>PendingDisable: Being disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PendingEnable</para>
        /// </summary>
        [NameInMap("EnablementStatus")]
        [Validation(Required=false)]
        public string EnablementStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CE7BD95-EFFA-4911-A1E0-BD4412697FEB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
