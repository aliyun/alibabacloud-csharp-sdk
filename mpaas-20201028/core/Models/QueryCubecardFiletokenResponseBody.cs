// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryCubecardFiletokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryCubecardFiletokenResponseBodyResultContent ResultContent { get; set; }
        public class QueryCubecardFiletokenResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryCubecardFiletokenResponseBodyResultContentData Data { get; set; }
            public class QueryCubecardFiletokenResponseBodyResultContentData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public QueryCubecardFiletokenResponseBodyResultContentDataContent Content { get; set; }
                public class QueryCubecardFiletokenResponseBodyResultContentDataContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LTAI5tFgfNzJFDn4Y4BhoRnc</para>
                    /// </summary>
                    [NameInMap("Accessid")]
                    [Validation(Required=false)]
                    public string Accessid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/home/ecs-assist-user/proof/alert</para>
                    /// </summary>
                    [NameInMap("Dir")]
                    [Validation(Required=false)]
                    public string Dir { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1760583447</para>
                    /// </summary>
                    [NameInMap("Expire")]
                    [Validation(Required=false)]
                    public string Expire { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>172.23.129.55</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Permit</para>
                    /// </summary>
                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>yKplu9LQwgKBTDhxp0YozAeCy9c=</para>
                    /// </summary>
                    [NameInMap("Signature")]
                    [Validation(Required=false)]
                    public string Signature { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NONE</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
