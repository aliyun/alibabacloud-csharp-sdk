// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class AttachToPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of protection objects.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IpPortProtocolList")]
        [Validation(Required=false)]
        public string IpPortProtocolListShrink { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd8b4d70-e4e0-413a-b390-e71d********</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The version of the port-specific mitigation policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Not specified</b>: Associates the default surf anti-DDoS engine policy.</description></item>
        /// <item><description><b>2</b>: Associates the new stream anti-DDoS engine policy.<remarks>
        /// <para>Only port-specific mitigation policies support this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PortVersion")]
        [Validation(Required=false)]
        public string PortVersion { get; set; }

    }

}
