// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarStrategyTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeSoarStrategyTaskResultResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeSoarStrategyTaskResultResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number during paginated queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The maximum number of entries to display per page during paginated queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>总条数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Collection of execution records.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<string> Records { get; set; }

        /// <summary>
        /// <para>The ID of the current request, a unique identifier generated by Alibaba Cloud for this request, which can be used for troubleshooting and issue localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683940A-E4AE-4473-8C40-F4075434****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
