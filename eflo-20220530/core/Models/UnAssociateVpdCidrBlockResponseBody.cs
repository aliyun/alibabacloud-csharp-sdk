// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UnAssociateVpdCidrBlockResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public UnAssociateVpdCidrBlockResponseBodyContent Content { get; set; }
        public class UnAssociateVpdCidrBlockResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The ID of the Lingjun CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-ze3na0wf</para>
            /// </summary>
            [NameInMap("VpdId")]
            [Validation(Required=false)]
            public string VpdId { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C50C9CD-E799-54DA-BA7A-1FAF3DF80857</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
