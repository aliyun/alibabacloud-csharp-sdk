// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressVerifyV2IntlResponseBody : TeaModel {
        /// <summary>
        /// <para><a href="https://www.alibabacloud.com/help/zh/ekyc/latest/add-verify-pro-api?spm=a2c63.p38356.0.i4#ae60001a3804w">Return Code</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Detailed description of the return code</para>
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
        /// <para>7F971622-38C0-5F56-B2EC-315367979B4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result object</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddressVerifyV2IntlResponseBodyResult Result { get; set; }
        public class AddressVerifyV2IntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Passed (billed)</description></item>
            /// <item><description><b>2</b>: Failed (The device is in a prohibited region) (billed)</description></item>
            /// <item><description><b>3</b>: Unknown (billed)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>Verification details, including：</para>
            /// <list type="bullet">
            /// <item><description><para><b>DistanceRange</b>：Position rang：<a href="https://www.alibabacloud.com/help/zh/ekyc/latest/add-verify-pro-api?spm=a2c63.p38356.0.i27#ee274c08976er">DistanceRange description</a>。</para>
            /// <remarks>
            /// <para>If the input phone number or address is empty, or if no carrier information is found, this field will not be returned.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><b>IspName</b>: The carrier name:</para>
            /// <list type="bullet">
            /// <item><description><b>CMCC</b>: China Mobile</description></item>
            /// <item><description><b>CTCC</b>: China Telecom</description></item>
            /// <item><description><b>CUCC</b>: China Unicom<remarks>
            /// <para>This parameter is not returned if the mobile phone number or address is empty in the request, or if carrier information is not found.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>PhoneStatus</b>: The status of the mobile phone:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Abnormal</description></item>
            /// <item><description><b>1</b>: Normal</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is not returned if the mobile phone number is empty in the request.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;distanceRange&quot;: &quot;0-3000&quot;,
            ///   &quot;ispName&quot;: &quot;CTCC&quot;,
            ///   &quot;phoneStatus&quot;: &quot;1&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The transaction ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>hksb7ba1b28130d24e015d69********</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
