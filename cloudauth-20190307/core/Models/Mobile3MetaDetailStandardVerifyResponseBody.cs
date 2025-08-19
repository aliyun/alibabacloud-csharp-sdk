// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile3MetaDetailStandardVerifyResponseBody : TeaModel {
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
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FC3D6AC-9FED-4311-8DA7-C4BF47D9F260</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Mobile3MetaDetailStandardVerifyResponseBodyResultObject ResultObject { get; set; }
        public class Mobile3MetaDetailStandardVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Verification result code:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Verification matches.</description></item>
            /// <item><description><b>2</b>: Verification does not match.</description></item>
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
            /// <para>ISP name:</para>
            /// <list type="bullet">
            /// <item><description><b>CMCC</b>: China Mobile.</description></item>
            /// <item><description><b>CUCC</b>: China Unicom.</description></item>
            /// <item><description><b>CTCC</b>: China Telecom.</description></item>
            /// <item><description><b>CBCC</b>: China Broadcasting Network.</description></item>
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
            /// <item><description>101: Passed, three elements are consistent.</description></item>
            /// <item><description>201: The phone number does not match the name and ID number.</description></item>
            /// <item><description>202: The phone number matches the name but does not match the ID number.</description></item>
            /// <item><description>203: The phone number does not match the name but matches the ID number.</description></item>
            /// <item><description>204: Other inconsistencies.</description></item>
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
