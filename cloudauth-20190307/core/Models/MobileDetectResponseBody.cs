// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileDetectResponseBody : TeaModel {
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
        /// <para>969434DF-926B-4997-9881-4DE94E39F805</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public MobileDetectResponseBodyResultObject ResultObject { get; set; }
        public class MobileDetectResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Billing count, the total billing count in one request</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ChargeCount")]
            [Validation(Required=false)]
            public string ChargeCount { get; set; }

            /// <summary>
            /// <para>Verification results set</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<MobileDetectResponseBodyResultObjectItems> Items { get; set; }
            public class MobileDetectResponseBodyResultObjectItems : TeaModel {
                /// <summary>
                /// <para>Phone number\&quot;s area (only for plaintext phone numbers)</para>
                /// 
                /// <b>Example:</b>
                /// <para>安徽-马**</para>
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// <para>Verification result</para>
                /// <list type="bullet">
                /// <item><description>1: Available online </description></item>
                /// <item><description>2: Not available online</description></item>
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
                /// <para>Phone number</para>
                /// 
                /// <b>Example:</b>
                /// <para>131********</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>Verification details</para>
                /// <list type="bullet">
                /// <item><description>101: Available number</description></item>
                /// <item><description>102: Empty number</description></item>
                /// <item><description>103: Suspended </description></item>
                /// <item><description>104: Silent number (inactive small number, new number, non-smartphone user within the last six months) </description></item>
                /// <item><description>105: Risky number (long-term shutdown or no voice service activated and prone to complaints)</description></item>
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

}
