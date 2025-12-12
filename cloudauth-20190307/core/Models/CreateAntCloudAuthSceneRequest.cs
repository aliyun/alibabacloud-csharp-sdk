// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateAntCloudAuthSceneRequest : TeaModel {
        /// <summary>
        /// <para>Whether to enable binding of the mini program:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Enable</description></item>
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
        /// <para>Binding platform for the mini program:</para>
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
        /// <para>Scene name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试场景</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <para>Whether to deliver the files generated from the authentication to the customer\&quot;s OSS:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Yes</description></item>
        /// <item><description><b>N</b>: No</description></item>
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
