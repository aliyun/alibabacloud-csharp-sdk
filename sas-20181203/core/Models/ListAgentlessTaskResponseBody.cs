// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The task list.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListAgentlessTaskResponseBodyList> List { get; set; }
        public class ListAgentlessTaskResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The end timestamp of the task, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678895999999</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-wz95vuqky0ada4******</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-0****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.210.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.25.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The amount of detected data, in MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>154.11</para>
            /// </summary>
            [NameInMap("MeasureSpace")]
            [Validation(Required=false)]
            public long? MeasureSpace { get; set; }

            /// <summary>
            /// <para>The task progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The execution progress of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;scaVul\&quot;:100,\&quot;binary\&quot;:100,\&quot;baseline\&quot;:100,\&quot;vul\&quot;:100,\&quot;webshell\&quot;:100,\&quot;script\&quot;:100,\&quot;sensitiveInfo\&quot;:100}&quot;</para>
            /// </summary>
            [NameInMap("ProgressByProject")]
            [Validation(Required=false)]
            public string ProgressByProject { get; set; }

            /// <summary>
            /// <para>The download URL of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://newsas-oss-bucket.oss-cn-hangzhou.aliyuncs.com/agent_less_single_report">http://newsas-oss-bucket.oss-cn-hangzhou.aliyuncs.com/agent_less_single_report</a>****</para>
            /// </summary>
            [NameInMap("ReportDownloadUrl")]
            [Validation(Required=false)]
            public string ReportDownloadUrl { get; set; }

            /// <summary>
            /// <para>The report status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPARED</b>: Preparing.</description></item>
            /// <item><description><b>RUNNING</b>: Running.</description></item>
            /// <item><description><b>SUCCESS</b>: Succeeded.</description></item>
            /// <item><description><b>TIMEOUT</b>: Timed out.</description></item>
            /// <item><description><b>FAILED</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            /// <summary>
            /// <para>The detection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The start timestamp of the task, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672741657897</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The detection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Detecting.</description></item>
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
            /// <para>The name of the scan target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hkdevt****</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The object type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: snapshot</description></item>
            /// <item><description><b>2</b>: image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public int? TargetType { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1538****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The name of the detection task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENTLESS_SCAN</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The UUID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49e25e0f-bb51-4a5a-a1b3-13a4ddaa****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAgentlessTaskResponseBodyPageInfo PageInfo { get; set; }
        public class ListAgentlessTaskResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the current page in a paged query. Paging starts from page 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paged query. Paging is performed based on this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A975D03-5F49-5354-B2CB-3918D5DA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
