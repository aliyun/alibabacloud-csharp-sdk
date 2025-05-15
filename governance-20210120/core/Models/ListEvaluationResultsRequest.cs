// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationResultsRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member. This parameter takes effect only when a multi-account governance maturity check is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176618589410****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListEvaluationResultsRequestFilters> Filters { get; set; }
        public class ListEvaluationResultsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ResourceId: the resource ID.</description></item>
            /// <item><description>ResourceName: the name of the resource.</description></item>
            /// <item><description>ResourceType: the resource type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The list of filter condition values.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        [NameInMap("LensCode")]
        [Validation(Required=false)]
        public string LensCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
