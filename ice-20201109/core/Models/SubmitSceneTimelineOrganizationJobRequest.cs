// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSceneTimelineOrganizationJobRequest : TeaModel {
        /// <summary>
        /// <para>The editing configuration. Its structure depends on the value of JobType.</para>
        /// <list type="bullet">
        /// <item><description>When JobType is set to Smart_Mix_Timeline_Organize, see <a href="https://help.aliyun.com/zh/ims/use-cases/intelligent-graphic-matching-into-a-piece/?spm=a2c4g.11186623.help-menu-193643.d_3_2_0_1.7c3d6997qndkZj">Image-text matching</a>.</description></item>
        /// <item><description>When JobType is set to Screen_Media_Highlights_Timeline_Organize, see <a href="https://help.aliyun.com/zh/ims/use-cases/create-highlight-videos?spm=a2c4g.11186623.help-menu-193643.d_3_2_0_3.84b5661bIcQULE">Highlight mashup</a>.</description></item>
        /// </list>
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
        /// <para>The input configuration. Its structure and required fields depend on the value of JobType.</para>
        /// <list type="bullet">
        /// <item><description>When JobType is set to Smart_Mix_Timeline_Organize, see <a href="https://help.aliyun.com/zh/ims/use-cases/intelligent-graphic-matching-into-a-piece/?spm=a2c4g.11186623.help-menu-193643.d_3_2_0_1.7c3d6997qndkZj">Image-text matching</a>.</description></item>
        /// <item><description>When JobType is set to Screen_Media_Highlights_Timeline_Organize, see <a href="https://help.aliyun.com/zh/ims/use-cases/create-highlight-videos?spm=a2c4g.11186623.help-menu-193643.d_3_2_0_3.84b5661bIcQULE">Highlight mashup</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;BackgroundMusic&quot;: &quot;<b><b>75c3936f3a8743850f2da942</b></b>&quot;,
        ///     &quot;MediaArray&quot;: [
        ///         &quot;<a href="https://test-bucket.oss-cn-shanghai.aliyuncs.com/test.mp4">https://test-bucket.oss-cn-shanghai.aliyuncs.com/test.mp4</a>&quot;
        ///     ],
        ///     &quot;SpeechTextArray&quot;: [
        ///         &quot;A new Freshippo store just opened in the nearby mall. Today is the grand opening.&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The job type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Smart_Mix_Timeline_Organize: Image-text matching.</description></item>
        /// <item><description>Screen_Media_Highlights_Timeline_Organize: Highlight mashup.</description></item>
        /// </list>
        /// <para>Differences:</para>
        /// <list type="bullet">
        /// <item><description>Image-text matching: Arranges a timeline based on the results of matching a voiceover script to media assets. Ideal for bulk marketing videos and general-purpose montages.</description></item>
        /// <item><description>Highlight mashup: Arranges a timeline based on the results of highlight clip selection. Ideal for creating action-packed highlight reels from short-form dramas.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Smart_Mix_Timeline_Organize</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The media selection results from a previously run SubmitSceneMediaSelectionJob. You can retrieve this result by calling GetBatchMediaProducingJob.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;textMatchMediaOutputList&quot;: [{
        ///         &quot;textMatchMediaSentenceOutputList&quot;: [{
        ///                 &quot;duration&quot;: 3.366667,
        ///                 &quot;matchClipList&quot;: [{
        ///                     &quot;endTime&quot;: 11.16,
        ///                     &quot;mediaId&quot;: &quot;<b><b>a0900f5071efbf1ce7e6c66a</b></b>&quot;,
        ///                     &quot;startTime&quot;: 8.04
        ///                 }],
        ///                 &quot;text&quot;: &quot;A new Freshippo store just opened in the nearby mall&quot;
        ///             },
        ///             {
        ///                 &quot;duration&quot;: 1.566667,
        ///                 &quot;matchClipList&quot;: [{
        ///                     &quot;endTime&quot;: 1.54,
        ///                     &quot;mediaId&quot;: &quot;<b><b>a0900f5071efbf1ce7e6c66a</b></b>&quot;,
        ///                     &quot;startTime&quot;: 0
        ///                 }],
        ///                 &quot;text&quot;: &quot;Today is the grand opening&quot;
        ///             }
        ///         ]
        ///     }]
        /// }</para>
        /// </summary>
        [NameInMap("MediaSelectResult")]
        [Validation(Required=false)]
        public string MediaSelectResult { get; set; }

        /// <summary>
        /// <para>The output configuration. Its structure and required fields depend on the value of JobType.</para>
        /// <list type="bullet">
        /// <item><description>When JobType is set to Smart_Mix_Timeline_Organize, see <a href="https://help.aliyun.com/zh/ims/use-cases/intelligent-graphic-matching-into-a-piece/?spm=a2c4g.11186623.help-menu-193643.d_3_2_0_1.7c3d6997qndkZj">Image-text matching</a>.</description></item>
        /// <item><description>When JobType is set to Screen_Media_Highlights_Timeline_Organize, see <a href="https://help.aliyun.com/zh/ims/use-cases/create-highlight-videos?spm=a2c4g.11186623.help-menu-193643.d_3_2_0_3.84b5661bIcQULE">Highlight mashup</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;MediaURL&quot;: &quot;<a href="http://test-bucket.oss-cn-shanghai.aliyuncs.com/xxx_%7Bindex%7D.mp4">http://test-bucket.oss-cn-shanghai.aliyuncs.com/xxx_{index}.mp4</a>&quot;,
        ///   &quot;Count&quot;: 1,
        ///   &quot;Width&quot;: 1080,
        ///   &quot;Height&quot;: 1920
        /// }</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>The user-defined data, including the business and callback configurations. For more information, see <a href="~~357745#section-urj-v3f-0s1~~">UserData</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;<a href="https://xx.xx.xxx%22%7D">https://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;ice-callback-demo&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
