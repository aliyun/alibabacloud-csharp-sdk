// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileOnlineStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 for success, others for failure.</para>
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
        /// <para>B506328A-D84B-4750-82C7-6A207C585CF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public MobileOnlineStatusResponseBodyResultObject ResultObject { get; set; }
        public class MobileOnlineStatusResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Verification result</para>
            /// <list type="bullet">
            /// <item><description>1: Available online </description></item>
            /// <item><description>2: Not available online (see subCode for details)</description></item>
            /// <item><description>3: No query result</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>ISP name</para>
            /// <list type="bullet">
            /// <item><description>CMCC: China Mobile </description></item>
            /// <item><description>CUCC: China Unicom </description></item>
            /// <item><description>CTCC: China Telecom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <para>Verification details</para>
            /// <list type="bullet">
            /// <item><description>101: Available online </description></item>
            /// <item><description>201: Suspended </description></item>
            /// <item><description>202: Disconnected </description></item>
            /// <item><description>203: Online but not available </description></item>
            /// <item><description>204: Not online </description></item>
            /// <item><description>301: No record found</description></item>
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
