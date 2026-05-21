// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListFiltersResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the default filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My Filters</para>
        /// </summary>
        [NameInMap("DefaultFilterName")]
        [Validation(Required=false)]
        public string DefaultFilterName { get; set; }

        /// <summary>
        /// <para>The configurations of the filter.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListFiltersResponseBodyFilters> Filters { get; set; }
        public class ListFiltersResponseBodyFilters : TeaModel {
            /// <summary>
            /// <para>The configurations of the filter.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;regions&quot;: [],
            ///   &quot;tagFilters&quot;: [
            ///     [{ &quot;type&quot;: &quot;notContainTagKey&quot;, &quot;tagKey&quot;: &quot;xxx&quot;, &quot;tagValue&quot;: &quot;&quot; }],
            ///     [{ &quot;tagKey&quot;: &quot;xxx&quot;, &quot;tagValue&quot;: &quot;xxx&quot; }]
            ///   ],
            ///   &quot;resourceTypes&quot;: [
            ///     &quot;ACS::ECS::AutoSnapshotPolicy&quot;
            ///   ]
            /// }</para>
            /// </summary>
            [NameInMap("FilterConfiguration")]
            [Validation(Required=false)]
            public string FilterConfiguration { get; set; }

            /// <summary>
            /// <para>The name of the filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My devices</para>
            /// </summary>
            [NameInMap("FilterName")]
            [Validation(Required=false)]
            public string FilterName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA39FB9C-CB74-5E73-8DFE-3A2B096F0759</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
