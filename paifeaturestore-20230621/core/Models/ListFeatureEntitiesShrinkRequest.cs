// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureEntitiesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results by a list of feature entity IDs.</para>
        /// </summary>
        [NameInMap("FeatureEntityIds")]
        [Validation(Required=false)]
        public string FeatureEntityIdsShrink { get; set; }

        /// <summary>
        /// <para>Filters the results by feature entity name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature_entity_1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Asc</c>: Ascending order.</para>
        /// </description></item>
        /// <item><description><para><c>Desc</c>: Descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231432*****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Values start at 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters the results by parent feature entity ID. Omit this parameter to return all feature entities. Set it to <c>0</c> to return all root feature entities. Set it to a non-zero value to return all child feature entities of the specified parent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ParentFeatureEntityId")]
        [Validation(Required=false)]
        public string ParentFeatureEntityId { get; set; }

        /// <summary>
        /// <para>The project ID. You can obtain this ID by calling the <c>ListProjects</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The field to sort the results by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModifiedTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
