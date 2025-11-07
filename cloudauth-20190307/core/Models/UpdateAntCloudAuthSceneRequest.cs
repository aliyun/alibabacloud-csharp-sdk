// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class UpdateAntCloudAuthSceneRequest : TeaModel {
        /// <summary>
        /// <para>Whether to enable binding to a mini program:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Enable</description></item>
        /// <item><description><b>N (default)</b>: Do not enable<remarks>
        /// <para>Notice: If enabling the binding of a mini program, please ensure all parameters for the mini program are passed.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("BindMiniProgram")]
        [Validation(Required=false)]
        public string BindMiniProgram { get; set; }

        /// <summary>
        /// <para>Content of the uploaded verification file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>774c4aab45981ff4a86cde9255a11xxx</para>
        /// </summary>
        [NameInMap("CheckFileBody")]
        [Validation(Required=false)]
        public string CheckFileBody { get; set; }

        /// <summary>
        /// <para>Name of the uploaded verification file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试.txt</para>
        /// </summary>
        [NameInMap("CheckFileName")]
        [Validation(Required=false)]
        public string CheckFileName { get; set; }

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
        /// <para>Binding mini program platform:</para>
        /// <list type="bullet">
        /// <item><description><b>WECHAT</b>: WeChat</description></item>
        /// <item><description><b>ALIPAY</b>: Alipay</description></item>
        /// <item><description><b>TIKTOK</b>: TikTok</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IOS</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>Scenario ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000013372</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>Scenario name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <para>Currently meaningless, can be omitted.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Whether to enable delivering the authentication files generated during the authentication process to the user\&quot;s OSS:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Enable</description></item>
        /// <item><description><b>N (default)</b>: Disable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("StoreImage")]
        [Validation(Required=false)]
        public string StoreImage { get; set; }

    }

}
