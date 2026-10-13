// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListProductSubscriptionsRequest : TeaModel {
        /// <summary>
        /// <para>The keyword of the consumer name used to search the subscription records of the API product by consumer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumer-1</para>
        /// </summary>
        [NameInMap("consumerName")]
        [Validation(Required=false)]
        public string ConsumerName { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The subscription status used to filter subscriptions. Valid values: PENDING and APPROVED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPROVED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
