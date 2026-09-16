// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateAntCloudAuthSceneRequest : TeaModel {
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
        /// <para>The iOS app scheme for degradation redirect.</para>
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
        /// <para>The degradation verification type.</para>
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
        /// <para>The mini program name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestApp</para>
        /// </summary>
        [NameInMap("MiniProgramName")]
        [Validation(Required=false)]
        public string MiniProgramName { get; set; }

        /// <summary>
        /// <para>The mini program platform to bind. Valid values:</para>
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
        /// <para>The number of face photos for evidence storage (1-5).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnPicCount")]
        [Validation(Required=false)]
        public long? ReturnPicCount { get; set; }

        /// <summary>
        /// <para>The duration of the evidence storage video, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnVideoLength")]
        [Validation(Required=false)]
        public long? ReturnVideoLength { get; set; }

        /// <summary>
        /// <para>The scenario name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestScenario</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver files generated during verification to the customer\&quot;s OSS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Yes.</description></item>
        /// <item><description><b>N</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("StoreImage")]
        [Validation(Required=false)]
        public string StoreImage { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable degradation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("UseDegrade")]
        [Validation(Required=false)]
        public string UseDegrade { get; set; }

    }

}
