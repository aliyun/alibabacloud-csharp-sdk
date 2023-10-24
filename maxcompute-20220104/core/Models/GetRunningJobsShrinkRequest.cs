// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRunningJobsShrinkRequest : TeaModel {
        /// <summary>
        /// The time when the query starts. This parameter specifies the time when a job is submitted.
        /// 
        /// *   The time range that is specified by the **from** and **to** request parameters is a closed interval. The start time and end time are included in the range. If the value of **from** is the same as the value of **to**, the time range is invalid, and a null value is returned.
        /// *   The value is a UNIX timestamp that represents the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public long? From { get; set; }

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
        /// The number of entries per page. Default value: 10. Maximum value: 20.
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

        /// <summary>
        /// The time when the query ends. This parameter specifies the time when a job is submitted.
        /// 
        /// *   The time interval that is specified by the **from** and **to** request parameters is a closed interval. The start time and end time are included in the interval. If the value of **from** is the same as the value of **to**, the interval is invalid, and a null value is returned.
        /// *   The value is a UNIX timestamp that represents the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
