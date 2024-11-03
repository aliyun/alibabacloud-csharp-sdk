// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class CheckCdnDomainICPResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the resource plan. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>DomainIsRegistration</b>: An ICP filing is obtained for the domain name.</description></item>
        /// <item><description><b>DomainNotRegistration</b>: No ICP filing is obtained for the domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DomainIsRegistration</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
