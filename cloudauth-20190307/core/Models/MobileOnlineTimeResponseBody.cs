// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileOnlineTimeResponseBody : TeaModel {
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
        public MobileOnlineTimeResponseBodyResultObject ResultObject { get; set; }
        public class MobileOnlineTimeResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Consistent.</description></item>
            /// <item><description>2: Inconsistent.</description></item>
            /// <item><description>3: No record found.</description></item>
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
            /// <para>The network duration code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: [0,3) indicates a network duration of 0 to 3 months.</description></item>
            /// <item><description>2: [3,6) indicates a network duration of 3 to 6 months.</description></item>
            /// <item><description>3: [6,12) indicates a network duration of 6 to 12 months.</description></item>
            /// <item><description>4: [12,24) indicates a network duration of 12 to 24 months.</description></item>
            /// <item><description>5: [24,+) indicates a network duration of more than 24 months.</description></item>
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
