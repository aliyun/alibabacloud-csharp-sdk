// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitCardVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates success. Other values indicate failure.</para>
        /// <remarks>
        /// <para><b>Important</b> This parameter indicates whether the operation is called correctly. For more information about return codes, see error codes. Check the fields in ResultObject for the business result.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF039795</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public InitCardVerifyResponseBodyResultObject ResultObject { get; set; }
        public class InitCardVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The verification request ID, which is the unique identifier of the verification service authentication request.</para>
            /// <list type="bullet">
            /// <item><description><para>You must specify the authentication request ID when you query the authentication result.</para>
            /// </description></item>
            /// <item><description><para>The CertifyId field is used for billing statistics. Save this field locally for future bill reconciliation. The CertifyId returned by the initialization operation is valid for 30 minutes and can be submitted for authentication only once. Use it within the validity period and do not reuse it.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>91707dc296d469ad38e4c5efa6a0****</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

        }

    }

}
