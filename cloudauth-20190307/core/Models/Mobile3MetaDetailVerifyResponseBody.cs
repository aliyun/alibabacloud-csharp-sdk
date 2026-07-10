// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile3MetaDetailVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. <b>200</b> indicates that the request was successful.</para>
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
        /// <para>5A6229C0-E156-48E4-B6EC-0F528BDF60D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Mobile3MetaDetailVerifyResponseBodyResultObject ResultObject { get; set; }
        public class Mobile3MetaDetailVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Consistent.</description></item>
            /// <item><description><b>2</b>: Inconsistent.</description></item>
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
            /// <item><description><b>101</b>: Verification passed.</description></item>
            /// <item><description><b>201</b>: The phone number is inconsistent with the name, and the phone number is inconsistent with the ID card number.</description></item>
            /// <item><description><b>202</b>: The phone number is consistent with the name, but the phone number is inconsistent with the ID card number.</description></item>
            /// <item><description><b>203</b>: The phone number is consistent with the ID card number, but the phone number is inconsistent with the name.</description></item>
            /// <item><description><b>204</b>: Other inconsistency.</description></item>
            /// <item><description><b>301</b>: No record found.</description></item>
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
