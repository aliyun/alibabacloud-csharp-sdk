// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitBatchMediaProducingJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotency of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The editing configuration. For the specific structure definition, see <a href="~~2692547#1be9bba03b7qu~~">EditingConfig</a>.</para>
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
        /// <para>The input configuration. For the specific structure definition, see <a href="~~2692547#2faed1559549n~~">InputConfig</a>.</para>
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
        ///       &quot;Hema Fresh grand opening in Huilongguan&quot;,
        ///       &quot;Hema Fresh grand opening&quot; ],
        ///   &quot;SpeechTextArray&quot;: [
        ///       &quot;A new Hema Fresh store just opened in the nearby mall, today is the first day of business&quot;
        ///       &quot;There are quite a few people in the mall, snacks and beverages are relatively cheap, come check it out&quot; ]
        /// }</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The output configuration. For the specific structure definition, see <a href="~~2692547#447b928fcbuoa~~">OutputConfig</a>.</para>
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
        /// <para>The template parameters. You can configure multiple one-click video production templates, and one is randomly selected and applied. For details, see <a href="https://www.alibabacloud.com/help/en/ims/use-cases/batch-video-production-public-parameters#32c3bea6182sy">TemplateConfig metric description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<b><b>b4549d46c88681030f6e</b></b>&quot;,&quot;<b><b>549d46c88b4681030f6e</b></b>&quot;]</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The user business configuration and callback configuration. For the specific structure definition, see <a href="~~357745#section-urj-v3f-0s1~~">UserData configuration</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;<a href="https://xx.xx.xxx%22%7D">https://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;ice-callback-demo&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
