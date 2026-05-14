// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasAISearchProxy20260424.Models
{
    public class WebSearchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public WebSearchResponseBodyData Data { get; set; }
        public class WebSearchResponseBodyData : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<WebSearchResponseBodyDataResult> Result { get; set; }
            public class WebSearchResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1990-01-01 12:00:00</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>snippet</para>
                /// </summary>
                [NameInMap("snippet")]
                [Validation(Required=false)]
                public string Snippet { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public WebSearchResponseBodyDataResultSource Source { get; set; }
                public class WebSearchResponseBodyDataResultSource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>domain</para>
                    /// </summary>
                    [NameInMap("domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>favicon</para>
                    /// </summary>
                    [NameInMap("favicon")]
                    [Validation(Required=false)]
                    public string Favicon { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4567</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://pai-dlc-proxy-1-cn-wulanchabu.aliyun.com/ray/dashboard/dlc1a9r0uhfn24cl">https://pai-dlc-proxy-1-cn-wulanchabu.aliyun.com/ray/dashboard/dlc1a9r0uhfn24cl</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
