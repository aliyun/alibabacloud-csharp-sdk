// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberOnlineTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OK</b>: The request was successful.</description></item>
        /// <item><description><b>PortabilityNumberNotSupported</b>: The mobile number portability number is not supported.</description></item>
        /// <item><description><b>RequestFrequencyLimit</b>: Due to carrier restrictions, frequent repeated queries on the same number within a short period are prohibited. If this error code is returned, try again later.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Charges are incurred when Code is OK and VerifyResult is not -1. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html">Cell Phone Number Service Pricing</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePhoneNumberOnlineTimeResponseBodyData Data { get; set; }
        public class DescribePhoneNumberOnlineTimeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The carrier SMS status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CMCC</b>: China Mobile</description></item>
            /// <item><description><b>CUCC</b>: China Unicom</description></item>
            /// <item><description><b>CTCC</b>: China Telecom</description></item>
            /// <item><description><b>CBN</b>: China Broadnet</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("CarrierCode")]
            [Validation(Required=false)]
            public string CarrierCode { get; set; }

            /// <summary>
            /// <para>The enumeration value of the network registration duration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: No duration was found.</description></item>
            /// <item><description><b>0</b>: Abnormal phone status, for example, a non-existent number.</description></item>
            /// <item><description><b>1</b>: [0-3) months.</description></item>
            /// <item><description><b>2</b>: [3-6) months.</description></item>
            /// <item><description><b>3</b>: [6-12) months.</description></item>
            /// <item><description><b>4</b>: [12-24) months.</description></item>
            /// <item><description><b>5</b>: [24,+∞) months.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        /// <summary>
        /// <para>The description of the number status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
