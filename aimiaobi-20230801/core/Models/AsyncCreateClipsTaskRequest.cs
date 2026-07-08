// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncCreateClipsTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AutoWrap：自动换行</para>
        /// <para>AutoScale：自动缩放</para>
        /// <para>AutoWrapAtSpaces：只在空格位置自动换行（适用于纯英文字幕自动换行场景）</para>
        /// </summary>
        [NameInMap("AdaptMode")]
        [Validation(Required=false)]
        public string AdaptMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>支持设置：</para>
        /// <para>TopLeft：视频左上角</para>
        /// <para>TopCenter：视频竖直中轴线上侧</para>
        /// <para>TopRight：视频右上角</para>
        /// <para>CenterLeft：视频水平中轴线左侧</para>
        /// <para>CenterCenter：视频中心位置</para>
        /// <para>CenterRight：视频水平中轴线右侧</para>
        /// <para>BottomLeft：视频左下角</para>
        /// <para>BottomCenter：视频竖直中轴线下侧</para>
        /// <para>BottomRight：视频右下角</para>
        /// <para>若需要在不同对齐方式下准确定位字幕位置，建议设置以下对齐方式：</para>
        /// <para>Left，左对齐，X、Y传入字幕左上角顶点相对于视频左上角的坐标</para>
        /// <para>Center，居中对齐，X、Y传入字幕中轴线上边界交点相对于视频左上角的坐标</para>
        /// <para>Right，右对齐，X、Y传入字幕右上角顶点相对于视频左上角的坐标</para>
        /// </summary>
        [NameInMap("Alignment")]
        [Validation(Required=false)]
        public string Alignment { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the background music.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CloseMusic")]
        [Validation(Required=false)]
        public bool? CloseMusic { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the subtitles.</para>
        /// </summary>
        [NameInMap("CloseSubtitle")]
        [Validation(Required=false)]
        public bool? CloseSubtitle { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the narration voice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CloseVoice")]
        [Validation(Required=false)]
        public bool? CloseVoice { get; set; }

        /// <summary>
        /// <para>The URL of the closing credits video.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxx/xxx.mp4">http://xxx/xxx.mp4</a></para>
        /// </summary>
        [NameInMap("ClosingCreditsUrl")]
        [Validation(Required=false)]
        public string ClosingCreditsUrl { get; set; }

        /// <summary>
        /// <para>The array of animated text elements.</para>
        /// </summary>
        [NameInMap("ColorWords")]
        [Validation(Required=false)]
        public List<AsyncCreateClipsTaskRequestColorWords> ColorWords { get; set; }
        public class AsyncCreateClipsTaskRequestColorWords : TeaModel {
            /// <summary>
            /// <para>The content of the animated text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>花字内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The style of the animated text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS0002-000007
            /// 参考：<a href="https://help.aliyun.com/zh/ims/developer-reference/flower-effect-example?spm=a2c4g.11186623.0.0.6ee43d29lo1EWu#88bc5f6046mg2">https://help.aliyun.com/zh/ims/developer-reference/flower-effect-example?spm=a2c4g.11186623.0.0.6ee43d29lo1EWu#88bc5f6046mg2</a></para>
            /// </summary>
            [NameInMap("EffectColorStyle")]
            [Validation(Required=false)]
            public string EffectColorStyle { get; set; }

            /// <summary>
            /// <para>The font size of the animated text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认120</para>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            /// <summary>
            /// <para>The start time of the animated text, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TimelineIn")]
            [Validation(Required=false)]
            public int? TimelineIn { get; set; }

            /// <summary>
            /// <para>The end time of the animated text, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TimelineOut")]
            [Validation(Required=false)]
            public int? TimelineOut { get; set; }

            /// <summary>
            /// <para>The X coordinate of the animated text position.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>The Y coordinate of the animated text position.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

        }

        /// <summary>
        /// <para>The AppKey of CosyVoice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddgsase</para>
        /// </summary>
        [NameInMap("CosyVoiceAppKey")]
        [Validation(Required=false)]
        public string CosyVoiceAppKey { get; set; }

        /// <summary>
        /// <para>The token of CosyVoice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxsfazs</para>
        /// </summary>
        [NameInMap("CosyVoiceToken")]
        [Validation(Required=false)]
        public string CosyVoiceToken { get; set; }

        /// <summary>
        /// <para>The voice tone of CosyVoice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>longxian_normal</para>
        /// </summary>
        [NameInMap("CustomVoiceStyle")]
        [Validation(Required=false)]
        public string CustomVoiceStyle { get; set; }

        /// <summary>
        /// <para>The URL of the custom audio track.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxx/xxx.mp4">http://xxx/xxx.mp4</a></para>
        /// </summary>
        [NameInMap("CustomVoiceUrl")]
        [Validation(Required=false)]
        public string CustomVoiceUrl { get; set; }

        /// <summary>
        /// <para>The volume of the custom audio track.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CustomVoiceVolume")]
        [Validation(Required=false)]
        public int? CustomVoiceVolume { get; set; }

        /// <summary>
        /// <para>The height of the video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>The list of high-definition video structures.</para>
        /// </summary>
        [NameInMap("HighDefSourceVideos")]
        [Validation(Required=false)]
        public List<AsyncCreateClipsTaskRequestHighDefSourceVideos> HighDefSourceVideos { get; set; }
        public class AsyncCreateClipsTaskRequestHighDefSourceVideos : TeaModel {
            /// <summary>
            /// <para>The ID of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00d59b6de13971f0bcd84531949c0102</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

            /// <summary>
            /// <para>The name of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>video001.mp4</para>
            /// </summary>
            [NameInMap("VideoName")]
            [Validation(Required=false)]
            public string VideoName { get; set; }

            /// <summary>
            /// <para>The URL of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://fotor-cn-cutout.oss-cn-shanghai.aliyuncs.com/cutout_tmp/01ba219486f043b4b339e7080e5cf11d.mp4">http://fotor-cn-cutout.oss-cn-shanghai.aliyuncs.com/cutout_tmp/01ba219486f043b4b339e7080e5cf11d.mp4</a></para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        /// <summary>
        /// <para>The type of recommended music.</para>
        /// 
        /// <b>Example:</b>
        /// <para>浪漫, 美食,国风,轻快,动感,舒缓,搞怪,时尚</para>
        /// </summary>
        [NameInMap("MusicStyle")]
        [Validation(Required=false)]
        public string MusicStyle { get; set; }

        /// <summary>
        /// <para>The URL of the background music.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://music.mp4">http://music.mp4</a></para>
        /// </summary>
        [NameInMap("MusicUrl")]
        [Validation(Required=false)]
        public string MusicUrl { get; set; }

        /// <summary>
        /// <para>The volume of the background music.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0-10，默认5</para>
        /// </summary>
        [NameInMap("MusicVolume")]
        [Validation(Required=false)]
        public int? MusicVolume { get; set; }

        /// <summary>
        /// <para>The URL of the opening credits video.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxx/xxx.mp4">http://xxx/xxx.mp4</a></para>
        /// </summary>
        [NameInMap("OpeningCreditsUrl")]
        [Validation(Required=false)]
        public string OpeningCreditsUrl { get; set; }

        /// <summary>
        /// <para>The array of sticker structures.</para>
        /// </summary>
        [NameInMap("Stickers")]
        [Validation(Required=false)]
        public List<AsyncCreateClipsTaskRequestStickers> Stickers { get; set; }
        public class AsyncCreateClipsTaskRequestStickers : TeaModel {
            /// <summary>
            /// <para>The display duration of the sticker, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The number of dynamic frames in the GIF file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("DyncFrames")]
            [Validation(Required=false)]
            public int? DyncFrames { get; set; }

            /// <summary>
            /// <para>The height of the sticker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <para>The start time of the sticker, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TimelineIn")]
            [Validation(Required=false)]
            public int? TimelineIn { get; set; }

            /// <summary>
            /// <para>The public URL of the GIF file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx/xxx.gif">http://xxx/xxx.gif</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The width of the sticker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

            /// <summary>
            /// <para>The X coordinate of the sticker position.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>The Y coordinate of the sticker position.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

        }

        /// <summary>
        /// <para>The font size of the subtitles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>默认120</para>
        /// </summary>
        [NameInMap("SubtitleFontSize")]
        [Validation(Required=false)]
        public int? SubtitleFontSize { get; set; }

        /// <summary>
        /// <para>The unique ID of the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17a299a9-f223-4707-b0dd-4c22519bddf5</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>将按照该值设置文本框宽度进行自动换行或缩放。不填写时，会按照视频宽度进行自动换行或缩放。当值大于0小于等于1时，表示相对输出视频的宽度，当值大于1时，表示绝对像素值。</para>
        /// </summary>
        [NameInMap("TextWidth")]
        [Validation(Required=false)]
        public string TextWidth { get; set; }

        /// <summary>
        /// <para>The type of narration voice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>甜美女声
        /// 中国台湾话女声
        /// 舌尖男声
        /// 新闻男声
        /// 激昂解说
        /// 标准女声
        /// 悬疑解说
        /// 广告男声
        /// 温柔女声
        /// 资讯女声
        /// 新闻女声
        /// 萝莉女声
        /// 磁性男声</para>
        /// </summary>
        [NameInMap("VoiceStyle")]
        [Validation(Required=false)]
        public string VoiceStyle { get; set; }

        /// <summary>
        /// <para>The volume of the narration voice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0-10，默认5</para>
        /// </summary>
        [NameInMap("VoiceVolume")]
        [Validation(Required=false)]
        public int? VoiceVolume { get; set; }

        /// <summary>
        /// <para>The width of the video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/2782167.html">Bailian workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-ipe7d81yq4sl5jmk</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
