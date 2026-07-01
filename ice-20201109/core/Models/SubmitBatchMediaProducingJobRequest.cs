// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitBatchMediaProducingJobRequest : TeaModel {
        /// <summary>
        /// <para>A client-side token used to ensure request idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The editing configuration. For the structure definition, see <a href="~~2692547#1be9bba03b7qu~~">EditingConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;MediaConfig&quot;: {
        ///       &quot;Volume&quot;: 0
        ///   },
        ///   &quot;SpeechConfig&quot;: {
        ///       &quot;Volume&quot;: 1
        ///   },
        ///  &quot;BackgroundMusicConfig&quot;: {
        ///       &quot;Volume&quot;: 0.3
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The input configuration. For the structure definition, see <a href="~~2692547#2faed1559549n~~">InputConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;MediaGroupArray&quot;: [{
        ///       &quot;GroupName&quot;: &quot;MediaGroup1&quot;,
        ///       &quot;MediaArray&quot;: [
        ///         &quot;<b><b>9d46c886b45481030f6e</b></b>&quot;,
        ///         &quot;<b><b>6c886b4549d481030f6e</b></b>&quot; ]
        ///     }, {
        ///       &quot;GroupName&quot;: &quot;MediaGroup2&quot;,
        ///       &quot;MediaArray&quot;: [
        ///         &quot;<b><b>d46c886810b454930f6e</b></b>&quot;,
        ///         &quot;<b><b>4549d886810b46c30f6e</b></b>&quot; ]
        ///   }],
        ///   &quot;TitleArray&quot;: [
        ///       &quot;回龙观盒马鲜生开业啦&quot;,
        ///       &quot;盒马鲜生开业啦&quot; ],
        ///   &quot;SpeechTextArray&quot;: [
        ///       &quot;附近的商场新开了一家盒马鲜生，今天是第一天开业&quot;
        ///       &quot;商场里的人不少，零食、酒水都比较便宜大家也快来看看呀&quot; ]
        /// }</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The output configuration. For the structure definition, see <a href="~~2692547#447b928fcbuoa~~">OutputConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;MediaURL&quot;: &quot;<a href="http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_%7Bindex%7D.mp4">http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_{index}.mp4</a>&quot;,
        ///   &quot;Count&quot;: 20,
        ///   &quot;MaxDuration&quot;: 15,
        ///   &quot;Width&quot;: 1080,
        ///   &quot;Height&quot;: 1920,
        ///   &quot;Video&quot;: {&quot;Crf&quot;: 27}
        /// }</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>The template parameters. You can configure multiple templates for one-click smart video creation. The system randomly selects one template to apply. For more information, see <a href="https://help.aliyun.com/zh/ims/use-cases/batch-video-production-public-parameters?spm=a2c4g.11186623.help-menu-193643.d_3_2_0_5.342860c5H30VVS%5C&scm=20140722.H_2877814._.OR_help-T_cn~zh-V_1#32c3bea6182sy">TemplateConfig parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<b><b>b4549d46c88681030f6e</b></b>&quot;,&quot;<b><b>549d46c88b4681030f6e</b></b>&quot;]</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>Custom business and callback configurations. For the structure definition, see <a href="~~357745#section-urj-v3f-0s1~~">UserData configuration</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;<a href="https://xx.xx.xxx%22%7D">https://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;ice-callback-demo&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
