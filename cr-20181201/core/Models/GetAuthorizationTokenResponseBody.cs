// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetAuthorizationTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The password that you use to log on to the registry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shaunadadakks:uuczxnjcyeyhdjadkkajsjdjadhyucb</para>
        /// </summary>
        [NameInMap("AuthorizationToken")]
        [Validation(Required=false)]
        public string AuthorizationToken { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The timestamp when the temporary token expired. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1571242083000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>E069EB86-E6AD-4A98-ADDE-0E993390239A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The username that you use to log on to the registry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temp_user_cr</para>
        /// </summary>
        [NameInMap("TempUsername")]
        [Validation(Required=false)]
        public string TempUsername { get; set; }

    }

}
