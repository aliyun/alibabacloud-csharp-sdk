// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class QueryYuqingMessageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5645a6c9-7d21-4926-a410-db9a1af85faa</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("searchCondition")]
        [Validation(Required=false)]
        public SearchCondition SearchCondition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx43434dsdsd</para>
        /// </summary>
        [NameInMap("teamHashId")]
        [Validation(Required=false)]
        public string TeamHashId { get; set; }

    }

}
