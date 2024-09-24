// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageFixTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The tasks returned.</para>
        /// </summary>
        [NameInMap("BuildTasks")]
        [Validation(Required=false)]
        public List<DescribeImageFixTaskResponseBodyBuildTasks> BuildTasks { get; set; }
        public class DescribeImageFixTaskResponseBodyBuildTasks : TeaModel {
            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ivf-939536b5-c3ca-427b-8183-91007756</para>
            /// </summary>
            [NameInMap("BuildTaskId")]
            [Validation(Required=false)]
            public string BuildTaskId { get; set; }

            /// <summary>
            /// <para>The timestamp when the task starts. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-14 20:34:07</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the task ends. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-14 20:32:05</para>
            /// </summary>
            [NameInMap("FixTime")]
            [Validation(Required=false)]
            public string FixTime { get; set; }

            /// <summary>
            /// <para>The version of the image after image risks are fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redhat8-vault</para>
            /// </summary>
            [NameInMap("NewTag")]
            [Validation(Required=false)]
            public string NewTag { get; set; }

            /// <summary>
            /// <para>The UUID of the image after image risks are fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2fa731681911ae8d1b5f11893ace****</para>
            /// </summary>
            [NameInMap("NewUuid")]
            [Validation(Required=false)]
            public string NewUuid { get; set; }

            /// <summary>
            /// <para>The version of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos8.1-ja</para>
            /// </summary>
            [NameInMap("OldTag")]
            [Validation(Required=false)]
            public string OldTag { get; set; }

            /// <summary>
            /// <para>The UUID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2fa731681911ae8d1b5f11893ace****</para>
            /// </summary>
            [NameInMap("OldUuid")]
            [Validation(Required=false)]
            public string OldUuid { get; set; }

            /// <summary>
            /// <para>The region of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-redhat</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name-002</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The task is running.</description></item>
            /// <item><description><b>2</b>: The task is successful.</description></item>
            /// <item><description><b>3</b>: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of the task. The value is fixed as IMAGE_REPAIR. The value indicates a task that fixes image risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE_REPAIR</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The alias of the fixed vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2007-5686:rpath_linux Information Disclosure</para>
            /// </summary>
            [NameInMap("VulAlias")]
            [Validation(Required=false)]
            public string VulAlias { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageFixTaskResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageFixTaskResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of tasks returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page. Default value: <b>1</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: <b>20</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of tasks returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AC52BBA-85D3-5F64-9B48-D08437CAF916</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
