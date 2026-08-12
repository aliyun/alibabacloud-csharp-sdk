// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveResourceConfigFilter : TeaModel {
        /// <summary>
        /// <para>The UModel resource domain filter (exact match).</para>
        /// </summary>
        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public QueryAlertRulesEntityDomainFilter EntityDomain { get; set; }

        /// <summary>
        /// <para>The UModel entity type filter (set inclusion/exclusion).</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public QueryAlertRulesEntityTypeFilter EntityType { get; set; }

        /// <summary>
        /// <para>The CloudMonitor namespace filter (exact match).</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public QueryAlertRulesNamespaceFilter Namespace { get; set; }

        /// <summary>
        /// <para>The CloudMonitor product category filter (exact match).</para>
        /// </summary>
        [NameInMap("productCategory")]
        [Validation(Required=false)]
        public QueryAlertRulesProductCategoryFilter ProductCategory { get; set; }

        /// <summary>
        /// <para>The relationship type filter (set inclusion/exclusion): ALL/UMODEL_ENTITY/CLOUD_INSTANCE/GROUP_V1/GROUP_V2/TAG.</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public QueryAlertRulesRelationTypeFilter RelationType { get; set; }

        /// <summary>
        /// <para>The resources filter (contains uses OR matching; notContains excludes all).</para>
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public QueryAlertRulesResourcesFilter Resources { get; set; }

    }

}
