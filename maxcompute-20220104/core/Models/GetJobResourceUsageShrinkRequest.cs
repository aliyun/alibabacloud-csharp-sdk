// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetJobResourceUsageShrinkRequest : TeaModel {
        /// <summary>
        /// The date that is accurate to the day part for the query. The date must be in the yyyy-MM-dd format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// The list of job executors.
        /// </summary>
        [NameInMap("jobOwnerList")]
        [Validation(Required=false)]
        public string JobOwnerListShrink { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The list of nicknames of quotas that are used by jobs.
        /// </summary>
        [NameInMap("quotaNicknameList")]
        [Validation(Required=false)]
        public string QuotaNicknameListShrink { get; set; }

    }

}
