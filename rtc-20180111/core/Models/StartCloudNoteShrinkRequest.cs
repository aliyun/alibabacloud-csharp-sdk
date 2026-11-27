// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartCloudNoteShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ws***z3</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The auto chapters feature. When enabled, chapter titles and summaries are generated.</para>
        /// </summary>
        [NameInMap("AutoChapters")]
        [Validation(Required=false)]
        public string AutoChaptersShrink { get; set; }

        /// <summary>
        /// <para>The channel ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The custom prompt control parameter object.</para>
        /// </summary>
        [NameInMap("CustomPrompt")]
        [Validation(Required=false)]
        public string CustomPromptShrink { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. You do not need to specify it.</para>
        /// </summary>
        [NameInMap("LanguageHints")]
        [Validation(Required=false)]
        public List<string> LanguageHints { get; set; }

        /// <summary>
        /// <para>The intelligent meeting minutes feature. When enabled, keywords, key content, and to-do items are generated.</para>
        /// </summary>
        [NameInMap("MeetingAssistance")]
        [Validation(Required=false)]
        public string MeetingAssistanceShrink { get; set; }

        /// <summary>
        /// <para>The real-time subtitles.</para>
        /// </summary>
        [NameInMap("RealtimeSubtitle")]
        [Validation(Required=false)]
        public string RealtimeSubtitleShrink { get; set; }

        /// <summary>
        /// <para>The service inspection feature.</para>
        /// </summary>
        [NameInMap("ServiceInspection")]
        [Validation(Required=false)]
        public string ServiceInspectionShrink { get; set; }

        /// <summary>
        /// <para>The source language model used by the channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn: Chinese</description></item>
        /// <item><description>yue: Cantonese</description></item>
        /// <item><description>en: English</description></item>
        /// <item><description>multilingual: Multilingual</description></item>
        /// <item><description>ja: Japanese</description></item>
        /// <item><description>ko: Korean</description></item>
        /// <item><description>de: German</description></item>
        /// <item><description>fr: French</description></item>
        /// <item><description>ru: Russian</description></item>
        /// <item><description>es: Spanish</description></item>
        /// <item><description>vi: Vietnamese</description></item>
        /// <item><description>it: Italian</description></item>
        /// <item><description>sv: Swedish</description></item>
        /// <item><description>cs: Czech</description></item>
        /// <item><description>pl: Polish</description></item>
        /// <item><description>th: Thai</description></item>
        /// <item><description>fi: Finnish</description></item>
        /// <item><description>hi: Hindi</description></item>
        /// <item><description>id: Indonesian</description></item>
        /// <item><description>pt: Portuguese</description></item>
        /// <item><description>ar: Arabic</description></item>
        /// <item><description>fil: Filipino</description></item>
        /// <item><description>ms: Malay</description></item>
        /// <item><description>tr: Turkish</description></item>
        /// <item><description>hu: Hungarian</description></item>
        /// <item><description>lo: Lao</description></item>
        /// <item><description>pt-br: Portuguese (Brazil)</description></item>
        /// <item><description>es-ar: Spanish (Argentina)</description></item>
        /// <item><description>es-mx: Spanish (Mexico)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The storage configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StorageConfig")]
        [Validation(Required=false)]
        public StartCloudNoteShrinkRequestStorageConfig StorageConfig { get; set; }
        public class StartCloudNoteShrinkRequestStorageConfig : TeaModel {
            /// <summary>
            /// <para>The AccessKey.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAX***</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The bucket name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-bucket-for-recording</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The storage region.</para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Region</th>
            /// <th>AliYun OSS</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>0</td>
            /// <td>CN_Hangzhou</td>
            /// </tr>
            /// <tr>
            /// <td>1</td>
            /// <td>CN_Shanghai</td>
            /// </tr>
            /// <tr>
            /// <td>2</td>
            /// <td>CN_Qingdao</td>
            /// </tr>
            /// <tr>
            /// <td>3</td>
            /// <td>CN_Beijing</td>
            /// </tr>
            /// <tr>
            /// <td>4</td>
            /// <td>CN_Zhangjiakou</td>
            /// </tr>
            /// <tr>
            /// <td>5</td>
            /// <td>CN_Huhehaote</td>
            /// </tr>
            /// <tr>
            /// <td>6</td>
            /// <td>CN_Shenzhen</td>
            /// </tr>
            /// <tr>
            /// <td>7</td>
            /// <td>CN_Hongkong</td>
            /// </tr>
            /// <tr>
            /// <td>8</td>
            /// <td>US_West_1</td>
            /// </tr>
            /// <tr>
            /// <td>9</td>
            /// <td>US_East_1</td>
            /// </tr>
            /// <tr>
            /// <td>10</td>
            /// <td>AP_Southeast_1</td>
            /// </tr>
            /// <tr>
            /// <td>11</td>
            /// <td>AP_Southeast_2</td>
            /// </tr>
            /// <tr>
            /// <td>12</td>
            /// <td>AP_Southeast_3</td>
            /// </tr>
            /// <tr>
            /// <td>13</td>
            /// <td>AP_Southeast_5</td>
            /// </tr>
            /// <tr>
            /// <td>14</td>
            /// <td>AP_Northeast_1</td>
            /// </tr>
            /// <tr>
            /// <td>15</td>
            /// <td>AP_South_1 (Offline. Do not use.)</td>
            /// </tr>
            /// <tr>
            /// <td>16</td>
            /// <td>EU_Central_1</td>
            /// </tr>
            /// <tr>
            /// <td>17</td>
            /// <td>EU_West_1</td>
            /// </tr>
            /// <tr>
            /// <td>18</td>
            /// <td>EU_East_1(ME_East_1)</td>
            /// </tr>
            /// <tr>
            /// <td>19</td>
            /// <td>AP_Southeast_6</td>
            /// </tr>
            /// <tr>
            /// <td>20</td>
            /// <td>CN_Heyuan</td>
            /// </tr>
            /// <tr>
            /// <td>21</td>
            /// <td>CN_Guangzhou</td>
            /// </tr>
            /// <tr>
            /// <td>22</td>
            /// <td>CN_Chengdu</td>
            /// </tr>
            /// <tr>
            /// <td>23</td>
            /// <td>CN_Nanjing</td>
            /// </tr>
            /// <tr>
            /// <td>24</td>
            /// <td>CN_Fuzhou</td>
            /// </tr>
            /// <tr>
            /// <td>25</td>
            /// <td>CN_Wulanchabu</td>
            /// </tr>
            /// <tr>
            /// <td>26</td>
            /// <td>AP_Northeast_2</td>
            /// </tr>
            /// <tr>
            /// <td>27</td>
            /// <td>AP_Southeast_7</td>
            /// </tr>
            /// </tbody></table>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public int? Region { get; set; }

            /// <summary>
            /// <para>The AccessKey secret.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APb6qWYEzKtYxE***</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The storage platform. Valid values:</para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>vendor</th>
            /// <th>Object storage service</th>
            /// <th>Remarks</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>1</td>
            /// <td>AliYun OSS</td>
            /// <td>Alibaba Cloud</td>
            /// </tr>
            /// </tbody></table>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>The summarization feature. When enabled, full-text summaries and speaker summaries are generated.</para>
        /// </summary>
        [NameInMap("Summarization")]
        [Validation(Required=false)]
        public string SummarizationShrink { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtc</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The text polishing feature.</para>
        /// </summary>
        [NameInMap("TextPolish")]
        [Validation(Required=false)]
        public string TextPolishShrink { get; set; }

        /// <summary>
        /// <para>The transcription feature. Enabled by default.</para>
        /// </summary>
        [NameInMap("Transcription")]
        [Validation(Required=false)]
        public string TranscriptionShrink { get; set; }

    }

}
