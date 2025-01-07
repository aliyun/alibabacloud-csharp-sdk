// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the installation commands.</para>
        /// </summary>
        [NameInMap("InstallCodes")]
        [Validation(Required=false)]
        public List<DescribeInstallCodesResponseBodyInstallCodes> InstallCodes { get; set; }
        public class DescribeInstallCodesResponseBodyInstallCodes : TeaModel {
            /// <summary>
            /// <para>The verification code for you to manually install the Security Center agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15v02r</para>
            /// </summary>
            [NameInMap("CaptchaCode")]
            [Validation(Required=false)]
            public string CaptchaCode { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the commands used to install the Security Center agent expire. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637810007000</para>
            /// </summary>
            [NameInMap("ExpiredDate")]
            [Validation(Required=false)]
            public long? ExpiredDate { get; set; }

            /// <summary>
            /// <para>The ID of the server group to which the server belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9165712</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The name of the server group to which the server belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Indicates whether an image is used to install the Security Center agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OnlyImage")]
            [Validation(Required=false)]
            public bool? OnlyImage { get; set; }

            /// <summary>
            /// <para>The operating system of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>linux</b></description></item>
            /// <item><description><b>windows</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The ID of the PrivateLink endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PrivateLinkEndpointId")]
            [Validation(Required=false)]
            public long? PrivateLinkEndpointId { get; set; }

            /// <summary>
            /// <para>The name of the proxy cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proxy_test</para>
            /// </summary>
            [NameInMap("ProxyCluster")]
            [Validation(Required=false)]
            public string ProxyCluster { get; set; }

            /// <summary>
            /// <para>The name of the server provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0D6119F-92EE-1276-B8B6-C81A7F9D57F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
