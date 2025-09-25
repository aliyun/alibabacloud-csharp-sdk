// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 indicates success, other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Error message</para>
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
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF039795</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeFaceVerifyResponseBodyResultObject ResultObject { get; set; }
        public class DescribeFaceVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Device risk label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ROOT,VPN,HOOK</para>
            /// </summary>
            [NameInMap("DeviceRisk")]
            [Validation(Required=false)]
            public string DeviceRisk { get; set; }

            /// <summary>
            /// <para>Device token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>McozS1ZWRcRZStlERcZZo_QOytx5jcgZoZJEoRLOxxxxxxx</para>
            /// </summary>
            [NameInMap("DeviceToken")]
            [Validation(Required=false)]
            public string DeviceToken { get; set; }

            /// <summary>
            /// <para>Information about the authenticated subject, usually empty in general authentication scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("IdentityInfo")]
            [Validation(Required=false)]
            public string IdentityInfo { get; set; }

            /// <summary>
            /// <para>Attachment information of the authenticated subject, mainly image materials. JSON format, see example below.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;faceAttack&quot;: &quot;F&quot;,&quot;facialPictureFront&quot;: {&quot;qualityScore&quot;: 88.3615493774414,&quot;pictureUrl&quot;: &quot;<a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg%22,%22ossBucketName">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg&quot;,&quot;ossBucketName</a>&quot;: &quot;cn-shanghai-aliyun-cloudauth-1260051251634779&quot;,&quot;ossObjectName&quot;: &quot;verify/1260051251634779/6ba7bcfccf33f56cdb44ed086f36ce3e0.jpeg&quot;}}</para>
            /// </summary>
            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public string MaterialInfo { get; set; }

            /// <summary>
            /// <para>Whether it passed, T for pass, F for fail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>T</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>Description of the authentication result. For details, see the SubCode explanation below.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>Whether the response was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public string Success { get; set; }

            /// <summary>
            /// <para>Records the identity information and corresponding encoding entered by the user under the rare character mode. The returned data is a JSON formatted string, which will be an empty string if there are no rare characters in the name.</para>
            /// <list type="bullet">
            /// <item><description><para>name: Refers to the name entered by the user.</para>
            /// </description></item>
            /// <item><description><para>verifyName: Refers to the final name encoding after verification. For example, if a rare character is verified through transcoding: “Mr. Wang”, the actual verified name is “Wang Xiansheng”.</para>
            /// </description></item>
            /// <item><description><para>number: Refers to the identification number entered by the user.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;number&quot;: &quot;610***********1110&quot;,
            ///   &quot;name&quot;: &quot;王先生&quot;,
            ///   &quot;verifyName&quot;: &quot;王先&quot;
            /// }</para>
            /// </summary>
            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

        }

    }

}
