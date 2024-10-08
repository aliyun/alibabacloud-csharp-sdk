// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class CreateFilterRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("FilterName")]
        [Validation(Required=false)]
        public string FilterName { get; set; }

    }

}
