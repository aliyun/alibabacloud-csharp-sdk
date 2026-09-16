// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class UpdateAntCloudAuthSceneRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to bind a mini program. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: enabled.</description></item>
        /// <item><description><b>N (default)</b>: disabled.<remarks>
        /// <para>Notice: If you enable mini program binding, make sure that you specify all parameters related to the mini program binding.</para>
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
        /// <para>The content of the uploaded verification file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>774c4aab45981ff4a86cde9255a11xxx</para>
        /// </summary>
        [NameInMap("CheckFileBody")]
        [Validation(Required=false)]
        public string CheckFileBody { get; set; }

        /// <summary>
        /// <para>The name of the uploaded verification file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.txt</para>
        /// </summary>
        [NameInMap("CheckFileName")]
        [Validation(Required=false)]
        public string CheckFileName { get; set; }

        /// <summary>
        /// <para>The iOS app scheme for degradation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudauth://callback</para>
        /// </summary>
        [NameInMap("DegradeAppScheme")]
        [Validation(Required=false)]
        public string DegradeAppScheme { get; set; }

        /// <summary>
        /// <para>The SubCode that triggers degradation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201,202</para>
        /// </summary>
        [NameInMap("DegradeSubCodes")]
        [Validation(Required=false)]
        public string DegradeSubCodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable degraded authentication.</para>
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
        /// <item><description><b>Y</b>: enabled.</description></item>
        /// <item><description><b>N</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("DeviceRiskPlus")]
        [Validation(Required=false)]
        public string DeviceRiskPlus { get; set; }

        /// <summary>
        /// <para>The name of the mini program.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestApp</para>
        /// </summary>
        [NameInMap("MiniProgramName")]
        [Validation(Required=false)]
        public string MiniProgramName { get; set; }

        /// <summary>
        /// <para>The mini program platform. Valid values:</para>
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
        /// <para>The number of returned photos (1 to 5). This parameter takes effect after StoreImage is enabled for authentication file retention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnPicCount")]
        [Validation(Required=false)]
        public long? ReturnPicCount { get; set; }

        /// <summary>
        /// <para>The duration of the returned video (1 to 2 seconds). This parameter takes effect after StoreImage is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReturnVideoLength")]
        [Validation(Required=false)]
        public long? ReturnVideoLength { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000013372</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>The scenario name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <para>This parameter has no effect. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver authentication files generated during the authentication process to your OSS bucket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: enabled.</description></item>
        /// <item><description><b>N (default)</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("StoreImage")]
        [Validation(Required=false)]
        public string StoreImage { get; set; }

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
