// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class GetUploadPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetUploadPolicyResponseBodyData Data { get; set; }
        public class GetUploadPolicyResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>material/INPUT_CHAT_BACKGROUND_PIC/Mt.CPQHBSWQS5QU2</para>
            /// </summary>
            [NameInMap("ossKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

            [NameInMap("ossPolicy")]
            [Validation(Required=false)]
            public GetUploadPolicyResponseBodyDataOssPolicy OssPolicy { get; set; }
            public class GetUploadPolicyResponseBodyDataOssPolicy : TeaModel {
                /// <summary>
                /// <para>accessId。</para>
                /// 
                /// <b>Example:</b>
                /// <para>LTBI5123ADDJdsadCidYA8kw3</para>
                /// </summary>
                [NameInMap("accessId")]
                [Validation(Required=false)]
                public string AccessId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>material/INPUT_CHAT_BACKGROUND_PIC/Mt.CPQHBSWQS5QU2/</para>
                /// </summary>
                [NameInMap("dir")]
                [Validation(Required=false)]
                public string Dir { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1761551667</para>
                /// </summary>
                [NameInMap("expire")]
                [Validation(Required=false)]
                public string Expire { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>daily-avatar-property.oss-cn-beijing.aliyuncs.com</para>
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eyJleHBpcmF0aW9uIjoiMjAyNS0wMi0yNVQwMzowMDoyNC4xNDNaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsNTM2ODcwOTEyMF0sWyJzdGFydHMtd2l0aCIsIiRrZXkiLCJ0ZW1wXC8xNzQwNDQ4ODI0MTQxLnppcCJdXX0=</para>
                /// </summary>
                [NameInMap("policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>I2KcV3CFloyRr94WhefmVEuNiv0=</para>
                /// </summary>
                [NameInMap("signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

            }

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
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90C68329-A75C-5449-A928-4D0BAD7AA0FA</para>
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
