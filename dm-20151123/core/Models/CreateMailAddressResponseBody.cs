// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class CreateMailAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>Mail address ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>15123</para>
        /// </summary>
        [NameInMap("MailAddressId")]
        [Validation(Required=false)]
        public string MailAddressId { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>95A7D497-F8DD-4834-B81E-C1783236E55F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
