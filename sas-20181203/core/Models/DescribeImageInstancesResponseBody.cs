// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of image information.</para>
        /// </summary>
        [NameInMap("ImageInstanceList")]
        [Validation(Required=false)]
        public List<DescribeImageInstancesResponseBodyImageInstanceList> ImageInstanceList { get; set; }
        public class DescribeImageInstancesResponseBodyImageInstanceList : TeaModel {
            /// <summary>
            /// <para>The number of security alerts for the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            /// <summary>
            /// <para>Indicates whether security alerts exist for the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b>: security alerts exist.</description></item>
            /// <item><description><b>NO</b>: no security alerts exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the image has been deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: not deployed.</description></item>
            /// <item><description><b>1</b>: deployed.</description></item>
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
            /// <para>The endpoint addresses of the image resource.</para>
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
            /// <para>The baseline risk status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: no baseline risk exists.</description></item>
            /// <item><description><b>YES</b>: baseline risk exists.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("HcStatus")]
            [Validation(Required=false)]
            public string HcStatus { get; set; }

            /// <summary>
            /// <para>The timestamp when the image was created. Unit: milliseconds.</para>
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
            /// <para>The timestamp when the image was updated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600069948849</para>
            /// </summary>
            [NameInMap("ImageUpdate")]
            [Validation(Required=false)]
            public string ImageUpdate { get; set; }

            /// <summary>
            /// <para>The instance ID of the image asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39010****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest scan. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721363159000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The ID of the region where the image is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The registry type of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>acr</b>: ACR.</description></item>
            /// <item><description><b>harbor</b>: Harbor.</description></item>
            /// <item><description><b>quay</b>: Quay.</description></item>
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
            /// <para>The namespace of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>The repository type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>private</b>: private repository.</description></item>
            /// <item><description><b>public</b>: public repository.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// <para>Indicates whether a risk exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: no risk.</description></item>
            /// <item><description><b>YES</b>: risk exists.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// <para>The scan progress of the image. Value range: 0 to 100.</para>
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
            /// <item><description><b>TASK_NOT_EXISTS</b>: the task does not exist.</description></item>
            /// <item><description><b>TASK_NOT_SUPPORT_REGION</b>: the task does not support the region.</description></item>
            /// <item><description><b>forbid_create_repeat_task</b>: repeated tasks are not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TASK_NOT_SUPPORT_REGION</para>
            /// </summary>
            [NameInMap("ScaResult")]
            [Validation(Required=false)]
            public string ScaResult { get; set; }

            /// <summary>
            /// <para>The image scan status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: image scan pending.</description></item>
            /// <item><description><b>START</b>: image scan started.</description></item>
            /// <item><description><b>MESSAGE_SEND</b>: image scan message sent.</description></item>
            /// <item><description><b>START_RUN</b>: image analysis task started.</description></item>
            /// <item><description><b>DOWNLOAD</b>: image scan downloaded.</description></item>
            /// <item><description><b>PRE_ANALYZER</b>: image pre-analysis started.</description></item>
            /// <item><description><b>WEB_SHELL_ANALYZER</b>: image WebShell analysis completed.</description></item>
            /// <item><description><b>CVE_ANALYZER</b>: image CVE analysis completed.</description></item>
            /// <item><description><b>BIN_ANALYZER</b>: image binary analysis completed.</description></item>
            /// <item><description><b>OTHER_ANALYZER</b>: image extended analysis completed.</description></item>
            /// <item><description><b>SUCCESS</b>: image scan completed.</description></item>
            /// <item><description><b>PRE_ANALYZER_SUCCESS</b>: image pre-analysis completed.</description></item>
            /// <item><description><b>FAIL</b>: image scan failed.</description></item>
            /// <item><description><b>TIMEOUT</b>: image scan timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("ScaStatus")]
            [Validation(Required=false)]
            public string ScaStatus { get; set; }

            /// <summary>
            /// <para>The business tag of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAI</para>
            /// </summary>
            [NameInMap("SourceBizTag")]
            [Validation(Required=false)]
            public string SourceBizTag { get; set; }

            /// <summary>
            /// <para>The image status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NORMAL</b>: normal.</description></item>
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
            /// <item><description><b>YES</b>: vulnerabilities exist.</description></item>
            /// <item><description><b>NO</b>: no vulnerabilities exist.</description></item>
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
        /// <para>The pagination information of the query result.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of images displayed on the current page of the returned results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in the paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries of image information displayed on each page in the paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578ABF384</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
