// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartCloudNoteRequest : TeaModel {
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
        public StartCloudNoteRequestAutoChapters AutoChapters { get; set; }
        public class StartCloudNoteRequestAutoChapters : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the feature.</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

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
        public StartCloudNoteRequestCustomPrompt CustomPrompt { get; set; }
        public class StartCloudNoteRequestCustomPrompt : TeaModel {
            /// <summary>
            /// <para>The list of parameters for the custom prompt.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CustomPromptContents")]
            [Validation(Required=false)]
            public List<StartCloudNoteRequestCustomPromptCustomPromptContents> CustomPromptContents { get; set; }
            public class StartCloudNoteRequestCustomPromptCustomPromptContents : TeaModel {
                /// <summary>
                /// <para>The model used for the prompt. Valid values: tingwu-turbo, tingwu-plus, and qwen-max. Default value: tingwu-turbo.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tingwu-turbo</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The custom name of the prompt, which is used to match the output results.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>split-summary-demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The custom content of the prompt. The content must include the {Transcription} tag. The {Transcription} tag is automatically replaced with the speech transcription result as the model input.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Summarize the following conversation by speaker:\n {Transcription}</para>
                /// </summary>
                [NameInMap("Prompt")]
                [Validation(Required=false)]
                public string Prompt { get; set; }

                /// <summary>
                /// <para>The format of the {Transcription} tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>chat: The transcription result includes speaker information.</description></item>
                /// <item><description>default: The transcription result is in plain text format.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>chat</para>
                /// </summary>
                [NameInMap("TransType")]
                [Validation(Required=false)]
                public string TransType { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the feature.</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

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
        public StartCloudNoteRequestMeetingAssistance MeetingAssistance { get; set; }
        public class StartCloudNoteRequestMeetingAssistance : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the feature.</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The algorithm type for the intelligent meeting minutes feature.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MeetingAssistanceType")]
            [Validation(Required=false)]
            public List<string> MeetingAssistanceType { get; set; }

        }

        /// <summary>
        /// <para>The real-time subtitles.</para>
        /// </summary>
        [NameInMap("RealtimeSubtitle")]
        [Validation(Required=false)]
        public StartCloudNoteRequestRealtimeSubtitle RealtimeSubtitle { get; set; }
        public class StartCloudNoteRequestRealtimeSubtitle : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable server-side callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AsrCallback")]
            [Validation(Required=false)]
            public bool? AsrCallback { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the feature.</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The translation parameters. You can specify the target translation language by using the SDK.</para>
            /// </summary>
            [NameInMap("Translation")]
            [Validation(Required=false)]
            public StartCloudNoteRequestRealtimeSubtitleTranslation Translation { get; set; }
            public class StartCloudNoteRequestRealtimeSubtitleTranslation : TeaModel {
                /// <summary>
                /// <para>The output level of the translated text. Default value: 2.</para>
                /// <list type="bullet">
                /// <item><description>1: Returns results when a complete sentence is recognized.</description></item>
                /// <item><description>2: Returns results when intermediate results and complete sentences are recognized.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TranslateLevel")]
                [Validation(Required=false)]
                public int? TranslateLevel { get; set; }

            }

        }

        /// <summary>
        /// <para>The service inspection feature.</para>
        /// </summary>
        [NameInMap("ServiceInspection")]
        [Validation(Required=false)]
        public StartCloudNoteRequestServiceInspection ServiceInspection { get; set; }
        public class StartCloudNoteRequestServiceInspection : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the feature.</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The list of inspection dimensions for service inspection, including the names and definitions of the dimensions. This specifies the criteria for the large language model to determine whether a dimension is hit.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("InspectionContents")]
            [Validation(Required=false)]
            public List<StartCloudNoteRequestServiceInspectionInspectionContents> InspectionContents { get; set; }
            public class StartCloudNoteRequestServiceInspectionInspectionContents : TeaModel {
                /// <summary>
                /// <para>The definition of the inspection dimension for service inspection.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The salesperson proactively greets and welcomes the customer during the opening remarks</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The name of the inspection dimension for service inspection.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Store arrival welcome - Welcome greeting</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The description of the inspection objectives and focus areas for service inspection.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Monitor whether the sales staff in the dialogue are enthusiastic and have a good attitude when receiving customers</para>
            /// </summary>
            [NameInMap("InspectionIntroduction")]
            [Validation(Required=false)]
            public string InspectionIntroduction { get; set; }

            /// <summary>
            /// <para>The description of the dialogue scene for service inspection.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Offline sales scenario at an automobile dealership</para>
            /// </summary>
            [NameInMap("SceneIntroduction")]
            [Validation(Required=false)]
            public string SceneIntroduction { get; set; }

        }

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
        public StartCloudNoteRequestStorageConfig StorageConfig { get; set; }
        public class StartCloudNoteRequestStorageConfig : TeaModel {
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
        public StartCloudNoteRequestSummarization Summarization { get; set; }
        public class StartCloudNoteRequestSummarization : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the feature.</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The specific type.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public List<string> Type { get; set; }

        }

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
        public StartCloudNoteRequestTextPolish TextPolish { get; set; }
        public class StartCloudNoteRequestTextPolish : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the feature.</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>The transcription feature. Enabled by default.</para>
        /// </summary>
        [NameInMap("Transcription")]
        [Validation(Required=false)]
        public StartCloudNoteRequestTranscription Transcription { get; set; }
        public class StartCloudNoteRequestTranscription : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable speaker diarization.</para>
            /// </summary>
            [NameInMap("DiarizationEnabled")]
            [Validation(Required=false)]
            public bool? DiarizationEnabled { get; set; }

            /// <summary>
            /// <para>The hotword table ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b27cb31b8ca24c5b8e664e0387bac573</para>
            /// </summary>
            [NameInMap("PhraseId")]
            [Validation(Required=false)]
            public string PhraseId { get; set; }

            /// <summary>
            /// <para>The number of speakers for speaker diarization. Default value: 0. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The number of speakers is unknown.</description></item>
            /// <item><description>2: The number of speakers is 2.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SpeakerCount")]
            [Validation(Required=false)]
            public int? SpeakerCount { get; set; }

            /// <summary>
            /// <para>The return level of speech recognition results. Default value: 2. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Returns recognition results when a complete sentence is recognized.</description></item>
            /// <item><description>2: Returns recognition results when intermediate results and complete sentences are recognized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TranscriptionLevel")]
            [Validation(Required=false)]
            public int? TranscriptionLevel { get; set; }

        }

    }

}
