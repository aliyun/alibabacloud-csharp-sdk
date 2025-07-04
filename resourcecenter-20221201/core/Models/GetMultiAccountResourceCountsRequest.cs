// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetMultiAccountResourceCountsRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<GetMultiAccountResourceCountsRequestFilter> Filter { get; set; }
        public class GetMultiAccountResourceCountsRequestFilter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>RegionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Equals</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ResourceType</para>
        /// </summary>
        [NameInMap("GroupByKey")]
        [Validation(Required=false)]
        public string GroupByKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rd-r4****</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
