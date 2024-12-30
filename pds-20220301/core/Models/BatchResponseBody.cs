// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BatchResponseBody : TeaModel {
        /// <summary>
        /// <para>All responses of the child requests.</para>
        /// </summary>
        [NameInMap("responses")]
        [Validation(Required=false)]
        public List<BatchResponseBodyResponses> Responses { get; set; }
        public class BatchResponseBodyResponses : TeaModel {
            /// <summary>
            /// <para>The response parameters of a child request. For more information, see the topic of the corresponding child request.</para>
            /// </summary>
            [NameInMap("body")]
            [Validation(Required=false)]
            public Dictionary<string, object> Body { get; set; }

            /// <summary>
            /// <para>The ID of the child request. The ID is used to associate a child request with a response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93433894994ad2e1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The returned HTTP status code of a child request. For more information, see the topic of the corresponding child request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
