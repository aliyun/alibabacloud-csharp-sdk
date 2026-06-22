// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListVirusScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the results to return. Default value: <b>1</b>, which indicates that results start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The timestamp of the task end time to query, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1680919232999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.27.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>The private IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.26.XX.XX</para>
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// <para>The language type of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oracle-win-001****</para>
        /// </summary>
        [NameInMap("MachineName")]
        [Validation(Required=false)]
        public string MachineName { get; set; }

        /// <summary>
        /// <para>The number of tasks per page in a paged query. Default value: <b>20</b>, which indicates that each page contains 20 tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the task is the root task of the virus scan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RootTask")]
        [Validation(Required=false)]
        public bool? RootTask { get; set; }

        /// <summary>
        /// <para>The root task ID.</para>
        /// <remarks>
        /// <para>Call <a href="~~GetVirusScanLatestTaskStatistic~~">GetVirusScanLatestTaskStatistic</a> to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>89f5d7813bd59dd237580a8664b3xxxx</para>
        /// </summary>
        [NameInMap("RootTaskId")]
        [Validation(Required=false)]
        public string RootTaskId { get; set; }

        /// <summary>
        /// <para>The scan type of the virus scan task to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>system</b>: automatic system scan</description></item>
        /// <item><description><b>user</b>: custom user scan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// <para>The timestamp of the task start time to query, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1680919232000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The execution status of the virus scan task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Scanning.</description></item>
        /// <item><description><b>2</b>: Completed.</description></item>
        /// <item><description><b>3</b>: Failed.</description></item>
        /// <item><description><b>4</b>: Timed out.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The list of statuses used to filter tasks by multiple statuses.</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<int?> StatusList { get; set; }

        /// <summary>
        /// <para>The ID of the virus scan task to query.</para>
        /// <remarks>
        /// <para>Call <a href="~~ListVirusScanTask~~">ListVirusScanTask</a> to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1471d8ebb96795b41ede090b9758****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
