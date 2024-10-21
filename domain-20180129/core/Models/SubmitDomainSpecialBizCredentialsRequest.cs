// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SubmitDomainSpecialBizCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>219</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public long? BizId { get; set; }

        /// <summary>
        /// <para>The certificate information.</para>
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public string Credentials { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;addTransferLock\&quot;:true}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
