// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeSecurityAgentStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the Security Center agent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pause: The Security Center agent suspends protection for your server.</description></item>
        /// <item><description>online: The Security Center agent is protecting your server.</description></item>
        /// <item><description>offline: The Security Center agent does not protect your server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("ClientStatus")]
        [Validation(Required=false)]
        public string ClientStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F534F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
