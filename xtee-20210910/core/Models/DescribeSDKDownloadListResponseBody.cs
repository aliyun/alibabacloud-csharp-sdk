// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSDKDownloadListResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSDKDownloadListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSDKDownloadListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Description information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Developer</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云安全-风险识别</para>
            /// </summary>
            [NameInMap("developer")]
            [Validation(Required=false)]
            public string Developer { get; set; }

            /// <summary>
            /// <para>Device type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANDROID</para>
            /// </summary>
            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>Download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aliyun-xxxx.oss-cn-xxx.xxx.com/sdk/xxx/10056.1/Android-AliyunDeviceEnhance-10056.1-20250611.tgz">https://aliyun-xxxx.oss-cn-xxx.xxx.com/sdk/xxx/10056.1/Android-AliyunDeviceEnhance-10056.1-20250611.tgz</a></para>
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>File MD5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>E582EEB6B4BC9B5CB168AA5A7DD0EE93</para>
            /// </summary>
            [NameInMap("md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>Package name</para>
            /// 
            /// <b>Example:</b>
            /// <para>net.security.device</para>
            /// </summary>
            [NameInMap("packageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// <para>Risk recognition SDK privacy policy link</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://terms.aliyun.com/legal-agreement/terms/suit_bu1_ali_cloud/suit_bu1_ali_cloud202111120818_92724.html">https://terms.aliyun.com/legal-agreement/terms/suit_bu1_ali_cloud/suit_bu1_ali_cloud202111120818_92724.html</a></para>
            /// </summary>
            [NameInMap("privacyLink")]
            [Validation(Required=false)]
            public string PrivacyLink { get; set; }

            /// <summary>
            /// <para>Release time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751212800000</para>
            /// </summary>
            [NameInMap("pushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            /// <summary>
            /// <para>SDK version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            /// <summary>
            /// <para>Size</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.12 MB</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

    }

}
