// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansCoverageDetailShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account for which you want to query coverage details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123745698925000</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end is excluded from the time range. If you do not set this parameter, the end time is the current time. Specify the time in the format of yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-09 00:00:00</para>
        /// </summary>
        [NameInMap("EndPeriod")]
        [Validation(Required=false)]
        public string EndPeriod { get; set; }

        [NameInMap("FilterParam")]
        [Validation(Required=false)]
        public string FilterParamShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The time granularity at which coverage details are queried. Valid values: MONTH, DAY, and HOUR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The beginning is included in the time range. Specify the time in the format of yyyy-MM-dd HH:mm:ss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-15 13:40:45</para>
        /// </summary>
        [NameInMap("StartPeriod")]
        [Validation(Required=false)]
        public string StartPeriod { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. You do not need to set this parameter if you query coverage details within a specific time range for the first time. The response returns a token that you can use to query coverage details that are displayed on the next page. If a null value is returned for the NextToken parameter, no more coverage details can be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6MTB9</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
