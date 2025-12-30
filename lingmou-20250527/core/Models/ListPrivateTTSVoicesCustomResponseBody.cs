// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class ListPrivateTTSVoicesCustomResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListPrivateTTSVoicesCustomResponseBodyData Data { get; set; }
        public class ListPrivateTTSVoicesCustomResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<ListPrivateTTSVoicesCustomResponseBodyDataData> Data { get; set; }
            public class ListPrivateTTSVoicesCustomResponseBodyDataData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxx-aliyuncs.com/material/INPUT_TRAIN_AUDIO/Mt.CQEG75L4FWIU2/TestTTSVoiceName.mp3?Expires=1764262805&OSSAccessKeyId=LTAI5tK3WcKwKtAyaTSeq7sx&Signature=D%2Fld6gp9Zh6TsGRU9cd6GD2pFY0%3D">https://xxx-aliyuncs.com/material/INPUT_TRAIN_AUDIO/Mt.CQEG75L4FWIU2/TestTTSVoiceName.mp3?Expires=1764262805&amp;OSSAccessKeyId=LTAI5tK3WcKwKtAyaTSeq7sx&amp;Signature=D%2Fld6gp9Zh6TsGRU9cd6GD2pFY0%3D</a></para>
                /// </summary>
                [NameInMap("audioURL")]
                [Validation(Required=false)]
                public string AudioURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PASS</para>
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
                /// <para>2024-04-15T09:42:15Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Optional for WH managernif no issue will be cancel</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

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
                /// <para>ZH_CN</para>
                /// </summary>
                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-04-15T09:42:15Z</para>
                /// </summary>
                [NameInMap("modifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TestTTSVoice</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("remainSeconds")]
                [Validation(Required=false)]
                public long? RemainSeconds { get; set; }

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
                /// <para>TestTTSVoice</para>
                /// </summary>
                [NameInMap("voiceKey")]
                [Validation(Required=false)]
                public string VoiceKey { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("pages")]
            [Validation(Required=false)]
            public int? Pages { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qht-fc2-test</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7239F9E5-A4DB-55BA-B701-0CE47DBDB0A8</para>
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
