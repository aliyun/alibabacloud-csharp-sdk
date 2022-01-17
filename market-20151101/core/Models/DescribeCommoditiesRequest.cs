// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeCommoditiesRequest : TeaModel {
        [NameInMap("CommodityAuditStatuses")]
        [Validation(Required=false)]
        public string CommodityAuditStatuses { get; set; }

        [NameInMap("CommodityCategoryIds")]
        [Validation(Required=false)]
        public string CommodityCategoryIds { get; set; }

        [NameInMap("CommodityGmtCreatedFrom")]
        [Validation(Required=false)]
        public string CommodityGmtCreatedFrom { get; set; }

        [NameInMap("CommodityGmtCreatedTo")]
        [Validation(Required=false)]
        public string CommodityGmtCreatedTo { get; set; }

        [NameInMap("CommodityGmtModifiedFrom")]
        [Validation(Required=false)]
        public string CommodityGmtModifiedFrom { get; set; }

        [NameInMap("CommodityGmtModifiedTo")]
        [Validation(Required=false)]
        public string CommodityGmtModifiedTo { get; set; }

        [NameInMap("CommodityGmtPublishFrom")]
        [Validation(Required=false)]
        public string CommodityGmtPublishFrom { get; set; }

        [NameInMap("CommodityGmtPublishTo")]
        [Validation(Required=false)]
        public string CommodityGmtPublishTo { get; set; }

        [NameInMap("CommodityId")]
        [Validation(Required=false)]
        public string CommodityId { get; set; }

        [NameInMap("CommodityIds")]
        [Validation(Required=false)]
        public string CommodityIds { get; set; }

        [NameInMap("CommodityStatuses")]
        [Validation(Required=false)]
        public string CommodityStatuses { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

    }

}
