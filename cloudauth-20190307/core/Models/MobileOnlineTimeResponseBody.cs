// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileOnlineTimeResponseBody : TeaModel {
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
        public MobileOnlineTimeResponseBodyResultObject ResultObject { get; set; }
        public class MobileOnlineTimeResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Verification result code.</para>
            /// <list type="bullet">
            /// <item><description>1: Verification consistent</description></item>
            /// <item><description>2: Verification inconsistent</description></item>
            /// <item><description>3: No record found</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>Operator name</para>
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
            /// <list type="bullet">
            /// <item><description>1: [0,3) indicates the online duration is 0~3 months </description></item>
            /// <item><description>2: [3,6) indicates the online duration is 3~6 months </description></item>
            /// <item><description>3: [6,12) indicates the online duration is 6~12 months </description></item>
            /// <item><description>4: [12,24) indicates the online duration is 12~24 months </description></item>
            /// <item><description>5: [24,+) indicates the online duration is more than 24 months</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TimeCode")]
            [Validation(Required=false)]
            public string TimeCode { get; set; }

        }

    }

}
