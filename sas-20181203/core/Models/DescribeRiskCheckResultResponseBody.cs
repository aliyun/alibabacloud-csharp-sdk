// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The check items.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeRiskCheckResultResponseBodyList> List { get; set; }
        public class DescribeRiskCheckResultResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The number of affected assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AffectedCount")]
            [Validation(Required=false)]
            public int? AffectedCount { get; set; }

            /// <summary>
            /// <para>The timestamp when the last check was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639429164000</para>
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public long? CheckTime { get; set; }

            /// <summary>
            /// <para>The ID of the check item. For more information about the check item, see the check item table in the &quot;Response parameters&quot; section of this topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            /// <summary>
            /// <para>The time when the next check will be performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public int? RemainingTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the risks that are detected based on the check item can be fixed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enabled</b>: yes</description></item>
            /// <item><description><b>disabled</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("RepairStatus")]
            [Validation(Required=false)]
            public string RepairStatus { get; set; }

            /// <summary>
            /// <para>The type of the affected assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("RiskAssertType")]
            [Validation(Required=false)]
            public string RiskAssertType { get; set; }

            /// <summary>
            /// <para>An array that consists of the details about the check item.</para>
            /// </summary>
            [NameInMap("RiskItemResources")]
            [Validation(Required=false)]
            public List<DescribeRiskCheckResultResponseBodyListRiskItemResources> RiskItemResources { get; set; }
            public class DescribeRiskCheckResultResponseBodyListRiskItemResources : TeaModel {
                /// <summary>
                /// <para>The details about the check results.</para>
                /// </summary>
                [NameInMap("ContentResource")]
                [Validation(Required=false)]
                public Dictionary<string, object> ContentResource { get; set; }

                /// <summary>
                /// <para>The title in the details. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>bestPractice</b>: description</description></item>
                /// <item><description><b>influence</b>: risk</description></item>
                /// <item><description><b>suggestion</b>: solution</description></item>
                /// <item><description><b>helpResource</b>: reference</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>bestPractice</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

            }

            /// <summary>
            /// <para>The risk level of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The sequence number in the check results. The check items are sorted based on the sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sort")]
            [Validation(Required=false)]
            public int? Sort { get; set; }

            /// <summary>
            /// <para>Indicates whether the check item is supported by the edition of Security Center that you purchase. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enabled</b>: yes</description></item>
            /// <item><description><b>disable</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("StartStatus")]
            [Validation(Required=false)]
            public string StartStatus { get; set; }

            /// <summary>
            /// <para>The status of the check results. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pass</b></description></item>
            /// <item><description><b>failed</b></description></item>
            /// <item><description><b>running</b></description></item>
            /// <item><description><b>waiting</b></description></item>
            /// <item><description><b>ignored</b></description></item>
            /// <item><description><b>falsePositive</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the check task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15384933</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS - Whitelist Configuration</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The type of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Identity authentication and permissions</description></item>
            /// <item><description>Network access control</description></item>
            /// <item><description>Log audit</description></item>
            /// <item><description>Data security</description></item>
            /// <item><description>Monitoring and alerting</description></item>
            /// <item><description>Basic security protection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Log audit</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD271C07-4ACE-413D-AA9B-F14FD3B7717F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
