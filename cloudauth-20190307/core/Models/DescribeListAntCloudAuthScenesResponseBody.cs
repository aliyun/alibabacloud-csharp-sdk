// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeListAntCloudAuthScenesResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC1AB3F5-22A2-589F-ABDD-B766694AA671</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of scenarios.</para>
        /// </summary>
        [NameInMap("Scenes")]
        [Validation(Required=false)]
        public List<DescribeListAntCloudAuthScenesResponseBodyScenes> Scenes { get; set; }
        public class DescribeListAntCloudAuthScenesResponseBodyScenes : TeaModel {
            /// <summary>
            /// <para>Application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2a3a13b6-ee85-457e-bd15-b48115cb396e</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            /// <summary>
            /// <para>Whether to enable binding to a mini program:</para>
            /// <list type="bullet">
            /// <item><description><b>Y</b>: Enabled</description></item>
            /// <item><description><b>N (default)</b>: Not enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("BindMiniProgram")]
            [Validation(Required=false)]
            public string BindMiniProgram { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1260051251634779</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>189884094677xxxx</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("DeviceRiskPlus")]
            [Validation(Required=false)]
            public string DeviceRiskPlus { get; set; }

            /// <summary>
            /// <para>Bound domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.ddos.com">www.ddos.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Mini program name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试APP</para>
            /// </summary>
            [NameInMap("MiniProgramName")]
            [Validation(Required=false)]
            public string MiniProgramName { get; set; }

            /// <summary>
            /// <para>Modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>189884094677xxxx</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>Platform for binding the mini program:</para>
            /// <list type="bullet">
            /// <item><description><b>WECHAT</b>: WeChat</description></item>
            /// <item><description><b>ALIPAY</b>: Alipay</description></item>
            /// <item><description><b>TIKTOK</b>: TikTok</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WECHAT</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("ReturnPicCount")]
            [Validation(Required=false)]
            public long? ReturnPicCount { get; set; }

            [NameInMap("ReturnVideoLength")]
            [Validation(Required=false)]
            public long? ReturnVideoLength { get; set; }

            /// <summary>
            /// <para>Scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001xxxx</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// <para>Scenario name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试场景</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>Whether it is enabled, with 1 indicating yes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Whether to deliver the files generated by the authentication to the customer\&quot;s OSS:</para>
            /// <list type="bullet">
            /// <item><description><b>Y</b>: Enabled</description></item>
            /// <item><description><b>N</b>: Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("StoreImage")]
            [Validation(Required=false)]
            public string StoreImage { get; set; }

            /// <summary>
            /// <para>The last update time of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1260051251634779</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
