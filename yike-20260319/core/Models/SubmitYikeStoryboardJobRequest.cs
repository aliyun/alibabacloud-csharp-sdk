// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitYikeStoryboardJobRequest : TeaModel {
        /// <summary>
        /// <para>The aspect ratio of the output video. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>16:9</description></item>
        /// <item><description>9:16</description></item>
        /// <item><description>4:3</description></item>
        /// <item><description>3:4</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4:3</para>
        /// </summary>
        [NameInMap("AspectRatio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// <para>The execution mode for storyboard generation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FullPipeline: full pipeline generation, which includes storyboard generation and shot video generation.</description></item>
        /// <item><description>StoryboardOnly: generates only the storyboard.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullPipeline</para>
        /// </summary>
        [NameInMap("ExecMode")]
        [Validation(Required=false)]
        public string ExecMode { get; set; }

        /// <summary>
        /// <para>The OSS URL of the file. The URL must point to a file with a .txt or .doc extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://test.oss-cn-shanghai.aliyuncs.com/test.txt">http://test.oss-cn-shanghai.aliyuncs.com/test.txt</a></para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the original dialogue during final video composition. Default value: True.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("KeepOriginDialogue")]
        [Validation(Required=false)]
        public bool? KeepOriginDialogue { get; set; }

        /// <summary>
        /// <para>The model parameters in JSON format.</para>
        /// <para>&quot;AudioEnable&quot;: false disables audio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;AudioEnable&quot;: false
        /// }</para>
        /// </summary>
        [NameInMap("ModelParams")]
        [Validation(Required=false)]
        public string ModelParams { get; set; }

        /// <summary>
        /// <para>The narration voice ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sys_GracefulPoisedWoman: mature graceful female</description></item>
        /// <item><description>sys_ElderlyWistfulWoman: wistful elderly female</description></item>
        /// <item><description>sys_SweetBrightGirl: sweet bright girl</description></item>
        /// <item><description>sys_YoungGracefulWoman: gentle graceful female</description></item>
        /// <item><description>sys_MaturePoisedWoman: poised mature female</description></item>
        /// <item><description>sys_MatureWiseWoman: elegant wise female</description></item>
        /// <item><description>sys_CalmDeepMale: calm deep male</description></item>
        /// <item><description>sys_SereneIntellect: serene intellectual male</description></item>
        /// <item><description>sys_MajesticBaritone: majestic baritone male</description></item>
        /// <item><description>sys_GravellySoulful: gravelly soulful male</description></item>
        /// <item><description>sys_ClassicYoungMan: classic narrator male</description></item>
        /// <item><description>sys_WiseYoungMan: wise narrator male</description></item>
        /// <item><description>sys_ClassicYoungWoman: classic narrator female</description></item>
        /// <item><description>sys_IntellectualYoungWoman: intellectual narrator female</description></item>
        /// <item><description>sys_GentleYoungMan: gentle narrator male</description></item>
        /// <item><description>sys_thoughtfulBoy: thoughtful boy</description></item>
        /// <item><description>sys_RichBassMale: rich bass male</description></item>
        /// <item><description>sys_ClassicMiddleAgedWoman: classic middle-aged narrator female</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sys_YoungGracefulWoman</para>
        /// </summary>
        [NameInMap("NarrationVoiceId")]
        [Validation(Required=false)]
        public string NarrationVoiceId { get; set; }

        [NameInMap("NeedCaption")]
        [Validation(Required=false)]
        public bool? NeedCaption { get; set; }

        /// <summary>
        /// <para>The resolution of the output video. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>720P</description></item>
        /// <item><description>1080P</description></item>
        /// <item><description>2K</description></item>
        /// <item><description>4K</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>720P</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        [NameInMap("ShotPromptLang")]
        [Validation(Required=false)]
        public string ShotPromptLang { get; set; }

        /// <summary>
        /// <para>The storyboard shot generation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>multi: multi-reference video generation</description></item>
        /// <item><description>default: image-to-video generation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>multi</para>
        /// </summary>
        [NameInMap("ShotPromptMode")]
        [Validation(Required=false)]
        public string ShotPromptMode { get; set; }

        /// <summary>
        /// <para>The shot split mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>firstPersonNarration: narration commentary mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>firstPersonNarration</para>
        /// </summary>
        [NameInMap("ShotSplitMode")]
        [Validation(Required=false)]
        public string ShotSplitMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip failed shots. Default value: True.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("SkipFailureShot")]
        [Validation(Required=false)]
        public bool? SkipFailureShot { get; set; }

        /// <summary>
        /// <para>The type of the material source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Novel: novel</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Novel</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The storyboard style ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RealisticPhotographyPro: realistic photography Pro</description></item>
        /// <item><description>RealisticGuzhuangPro: realistic ancient costume Pro</description></item>
        /// <item><description>RealisticXianxiaPro: realistic Xianxia Pro</description></item>
        /// <item><description>RealisticWesternPro: Western realistic Pro</description></item>
        /// <item><description>RealisticPhotography: realistic photography</description></item>
        /// <item><description>RealisticGuzhuang: realistic ancient costume</description></item>
        /// <item><description>RealisticXianxia: realistic Xianxia</description></item>
        /// <item><description>RealisticWasteland: realistic wasteland</description></item>
        /// <item><description>RealisticEra: realistic vintage</description></item>
        /// <item><description>GuofengAnime: 2D Chinese-style anime</description></item>
        /// <item><description>GuofengAnime3D: 3D Chinese-style anime</description></item>
        /// <item><description>AncientRomanceAnime: anime ancient romance</description></item>
        /// <item><description>PostApocalypticAnime: anime post-apocalyptic</description></item>
        /// <item><description>Cartoon3D: 3D cartoon</description></item>
        /// <item><description>Photorealistic3D: photorealistic 3D rendering</description></item>
        /// <item><description>SciFiRealism: sci-fi realism</description></item>
        /// <item><description>Chibi3D: 3D chibi</description></item>
        /// <item><description>ShojoManga: Japanese manga</description></item>
        /// <item><description>NewPeriodAnime: new era Japanese anime</description></item>
        /// <item><description>FairyTale2D: 2D fairy tale</description></item>
        /// <item><description>Wasteland2D: 2D wasteland</description></item>
        /// <item><description>InkWuxia: ink wash Wuxia</description></item>
        /// <item><description>ShadiaoMeme: panda head meme style</description></item>
        /// <item><description>Chibi2D: 2D chibi</description></item>
        /// <item><description>Ghibli: Ghibli</description></item>
        /// <item><description>SciFiComic: cyberpunk</description></item>
        /// <item><description>AmericanSuperhero: American superhero</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RealisticPhotography</para>
        /// </summary>
        [NameInMap("StyleId")]
        [Validation(Required=false)]
        public string StyleId { get; set; }

        /// <summary>
        /// <para>The task title. If not specified, a default title is automatically generated based on the date. The title cannot exceed 128 bytes in length and must be UTF-8 encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom settings in JSON format. Fields include:</para>
        /// <list type="bullet">
        /// <item><description>NotifyAddress: the callback URL for task completion. MNS callbacks and HTTP callbacks are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;NotifyAddress&quot;: &quot;<a href="https://www.callback.com">https://www.callback.com</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The video model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>wan2.6-r2v-flash</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wan2.6-r2v-flash</para>
        /// </summary>
        [NameInMap("VideoModel")]
        [Validation(Required=false)]
        public string VideoModel { get; set; }

    }

}
