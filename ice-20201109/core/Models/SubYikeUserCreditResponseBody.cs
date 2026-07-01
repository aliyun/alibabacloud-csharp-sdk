// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubYikeUserCreditResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the operation fails. A possible value is:</para>
        /// <list type="bullet">
        /// <item><description><c>NOT_ENOUGH_ALLOCATE_CREDIT_QUOTA</c>: The sub-account\&quot;s credit balance is insufficient.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NOT_ENOUGH_ALLOCATE_CREDIT_QUOTA</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The operation succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The operation failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
