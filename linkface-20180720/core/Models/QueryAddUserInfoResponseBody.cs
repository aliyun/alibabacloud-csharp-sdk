// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkFace20180720.Models
{
    public class QueryAddUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAddUserInfoResponseBodyData Data { get; set; }
        public class QueryAddUserInfoResponseBodyData : TeaModel {
            [NameInMap("CurrentFaceInfos")]
            [Validation(Required=false)]
            public List<QueryAddUserInfoResponseBodyDataCurrentFaceInfos> CurrentFaceInfos { get; set; }
            public class QueryAddUserInfoResponseBodyDataCurrentFaceInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ClientTag")]
                [Validation(Required=false)]
                public string ClientTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun1</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("FailedFaceInfos")]
            [Validation(Required=false)]
            public List<QueryAddUserInfoResponseBodyDataFailedFaceInfos> FailedFaceInfos { get; set; }
            public class QueryAddUserInfoResponseBodyDataFailedFaceInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ClientTag")]
                [Validation(Required=false)]
                public string ClientTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun2</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7E375685-FFDF-4AE9-9D07-E2335094F635</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
