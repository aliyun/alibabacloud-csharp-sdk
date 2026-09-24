// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryAuthUserConnectDurationListRequest : TeaModel {
        /// <summary>
        /// <para>The comparison operator for connection duration. This parameter is used together with Threshold to filter users by a threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GreaterThanThreshold: greater than the threshold.</description></item>
        /// <item><description>LessThanThreshold: less than the threshold.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GreaterThanThreshold</para>
        /// </summary>
        [NameInMap("ComparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// <para>The date for the statistics, in the yyyy-MM-dd format. If this parameter is left empty, statistics from the previous day are returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-24</para>
        /// </summary>
        [NameInMap("DataDate")]
        [Validation(Required=false)]
        public string DataDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only Active Directory (AD) users. This parameter is required when UserName or WithDetail is specified.</para>
        /// </summary>
        [NameInMap("IsAdUser")]
        [Validation(Required=false)]
        public bool? IsAdUser { get; set; }

        /// <summary>
        /// <para>The paging token. This parameter is used only when statistics are collected by individual session details (StatisticType=SingleSession). You do not need to specify this parameter for the first request. For subsequent requests, set this parameter to the NextToken value returned in the previous response to retrieve the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d129c6c0e8c04c8a9f0e2b7c1a3f5e6d</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. Default value: 1. This parameter takes effect only when statistics are collected by daily cumulative duration (StatisticType=Daily).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The statistics type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: collects statistics by daily cumulative connection duration. This is the default value.</description></item>
        /// <item><description>SingleSession: collects statistics by individual session details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("StatisticType")]
        [Validation(Required=false)]
        public string StatisticType { get; set; }

        /// <summary>
        /// <para>The connection duration threshold, in seconds. This parameter must be used together with ComparisonOperator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public int? Threshold { get; set; }

        /// <summary>
        /// <para>The name of the end user. Fuzzy match is supported. When you use this parameter, you must also specify IsAdUser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>Specifies whether to backfill user details such as display name and nickname. This parameter supports both AD users and convenience users. When you use this parameter, you must also specify IsAdUser.</para>
        /// </summary>
        [NameInMap("WithDetail")]
        [Validation(Required=false)]
        public bool? WithDetail { get; set; }

    }

}
