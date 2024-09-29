// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class QueryAvatarResourceResponseBody : TeaModel {
        [NameInMap("queryResourceInfoList")]
        [Validation(Required=false)]
        public List<QueryAvatarResourceResponseBodyQueryResourceInfoList> QueryResourceInfoList { get; set; }
        public class QueryAvatarResourceResponseBodyQueryResourceInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>21275</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1719904342237</para>
            /// </summary>
            [NameInMap("validPeriodTime")]
            [Validation(Required=false)]
            public string ValidPeriodTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D5798660-1531-5D12-9C20-16FEE9D22351</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
