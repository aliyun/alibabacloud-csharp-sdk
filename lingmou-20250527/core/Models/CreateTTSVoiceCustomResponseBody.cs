// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class CreateTTSVoiceCustomResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateTTSVoiceCustomResponseBodyData Data { get; set; }
        public class CreateTTSVoiceCustomResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx-aliyuncs.com/material/INPUT_TRAIN_AUDIO/Mt.CQEG75L4FWIU2/TestTTSVoiceName.mp3?Expires=1764262805&OSSAccessKeyId=LTAI5tK3WcKwKtAyaT******&Signature=D%2Fld6gp9Zh6TsGRU9cd6GD2pFY0%3D">https://xxx-aliyuncs.com/material/INPUT_TRAIN_AUDIO/Mt.CQEG75L4FWIU2/TestTTSVoiceName.mp3?Expires=1764262805&amp;OSSAccessKeyId=LTAI5tK3WcKwKtAyaT******&amp;Signature=D%2Fld6gp9Zh6TsGRU9cd6GD2pFY0%3D</a></para>
            /// </summary>
            [NameInMap("audioURL")]
            [Validation(Required=false)]
            public string AudioURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CHECKING</para>
            /// </summary>
            [NameInMap("censorStatus")]
            [Validation(Required=false)]
            public string CensorStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("common")]
            [Validation(Required=false)]
            public bool? Common { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-10T07:48:31Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This is a testTTSVoice。</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Error</para>
            /// </summary>
            [NameInMap("errorDetail")]
            [Validation(Required=false)]
            public string ErrorDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FEMALE</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>M1lhKArheOyYdeYybDFqS1-Q</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-10T07:48:31Z</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestTTSVoiceName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("pitchRate")]
            [Validation(Required=false)]
            public float? PitchRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("remainSeconds")]
            [Validation(Required=false)]
            public long? RemainSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("speechRate")]
            [Validation(Required=false)]
            public float? SpeechRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testTTSVoice</para>
            /// </summary>
            [NameInMap("voiceKey")]
            [Validation(Required=false)]
            public string VoiceKey { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7174E51-3523-5AEB-AE18-1D877FF22497</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
