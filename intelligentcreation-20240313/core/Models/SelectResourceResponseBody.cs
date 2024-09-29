// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SelectResourceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0E8B1746-AE35-5C4B-A3A8-345B274AE32C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resourceInfoList")]
        [Validation(Required=false)]
        public List<SelectResourceResponseBodyResourceInfoList> ResourceInfoList { get; set; }
        public class SelectResourceResponseBodyResourceInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("lastExpire")]
            [Validation(Required=false)]
            public int? LastExpire { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1249</para>
            /// </summary>
            [NameInMap("remainCount")]
            [Validation(Required=false)]
            public int? RemainCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public int? ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>second</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

    }

}
