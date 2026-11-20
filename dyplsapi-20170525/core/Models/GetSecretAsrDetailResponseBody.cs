// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetSecretAsrDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The ASR details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bizDuration&quot;:10944,&quot;businessId&quot;:&quot;435ee78c7a019650@!FC100000074672458@!20200615225802&quot;,&quot;businessKey&quot;:&quot;JCGTncltuNaolegJ&quot;,&quot;code&quot;:&quot;21050000&quot;,&quot;msg&quot;:&quot;SUCCESS&quot;,&quot;requestId&quot;:&quot;8d2329d407a83447a83be441681f4872ac74nE&quot;,&quot;sentences&quot;:[{&quot;beginTime&quot;:1020,&quot;channelId&quot;:0,&quot;emotionValue&quot;:&quot;5.7&quot;,&quot;endTime&quot;:1770,&quot;silenceDuration&quot;:&quot;0&quot;,&quot;speechRate&quot;:&quot;80&quot;,&quot;text&quot;:&quot;喂&quot;}],&quot;success&quot;:true,&quot;type&quot;:&quot;asrResult&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSecretAsrDetailResponseBodyData Data { get; set; }
        public class GetSecretAsrDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total duration of the audio file that was recognized. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10944</para>
            /// </summary>
            [NameInMap("BizDuration")]
            [Validation(Required=false)]
            public long? BizDuration { get; set; }

            /// <summary>
            /// <para>The ID of the business process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>435ee78c7a******@!FC100000074******@!2020061522****</para>
            /// </summary>
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            /// <summary>
            /// <para>The business keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JCGTncltuNao****</para>
            /// </summary>
            [NameInMap("BusinessKey")]
            [Validation(Required=false)]
            public string BusinessKey { get; set; }

            /// <summary>
            /// <para>The status code. The status code 21050000 indicates that the request was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21050000</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8d2329d407a83447a83be441681f4872ac74nE</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The ASR result.</para>
            /// </summary>
            [NameInMap("Sentences")]
            [Validation(Required=false)]
            public List<GetSecretAsrDetailResponseBodyDataSentences> Sentences { get; set; }
            public class GetSecretAsrDetailResponseBodyDataSentences : TeaModel {
                /// <summary>
                /// <para>The start time offset of the sentence. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1020</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// <para>The ID of the audio track to which the sentence belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public int? ChannelId { get; set; }

                /// <summary>
                /// <para>The emotion value. Value range: 1 to 10. The higher the value, the stronger the emotion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("EmotionValue")]
                [Validation(Required=false)]
                public string EmotionValue { get; set; }

                /// <summary>
                /// <para>The end time offset of the sentence. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1770</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The silence duration between the current sentence and the previous sentence. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SilenceDuration")]
                [Validation(Required=false)]
                public long? SilenceDuration { get; set; }

                /// <summary>
                /// <para>The average speech rate of the sentence. Unit: number of words per minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public int? SpeechRate { get; set; }

                /// <summary>
                /// <para>The recognition result of the sentence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>您好</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asrResult</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
