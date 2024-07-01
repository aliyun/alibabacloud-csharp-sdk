// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsForTemplateRequest : TeaModel {
        /// <summary>
        /// The UTC time when the quota application ends.
        /// </summary>
        [NameInMap("ApplyEndTime")]
        [Validation(Required=false)]
        public string ApplyEndTime { get; set; }

        /// <summary>
        /// The UTC time when the quota application starts.
        /// </summary>
        [NameInMap("ApplyStartTime")]
        [Validation(Required=false)]
        public string ApplyStartTime { get; set; }

        /// <summary>
        /// The ID of the quota application batch.
        /// </summary>
        [NameInMap("BatchQuotaApplicationId")]
        [Validation(Required=false)]
        public string BatchQuotaApplicationId { get; set; }

        /// <summary>
        /// The maximum number of entries to return for a single request.
        /// 
        /// Valid values: 1 to 100. Default value: 30.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position from which you want to start the query.
        /// 
        /// >  An empty value indicates that the query starts from the beginning.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The abbreviation of the Alibaba Cloud service name.
        /// 
        /// >  To query the abbreviation of an Alibaba Cloud service name, call the [ListProducts](https://help.aliyun.com/document_detail/440555.html) operation and check the value of `ProductCode` in the response.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The quota ID.
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// The quota type. Valid values:
        /// 
        /// *   CommonQuota: general quota
        /// *   FlowControl: API rate limit
        /// *   WhiteListLabel: privilege
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

    }

}
