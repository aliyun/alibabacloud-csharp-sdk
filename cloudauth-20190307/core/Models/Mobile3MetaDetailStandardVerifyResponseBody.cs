// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile3MetaDetailStandardVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. <b>200</b> indicates a successful response.</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FC3D6AC-9FED-4311-8DA7-C4BF47D9F260</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Mobile3MetaDetailStandardVerifyResponseBodyResultObject ResultObject { get; set; }
        public class Mobile3MetaDetailStandardVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Verification is consistent.</description></item>
            /// <item><description><b>2</b>: Verification is inconsistent.</description></item>
            /// <item><description><b>3</b>: No record found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The carrier name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CMCC</b>: China Mobile.</description></item>
            /// <item><description><b>CUCC</b>: China Unicom.</description></item>
            /// <item><description><b>CTCC</b>: China Telecom.</description></item>
            /// <item><description><b>CBCC</b>: China Broadnet.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <para>The detailed verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>101: Verification passed. All three elements are consistent.</description></item>
            /// <item><description>201: The phone number is inconsistent with both the name and the ID card number.</description></item>
            /// <item><description>202: The phone number is consistent with the name but inconsistent with the ID card number.</description></item>
            /// <item><description>203: The phone number is inconsistent with the name but consistent with the ID card number.</description></item>
            /// <item><description>204: Other inconsistency.</description></item>
            /// <item><description>301: No record found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

        }

    }

}
