// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressVerifyV2IntlResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F971622-38C0-5F56-B2EC-315367979B4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The verification result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddressVerifyV2IntlResponseBodyResult Result { get; set; }
        public class AddressVerifyV2IntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Passed.</description></item>
            /// <item><description>2: Failed (the device is in a prohibited region). </description></item>
            /// <item><description>3: Unable to determine.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The verification details, which include:</para>
            /// <list type="bullet">
            /// <item><description>distanceRange: the location range.   </description></item>
            /// <item><description>ispName: the ISP name.     </description></item>
            /// <item><description>phoneStatus: the phone status. A value of 0 indicates abnormal. A value of 1 indicates Normal. Otherwise, the status is unknown.</description></item>
            /// </list>
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
            /// <para>The authentication ID.</para>
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
