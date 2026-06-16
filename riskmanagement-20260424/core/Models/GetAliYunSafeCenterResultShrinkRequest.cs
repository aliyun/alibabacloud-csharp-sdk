// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAliYunSafeCenterResultShrinkRequest : TeaModel {
        [NameInMap("CreateSimilarSecurityEventsQueryTaskRequest")]
        [Validation(Required=false)]
        public string CreateSimilarSecurityEventsQueryTaskRequestShrink { get; set; }

        [NameInMap("DescribeInstancesFullStatusRequest")]
        [Validation(Required=false)]
        public string DescribeInstancesFullStatusRequestShrink { get; set; }

        [NameInMap("DescribeSecurityEventOperationStatusRequest")]
        [Validation(Required=false)]
        public string DescribeSecurityEventOperationStatusRequestShrink { get; set; }

        [NameInMap("DescribeSimilarSecurityEventsRequest")]
        [Validation(Required=false)]
        public string DescribeSimilarSecurityEventsRequestShrink { get; set; }

        [NameInMap("GetAssetDetailByUuidRequest")]
        [Validation(Required=false)]
        public string GetAssetDetailByUuidRequestShrink { get; set; }

        [NameInMap("HandleSecurityEventsRequest")]
        [Validation(Required=false)]
        public string HandleSecurityEventsRequestShrink { get; set; }

        [NameInMap("HandleSimilarSecurityEventsRequest")]
        [Validation(Required=false)]
        public string HandleSimilarSecurityEventsRequestShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InterfaceCode")]
        [Validation(Required=false)]
        public string InterfaceCode { get; set; }

        [NameInMap("ListInstancesRequest")]
        [Validation(Required=false)]
        public string ListInstancesRequestShrink { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
