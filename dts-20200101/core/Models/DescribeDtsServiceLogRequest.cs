// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsServiceLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data migration or synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1yr56py103****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The end time of the log information. You can call <a href="https://help.aliyun.com/document_detail/209718.html">DescribePreCheckStatus</a> to query the end time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To query the log information of a DTS subtask within a specific time range, call <a href="https://help.aliyun.com/document_detail/209718.html">DescribePreCheckStatus</a> to query the execution time of the DTS subtask.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The time is a 13-digit UNIX timestamp in milliseconds. You can use a search engine to find a UNIX timestamp converter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1620897227000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The keyword used to filter query results.</para>
        /// <remarks>
        /// <para>Fuzzy match is used and the keyword is case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>state = IDLE</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of log entries per page. Valid values: <b>20</b>, <b>50</b>, <b>100</b>, <b>500</b>, and <b>1000</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID. Specify this parameter to indicate the region where the instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The start time of the log information.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To query the log information of a DTS subtask within a specific time range, call <a href="https://help.aliyun.com/document_detail/209718.html">DescribePreCheckStatus</a> to query the execution time of the DTS subtask.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The start time is a 13-digit UNIX timestamp in milliseconds. You can use a search engine to find a UNIX timestamp converter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1620896327000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The log level of the log information. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: Normal.</description></item>
        /// <item><description><b>WARN</b>: Warning.</description></item>
        /// <item><description><b>ERROR</b>: Error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL,WARN,ERROR</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the DTS task subnode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DATA_LOAD</b>: full data migration or initial full data synchronization.</description></item>
        /// <item><description><b>ONLINE_WRITER</b>: incremental data migration.</description></item>
        /// <item><description><b>SYNC_WRITER</b>: incremental data synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC_WRITER</para>
        /// </summary>
        [NameInMap("SubJobType")]
        [Validation(Required=false)]
        public string SubJobType { get; set; }

        /// <summary>
        /// <para>Specifies whether the node is a seamless integration (Zero-ETL) node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
