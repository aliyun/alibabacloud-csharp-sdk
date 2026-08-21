// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstanceInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInstanceInfoResponseBodyData> Data { get; set; }
        public class ListInstanceInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sysom</para>
            /// </summary>
            [NameInMap("infoKey")]
            [Validation(Required=false)]
            public string InfoKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instance_tag</para>
            /// </summary>
            [NameInMap("infoType")]
            [Validation(Required=false)]
            public string InfoType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>diagnosis</para>
            /// </summary>
            [NameInMap("infoValue")]
            [Validation(Required=false)]
            public string InfoValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>U+w1wv2R4ZWR5oZLXD0+Dp4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
