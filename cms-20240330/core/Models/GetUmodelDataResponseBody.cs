// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetUmodelDataResponseBody : TeaModel {
        [NameInMap("errors")]
        [Validation(Required=false)]
        public List<GetUmodelDataResponseBodyErrors> Errors { get; set; }
        public class GetUmodelDataResponseBodyErrors : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>external</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("links")]
        [Validation(Required=false)]
        public List<object> Links { get; set; }

        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<object> Nodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123-123-234-345-123</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("totalLinksCount")]
        [Validation(Required=false)]
        public int? TotalLinksCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("totalNodesCount")]
        [Validation(Required=false)]
        public int? TotalNodesCount { get; set; }

    }

}
