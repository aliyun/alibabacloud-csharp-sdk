// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeOnceTaskLeafRecordPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of task details.</para>
        /// </summary>
        [NameInMap("OnceTasks")]
        [Validation(Required=false)]
        public List<DescribeOnceTaskLeafRecordPageResponseBodyOnceTasks> OnceTasks { get; set; }
        public class DescribeOnceTaskLeafRecordPageResponseBodyOnceTasks : TeaModel {
            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1670307567000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is completed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not completed.</description></item>
            /// <item><description><b>1</b>: Completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public int? Finish { get; set; }

            /// <summary>
            /// <para>The number of completed records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67</para>
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public string FinishCount { get; set; }

            /// <summary>
            /// <para>The export progress percentage (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>75</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// <para>The task execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1670307567000</para>
            /// </summary>
            [NameInMap("RealRunTime")]
            [Validation(Required=false)]
            public long? RealRunTime { get; set; }

            /// <summary>
            /// <para>The execution result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TASK_NOT_SUPPORT_REGION</para>
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// <para>The start execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640102400000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The running status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: Pending.</description></item>
            /// <item><description><b>START</b>: Started.</description></item>
            /// <item><description><b>SUCCESS</b>: Completed.</description></item>
            /// <item><description><b>TIMEOUT</b>: Timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("StatusText")]
            [Validation(Required=false)]
            public string StatusText { get; set; }

            /// <summary>
            /// <para>The task target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>238cf050a7270dd6940602e70f1e5a11eeaf4e02035f445b7f613ff5e064****</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The scan object type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IMAGE_REPO</b>: Image repository.</description></item>
            /// <item><description><b>IMAGE</b>: Image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9fb50f2af8bb67c9fdb684194c83****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The image scan-related information.</para>
            /// </summary>
            [NameInMap("TaskImageInfo")]
            [Validation(Required=false)]
            public DescribeOnceTaskLeafRecordPageResponseBodyOnceTasksTaskImageInfo TaskImageInfo { get; set; }
            public class DescribeOnceTaskLeafRecordPageResponseBodyOnceTasksTaskImageInfo : TeaModel {
                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ack-jenkins-****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a765ba1435e7f9446065370e9a41****</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The cluster name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACK-test-****</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// <para>The time consumption statistics in JSON format, showing the end time of each item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>vul</b>: System vulnerability.</description></item>
                /// <item><description><b>scaVul</b>: Application vulnerability.</description></item>
                /// <item><description><b>baseline</b>: Baseline.</description></item>
                /// <item><description><b>binary</b>: Binary.</description></item>
                /// <item><description><b>forbiddenPackageInfo</b>: Forbidden installation.</description></item>
                /// <item><description><b>identificationInfo</b>: Identity authentication.</description></item>
                /// <item><description><b>script</b>: Malicious script.</description></item>
                /// <item><description><b>sensitiveFile</b>: Sensitive file.</description></item>
                /// <item><description><b>sensitiveInfo</b>: AK detection.</description></item>
                /// <item><description><b>webshell</b>: Web shell.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;scaVul&quot;:&quot;2023-09-04 09:37:21&quot;,&quot;identificationInfo&quot;:&quot;2023-09-04 09:37:30&quot;,&quot;forbiddenPackageInfo&quot;:&quot;2023-09-04 09:37:16&quot;,&quot;binary&quot;:&quot;2023-09-04 09:37:25&quot;,&quot;baseline&quot;:&quot;2023-09-04 09:37:19&quot;,&quot;sensitiveFile&quot;:&quot;2023-09-04 09:38:34&quot;,&quot;vul&quot;:&quot;2023-09-04 09:37:31&quot;,&quot;webshell&quot;:&quot;2023-09-04 09:38:27&quot;,&quot;sensitiveInfo&quot;:&quot;2023-09-04 09:37:16&quot;,&quot;script&quot;:&quot;2023-09-04 09:39:44&quot;}</para>
                /// </summary>
                [NameInMap("CostTimeInfo")]
                [Validation(Required=false)]
                public string CostTimeInfo { get; set; }

                /// <summary>
                /// <para>The image digest.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9e0dc29d872d2e386cc5c0c92b529a84e3acfade16f5cb1d054a2ee3c99****</para>
                /// </summary>
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// <para>The container image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b>s.com/sas_test/baseli</b></em></para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The node instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-0xi5mxvtmfw9****</para>
                /// </summary>
                [NameInMap("NodeInstanceId")]
                [Validation(Required=false)]
                public string NodeInstanceId { get; set; }

                /// <summary>
                /// <para>The node IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.18.XXX.XXX</para>
                /// </summary>
                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pztest****</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The image pod information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>expoit-law-****</para>
                /// </summary>
                [NameInMap("Pod")]
                [Validation(Required=false)]
                public string Pod { get; set; }

                /// <summary>
                /// <para>The region where the server image is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The type of the image repository. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>acr</b>: acr.</description></item>
                /// <item><description><b>harbor</b>: harbor.</description></item>
                /// <item><description><b>quay</b>: quay.</description></item>
                /// <item><description><b>CI/CD</b>: CI/CD repository type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>acr</para>
                /// </summary>
                [NameInMap("RegistryType")]
                [Validation(Required=false)]
                public string RegistryType { get; set; }

                /// <summary>
                /// <para>The image repository ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>crr-r88w2vryp8m****</para>
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                /// <summary>
                /// <para>The image repository name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testyyy</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>The image namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bitn***</para>
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// <para>The region ID of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RepoRegionId")]
                [Validation(Required=false)]
                public string RepoRegionId { get; set; }

                /// <summary>
                /// <para>The image tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1.20-002-a2*****</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE_SCAN</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE_SCAN</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The total number of records. This parameter takes effect in a paged query with paging enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeOnceTaskLeafRecordPageResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeOnceTaskLeafRecordPageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of records on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records in the query result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID generated by Alibaba Cloud for this request. You can use it to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB393****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
