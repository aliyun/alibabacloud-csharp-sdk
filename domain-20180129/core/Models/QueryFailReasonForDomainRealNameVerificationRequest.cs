// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryFailReasonForDomainRealNameVerificationRequest : TeaModel {
        /// <summary>
        /// <para>Domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Language of error messages returned by the API. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.  </description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Review Type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>ACTIVATE</b>: New registration.  </description></item>
        /// <item><description><b>CHGHOLDER</b>: Change of holder.  </description></item>
        /// <item><description><b>TRANSFER</b>: Transfer-in.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVATE</para>
        /// </summary>
        [NameInMap("RealNameVerificationAction")]
        [Validation(Required=false)]
        public string RealNameVerificationAction { get; set; }

        /// <summary>
        /// <para>User IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
