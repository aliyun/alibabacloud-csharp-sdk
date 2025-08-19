// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile3MetaDetailVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code, <b>200</b> indicates a successful API response.</para>
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
        /// <para>5A6229C0-E156-48E4-B6EC-0F528BDF60D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Mobile3MetaDetailVerifyResponseBodyResultObject ResultObject { get; set; }
        public class Mobile3MetaDetailVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Verification result code:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Verification consistent.</description></item>
            /// <item><description><b>2</b>: Verification inconsistent.</description></item>
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
            /// <para>Operator name:</para>
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
            /// <para>Detailed verification results:</para>
            /// <list type="bullet">
            /// <item><description><b>101</b>: Verification passed.</description></item>
            /// <item><description><b>201</b>: Mobile number and name do not match, mobile number and ID number do not match.</description></item>
            /// <item><description><b>202</b>: Mobile number and name match, but mobile number and ID number do not match.</description></item>
            /// <item><description><b>203</b>: Mobile number and ID number match, but mobile number and name do not match.</description></item>
            /// <item><description><b>204</b>: Other inconsistencies.</description></item>
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
