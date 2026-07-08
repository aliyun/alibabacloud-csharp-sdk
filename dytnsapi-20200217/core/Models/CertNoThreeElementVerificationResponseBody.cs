// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CertNoThreeElementVerificationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK: The request is successful.</description></item>
        /// <item><description>For other error codes, see the error code list below.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CertNoThreeElementVerificationResponseBodyData Data { get; set; }
        public class CertNoThreeElementVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the verification result is consistent. Returned values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: The name matches the ID card number, but they are recognized as not the same person.</para>
            /// </description></item>
            /// <item><description><para>1: The name matches the ID card number, and they are recognized as the same person.</para>
            /// </description></item>
            /// <item><description><para>2: The name matches the ID card number, and they are suspected to be the same person.</para>
            /// </description></item>
            /// <item><description><para>3: The name matches the ID card number, but no portrait information is found in the database.</para>
            /// </description></item>
            /// <item><description><para>4: Invalid identity information (the name does not match the ID card number).</para>
            /// </description></item>
            /// <item><description><para>5: The photo quality is unqualified.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsConsistent")]
            [Validation(Required=false)]
            public string IsConsistent { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68A40250-50CD-034C-B728-0BD******177</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
