// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorComputeSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The resource types, which are used to filter query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>engine: filters results by engine.</description></item>
        /// <item><description>queue: filters results by queue.</description></item>
        /// <item><description>cluster: displays the results at the cluster level.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the information at the cluster level is displayed by default. Currently, only one resource type is supported. If you specify multiple resource types, the first resource type is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ComponentTypes")]
        [Validation(Required=false)]
        public List<string> ComponentTypes { get; set; }

        /// <summary>
        /// <para>Specify the date in the ISO 8601 standard. For example, 2023-01-01 represents January 1, 2023.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01</para>
        /// </summary>
        [NameInMap("DateTime")]
        [Validation(Required=false)]
        public string DateTime { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The basis on which you want to sort the query results. Valid values:</para>
        /// <ol>
        /// <item><description>vcoreSeconds: the total CPU consumption over time in seconds.</description></item>
        /// <item><description>memSeconds: the total memory consumption over time in seconds.</description></item>
        /// <item><description>vcoreUtilization: the average CPU utilization. The meaning is the same as the %CPU parameter in the output of the top command in Linux.</description></item>
        /// <item><description>memUtilization: the average memory usage.</description></item>
        /// <item><description>vcoreSecondsDayGrowthRatio: the day-to-day growth rate of the total CPU consumption over time in seconds.</description></item>
        /// <item><description>memSecondsDayGrowthRatio: the day-to-day growth rate of the total memory consumption over time in seconds.</description></item>
        /// <item><description>readSize: the total amount of data read from the file system.</description></item>
        /// <item><description>writeSize: the total amount of data written to the file system.</description></item>
        /// <item><description>healthyJobCount: the total number of healthy jobs.</description></item>
        /// <item><description>subHealthyJobCount: the total number of sub-healthy jobs.</description></item>
        /// <item><description>unhealthyJobCount: the total number of unhealthy jobs.</description></item>
        /// <item><description>needAttentionJobCount: the total number of jobs that require attention.</description></item>
        /// <item><description>score: the score for jobs.</description></item>
        /// <item><description>scoreDayGrowthRatio: the day-to-day growth rate of the score for jobs.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>score</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: in ascending order.</description></item>
        /// <item><description>DESC: in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
