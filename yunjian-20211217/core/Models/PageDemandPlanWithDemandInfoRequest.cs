// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class PageDemandPlanWithDemandInfoRequest : TeaModel {
        [NameInMap("approvalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        [NameInMap("createTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        [NameInMap("createTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        [NameInMap("creatorStaffId")]
        [Validation(Required=false)]
        public string CreatorStaffId { get; set; }

        [NameInMap("demandDeliveryStatus")]
        [Validation(Required=false)]
        public string DemandDeliveryStatus { get; set; }

        [NameInMap("demandId")]
        [Validation(Required=false)]
        public List<long?> DemandId { get; set; }

        [NameInMap("demandPlanId")]
        [Validation(Required=false)]
        public List<long?> DemandPlanId { get; set; }

        [NameInMap("demandPlanStatus")]
        [Validation(Required=false)]
        public string DemandPlanStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("roCode")]
        [Validation(Required=false)]
        public string RoCode { get; set; }

    }

}
