// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the images.</para>
        /// </summary>
        [NameInMap("ImageInstanceList")]
        [Validation(Required=false)]
        public List<DescribeImageInstancesResponseBodyImageInstanceList> ImageInstanceList { get; set; }
        public class DescribeImageInstancesResponseBodyImageInstanceList : TeaModel {
            /// <summary>
            /// <para>The number of alerts that are generated for the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            /// <summary>
            /// <para>Indicates whether alerts are generated for the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the image was deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The image was not deployed.</description></item>
            /// <item><description><b>1</b>: The image was deployed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Deployed")]
            [Validation(Required=false)]
            public int? Deployed { get; set; }

            /// <summary>
            /// <para>The digest value of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a5ccdd9b166b67e02954aa9b618fe19b7968bd56a15463d2ad7f2643ba5b****</para>
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// <para>The address of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public string Endpoints { get; set; }

            /// <summary>
            /// <para>The number of baseline risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HcCount")]
            [Validation(Required=false)]
            public int? HcCount { get; set; }

            /// <summary>
            /// <para>Indicates whether baseline risks exist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NO</b></description></item>
            /// <item><description><b>YES</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("HcStatus")]
            [Validation(Required=false)]
            public string HcStatus { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the image was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600069948849</para>
            /// </summary>
            [NameInMap("ImageCreate")]
            [Validation(Required=false)]
            public string ImageCreate { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c20987f18b130f9d144c9828df630417e2a9523148930dc3963e9d0dab30****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The size of the image. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1604487690</para>
            /// </summary>
            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public string ImageSize { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the image was updated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600069948849</para>
            /// </summary>
            [NameInMap("ImageUpdate")]
            [Validation(Required=false)]
            public string ImageUpdate { get; set; }

            /// <summary>
            /// <para>The instance ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39010****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The timestamp when the last scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721363159000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

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
            /// <para>The type of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>acr</b></description></item>
            /// <item><description><b>harbor</b></description></item>
            /// <item><description><b>quay</b></description></item>
            /// <item><description><b>CI/CD</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acr</para>
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            /// <summary>
            /// <para>The ID of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f2b86d20bf0855af6aa268ce90fd****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-script-test</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace to which the image repository belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>The type of the repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>private</b></description></item>
            /// <item><description><b>public</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// <para>Indicates whether risks exist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NO</b></description></item>
            /// <item><description><b>YES</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// <para>The scan progress of the image. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ScaProgress")]
            [Validation(Required=false)]
            public int? ScaProgress { get; set; }

            /// <summary>
            /// <para>The error code of the image scan result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TASK_NOT_EXISTS</b>: The image scan task does not exist.</description></item>
            /// <item><description><b>TASK_NOT_SUPPORT_REGION</b>: The image scan task cannot be performed in the current region.</description></item>
            /// <item><description><b>forbid_create_repeat_task</b>: The image scan task already exists.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TASK_NOT_SUPPORT_REGION</para>
            /// </summary>
            [NameInMap("ScaResult")]
            [Validation(Required=false)]
            public string ScaResult { get; set; }

            /// <summary>
            /// <para>The scan status of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The image scan task is pending startup.</description></item>
            /// <item><description><b>START</b>: The image scan task is started.</description></item>
            /// <item><description><b>MESSAGE_SEND</b>: The message about the image scan task is sent.</description></item>
            /// <item><description><b>START_RUN</b>: The image analysis task is started.</description></item>
            /// <item><description><b>DOWNLOAD</b>: The image scan result is downloaded.</description></item>
            /// <item><description><b>PRE_ANALYZER</b>: The image pre-analysis is started.</description></item>
            /// <item><description><b>WEB_SHELL_ANALYZER</b>: The WebShell analysis of the image is complete.</description></item>
            /// <item><description><b>CVE_ANALYZER</b>: The Common Vulnerabilities and Exposures (CVE) analysis of the image is complete.</description></item>
            /// <item><description><b>BIN_ANALYZER</b>: The binary analysis of the image is complete.</description></item>
            /// <item><description><b>OTHER_ANALYZER</b>: The extended analysis of the image is complete.</description></item>
            /// <item><description><b>SUCCESS</b>: The image scan task is complete.</description></item>
            /// <item><description><b>PRE_ANALYZER_SUCCESS</b>: The image pre-analysis is complete.</description></item>
            /// <item><description><b>FAIL</b>: The image scan task failed.</description></item>
            /// <item><description><b>TIMEOUT</b>: The image scan task timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("ScaStatus")]
            [Validation(Required=false)]
            public string ScaStatus { get; set; }

            /// <summary>
            /// <para>The usage label of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAI</para>
            /// </summary>
            [NameInMap("SourceBizTag")]
            [Validation(Required=false)]
            public string SourceBizTag { get; set; }

            /// <summary>
            /// <para>The status of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NORMAL</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql_5.7</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12f80307-60aa-4efa-863a-56d72fb****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities in the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

            /// <summary>
            /// <para>Indicates whether vulnerabilities exist in the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("VulStatus")]
            [Validation(Required=false)]
            public string VulStatus { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of images returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
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
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578ABF384</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
