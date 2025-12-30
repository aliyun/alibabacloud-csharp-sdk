// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class GetTTSVoiceByIdCustomResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTTSVoiceByIdCustomResponseBodyData Data { get; set; }
        public class GetTTSVoiceByIdCustomResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx-aliyuncs.com/material/INPUT_TTS_VOICE/Mt.CQEG75L4FWIU2/TestTTSVoiceName.mp3?Expires=1764262805&OSSAccessKeyId=LTAI5tK3WcKwKtAyaTSe*****&Signature=D%2Fld6gp9Zh6TsGRU9cd6GD2pFY0%3D">https://xxx-aliyuncs.com/material/INPUT_TTS_VOICE/Mt.CQEG75L4FWIU2/TestTTSVoiceName.mp3?Expires=1764262805&amp;OSSAccessKeyId=LTAI5tK3WcKwKtAyaTSe*****&amp;Signature=D%2Fld6gp9Zh6TsGRU9cd6GD2pFY0%3D</a></para>
            /// </summary>
            [NameInMap("audioURL")]
            [Validation(Required=false)]
            public string AudioURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CHECKING。</para>
            /// </summary>
            [NameInMap("censorStatus")]
            [Validation(Required=false)]
            public string CensorStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false。</para>
            /// </summary>
            [NameInMap("common")]
            [Validation(Required=false)]
            public bool? Common { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-11-28T10:11:28</para>
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

            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

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
            /// <para>M1lhKArheOyYdeYyb*****</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-11-28T13:41:31</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestTTSVoiceName。</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100。</para>
            /// </summary>
            [NameInMap("remainSeconds")]
            [Validation(Required=false)]
            public long? RemainSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS。</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>avatar-2464b55a65794e75a20fe07dde2*****</para>
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
        /// <para>7239F9E5-A4DB-55BA-B701-0CE47DBD****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True。</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
