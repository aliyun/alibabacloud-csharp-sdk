// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveResourceConfigFilter : TeaModel {
        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public QueryAlertRulesEntityDomainFilter EntityDomain { get; set; }

        [NameInMap("entityType")]
        [Validation(Required=false)]
        public QueryAlertRulesEntityTypeFilter EntityType { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public QueryAlertRulesNamespaceFilter Namespace { get; set; }

        [NameInMap("productCategory")]
        [Validation(Required=false)]
        public QueryAlertRulesProductCategoryFilter ProductCategory { get; set; }

        [NameInMap("relationType")]
        [Validation(Required=false)]
        public QueryAlertRulesRelationTypeFilter RelationType { get; set; }

        [NameInMap("resources")]
        [Validation(Required=false)]
        public QueryAlertRulesResourcesFilter Resources { get; set; }

    }

}
