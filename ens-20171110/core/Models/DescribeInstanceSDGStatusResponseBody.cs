// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceSDGStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of SDG deployment information.</para>
        /// </summary>
        [NameInMap("DeploymentStatus")]
        [Validation(Required=false)]
        public List<DescribeInstanceSDGStatusResponseBodyDeploymentStatus> DeploymentStatus { get; set; }
        public class DescribeInstanceSDGStatusResponseBodyDeploymentStatus : TeaModel {
            /// <summary>
            /// <para>The size of the writable layer of the block device. Unit: GiB. A value of 0 indicates that this feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("BlockRwSplitSize")]
            [Validation(Required=false)]
            public int? BlockRwSplitSize { get; set; }

            /// <summary>
            /// <para>The cache size. Unit: GiB. A value of 0 indicates that this feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CacheSize")]
            [Validation(Required=false)]
            public int? CacheSize { get; set; }

            /// <summary>
            /// <para>The disk access protocol type of the mounted shared cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iscsi</para>
            /// </summary>
            [NameInMap("DiskAccessProtocol")]
            [Validation(Required=false)]
            public string DiskAccessProtocol { get; set; }

            /// <summary>
            /// <para>The disk type of the mounted shared cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The edge zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-guangzhou-26</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The AIC instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aic-xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The deployment type of the SDG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shared</para>
            /// </summary>
            [NameInMap("MountType")]
            [Validation(Required=false)]
            public string MountType { get; set; }

            /// <summary>
            /// <para>The deployment phase of the SDG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>attach</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The ID of the SDG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sdg-xxxxxxx</para>
            /// </summary>
            [NameInMap("SDGId")]
            [Validation(Required=false)]
            public string SDGId { get; set; }

            /// <summary>
            /// <para>The deployment status of the SDG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The latest status update time. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-17T02:44:31Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The page number. Starting value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The Settings for the number of entries per page for paging in a paged query. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0003E8B-B930-4F59-ADC0-0E209A9012A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of deployment records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
