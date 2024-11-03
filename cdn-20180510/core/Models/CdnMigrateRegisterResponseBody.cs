// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class CdnMigrateRegisterResponseBody : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. You can specify only one domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64D28B53-5902-409B-94F6-FD46680144FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The registration status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>running</b></description></item>
        /// <item><description><b>succeed</b></description></item>
        /// <item><description><b>failed</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>succeed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
