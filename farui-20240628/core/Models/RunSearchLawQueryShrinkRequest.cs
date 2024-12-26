// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunSearchLawQueryShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>farui</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("filterCondition")]
        [Validation(Required=false)]
        public string FilterConditionShrink { get; set; }

        [NameInMap("pageParam")]
        [Validation(Required=false)]
        public string PageParamShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("queryKeywords")]
        [Validation(Required=false)]
        public string QueryKeywordsShrink { get; set; }

        [NameInMap("thread")]
        [Validation(Required=false)]
        public string ThreadShrink { get; set; }

    }

}
