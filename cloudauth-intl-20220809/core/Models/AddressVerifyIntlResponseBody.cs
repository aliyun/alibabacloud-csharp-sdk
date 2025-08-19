// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86C40EC3-5940-5F47-995C-BFE90B70E540</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public AddressVerifyIntlResponseBodyResultObject ResultObject { get; set; }
        public class AddressVerifyIntlResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Address verification details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0-3000</para>
            /// </summary>
            [NameInMap("AddressInfo")]
            [Validation(Required=false)]
            public string AddressInfo { get; set; }

            /// <summary>
            /// <para>Operator name:</para>
            /// <list type="bullet">
            /// <item><description>CMCC: China Mobile</description></item>
            /// <item><description>CTCC: China Telecom</description></item>
            /// <item><description>CUCC: China Unicom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <para>Verification result, values:</para>
            /// <list type="bullet">
            /// <item><description>Y: Yes, the verified address distance is less than or equal to 10KM.</description></item>
            /// <item><description>N: No, the verified address distance is greater than 10KM.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>Authentication result description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>Unique identifier for the authentication request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hksb7ba1b28130d24e015d69********</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
