// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageFixTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the image repair tasks.</para>
        /// </summary>
        [NameInMap("BuildTasks")]
        [Validation(Required=false)]
        public List<DescribeImageFixTaskResponseBodyBuildTasks> BuildTasks { get; set; }
        public class DescribeImageFixTaskResponseBodyBuildTasks : TeaModel {
            /// <summary>
            /// <para>The ID of the image repair task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ivf-939536b5-c3ca-427b-8183-91007756</para>
            /// </summary>
            [NameInMap("BuildTaskId")]
            [Validation(Required=false)]
            public string BuildTaskId { get; set; }

            /// <summary>
            /// <para>The timestamp when the repair task started. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-14 20:34:07</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the repair task ended. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-14 20:32:05</para>
            /// </summary>
            [NameInMap("FixTime")]
            [Validation(Required=false)]
            public string FixTime { get; set; }

            /// <summary>
            /// <para>The tag of the repaired image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redhat8-vault</para>
            /// </summary>
            [NameInMap("NewTag")]
            [Validation(Required=false)]
            public string NewTag { get; set; }

            /// <summary>
            /// <para>The UUID of the repaired image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2fa731681911ae8d1b5f11893ace****</para>
            /// </summary>
            [NameInMap("NewUuid")]
            [Validation(Required=false)]
            public string NewUuid { get; set; }

            /// <summary>
            /// <para>The tag of the original image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos8.1-ja</para>
            /// </summary>
            [NameInMap("OldTag")]
            [Validation(Required=false)]
            public string OldTag { get; set; }

            /// <summary>
            /// <para>The UUID of the original image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2fa731681911ae8d1b5f11893ace****</para>
            /// </summary>
            [NameInMap("OldUuid")]
            [Validation(Required=false)]
            public string OldUuid { get; set; }

            /// <summary>
            /// <para>The region ID of the image.</para>
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
            /// <para>The status of the image repair task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Repairing</description></item>
            /// <item><description><b>2</b>: Repaired</description></item>
            /// <item><description><b>3</b>: Repair failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of the image repair task. The value is fixed as IMAGE_REPAIR, which indicates image repair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE_REPAIR</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability that was repaired.</para>
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
            /// <para>The number of image repair tasks on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the results returned. Default value: <b>1</b>, which indicates that the results start from page 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page in a paginated query. Default value: <b>20</b>, which indicates that up to 20 entries are returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of image repair tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AC52BBA-85D3-5F64-9B48-D08437CAF916</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
