// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class AddYikeUserCreditResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when the increase fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NOT_ENOUGH_ALLOCATE_CREDIT_QUOTA: The primary account does not have sufficient credit balance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NOT_ENOUGH_ALLOCATE_CREDIT_QUOTA</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the credits were increased successfully.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
