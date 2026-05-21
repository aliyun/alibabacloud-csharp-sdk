// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListPostpaidRatePlanInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ListPostpaidRatePlanInstances</para>
        /// </summary>
        [NameInMap("CheckRemainingSiteQuota")]
        [Validation(Required=false)]
        public string CheckRemainingSiteQuota { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UnrelatedType")]
        [Validation(Required=false)]
        public string UnrelatedType { get; set; }

    }

}
