// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkFace20180720.Models
{
    public class SearchFaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchFaceResponseBodyData Data { get; set; }
        public class SearchFaceResponseBodyData : TeaModel {
            [NameInMap("TopUserItem")]
            [Validation(Required=false)]
            public List<SearchFaceResponseBodyDataTopUserItem> TopUserItem { get; set; }
            public class SearchFaceResponseBodyDataTopUserItem : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.78</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iot</para>
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
        /// <para>862B97AF-1115-410D-8D35-A3068CED58CE</para>
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
