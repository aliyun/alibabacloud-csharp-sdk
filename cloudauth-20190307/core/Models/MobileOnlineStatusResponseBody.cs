// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileOnlineStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success. Other values indicate failure.</para>
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
        /// <para>B506328A-D84B-4750-82C7-6A207C585CF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public MobileOnlineStatusResponseBodyResultObject ResultObject { get; set; }
        public class MobileOnlineStatusResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: active and available. </description></item>
            /// <item><description>2: not in an active and available state. For more information, see subCode.</description></item>
            /// <item><description>3: no query result.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The name of the telecommunications service provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CMCC: China Mobile. </description></item>
            /// <item><description>CUCC: China Unicom. </description></item>
            /// <item><description>CTCC: China Telecom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <para>The verification details. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>101: active and available. </description></item>
            /// <item><description>201: suspended. </description></item>
            /// <item><description>202: canceled. </description></item>
            /// <item><description>203: active but unavailable. </description></item>
            /// <item><description>204: not active. </description></item>
            /// <item><description>301: no record found.</description></item>
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
