// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeListAntCloudAuthScenesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC1AB3F5-22A2-589F-ABDD-B766694AA671</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of scenarios.</para>
        /// </summary>
        [NameInMap("Scenes")]
        [Validation(Required=false)]
        public List<DescribeListAntCloudAuthScenesResponseBodyScenes> Scenes { get; set; }
        public class DescribeListAntCloudAuthScenesResponseBodyScenes : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2a3a13b6-ee85-457e-bd15-b48115cb396e</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable mini program binding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Y</b>: Enabled.</description></item>
            /// <item><description><b>N (default)</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("BindMiniProgram")]
            [Validation(Required=false)]
            public string BindMiniProgram { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds (ms), such as 1740389697000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740389697000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>189884094677xxxx</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The iOS scheme for degradation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudauth://callback</para>
            /// </summary>
            [NameInMap("DegradeAppScheme")]
            [Validation(Required=false)]
            public string DegradeAppScheme { get; set; }

            /// <summary>
            /// <para>The list of SubCodes that trigger degradation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201,202</para>
            /// </summary>
            [NameInMap("DegradeSubCodes")]
            [Validation(Required=false)]
            public string DegradeSubCodes { get; set; }

            /// <summary>
            /// <para>The degraded authentication type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIPAY</para>
            /// </summary>
            [NameInMap("DegradeType")]
            [Validation(Required=false)]
            public string DegradeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable enhanced device risk detection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Y</b>: Enabled.</description></item>
            /// <item><description><b>N</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("DeviceRiskPlus")]
            [Validation(Required=false)]
            public string DeviceRiskPlus { get; set; }

            /// <summary>
            /// <para>The bound domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.ddos.com">www.ddos.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The mini program name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestApp</para>
            /// </summary>
            [NameInMap("MiniProgramName")]
            [Validation(Required=false)]
            public string MiniProgramName { get; set; }

            /// <summary>
            /// <para>The modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>189884094677xxxx</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The mini program platform. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WECHAT</b>: WeChat.</description></item>
            /// <item><description><b>ALIPAY</b>: Alipay.</description></item>
            /// <item><description><b>TIKTOK</b>: TikTok.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WECHAT</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The number of evidence face photos (1-5).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReturnPicCount")]
            [Validation(Required=false)]
            public long? ReturnPicCount { get; set; }

            /// <summary>
            /// <para>The evidence video duration in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReturnVideoLength")]
            [Validation(Required=false)]
            public long? ReturnVideoLength { get; set; }

            /// <summary>
            /// <para>The scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001xxxx</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// <para>The scenario name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestScenario</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>Indicates whether the scenario is enabled. The value is 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Specifies whether to deliver files generated during authentication to the customer\&quot;s OSS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Y</b>: Enabled.</description></item>
            /// <item><description><b>N</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("StoreImage")]
            [Validation(Required=false)]
            public string StoreImage { get; set; }

            /// <summary>
            /// <para>The last update time of the instance. The value is a UNIX timestamp in milliseconds (ms), such as 1740541510000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740541510000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable degraded authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("UseDegrade")]
            [Validation(Required=false)]
            public string UseDegrade { get; set; }

        }

    }

}
