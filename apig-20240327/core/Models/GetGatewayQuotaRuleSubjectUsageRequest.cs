// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayQuotaRuleSubjectUsageRequest : TeaModel {
        /// <summary>
        /// <para>The end time for querying detailed consumption records. The time is a UNIX timestamp in seconds. If only this parameter is specified, the system automatically calculates the start time based on the rule period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788425220</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter out zero values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("filterFailedRequests")]
        [Validation(Required=false)]
        public bool? FilterFailedRequests { get; set; }

        /// <summary>
        /// <para>The page number of the detailed consumption (request) records for the consumer subject within the period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for the detailed consumption (request) records of the consumer subject within the period. Maximum value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time for querying detailed consumption records. The time is a UNIX timestamp in seconds. If only this parameter is specified, the system automatically calculates the end time based on the rule period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788338820</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
