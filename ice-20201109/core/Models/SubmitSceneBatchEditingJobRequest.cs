// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSceneBatchEditingJobRequest : TeaModel {
        /// <summary>
        /// <para>The output configuration. The structure is the same as the <a href="https://help.aliyun.com/zh/ims/use-cases/create-highlight-videos?spm=a2c4g.11186623.help-menu-193643.d_3_2_0_3.3af86997GreVu9%5C&scm=20140722.H_2863940._.OR_help-T_cn~zh-V_1#4111a373d0xbz">OutputConfig</a> for batch video generation, except that Count and GeneratePreviewOnly are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;MediaURL&quot;: &quot;<a href="http://test-bucket.oss-cn-shanghai.aliyuncs.com/xxx_%7Bindex%7D.mp4">http://test-bucket.oss-cn-shanghai.aliyuncs.com/xxx_{index}.mp4</a>&quot;,
        ///   &quot;Width&quot;: 1080,
        ///   &quot;Height&quot;: 1920
        /// }</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>A comma-separated list of editing project IDs. The video is rendered based on the timeline from each project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****ae91539d46bb9000f74b40b80dd2,****ae91539000f74b40b80dd9d46bb</para>
        /// </summary>
        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public string ProjectIds { get; set; }

        /// <summary>
        /// <para>Custom user data, including callback configurations. For more information, see <a href="~~357745#section-urj-v3f-0s1~~">UserData</a>.</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
