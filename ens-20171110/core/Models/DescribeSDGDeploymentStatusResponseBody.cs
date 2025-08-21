// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGDeploymentStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of SDG deployment information.</para>
        /// </summary>
        [NameInMap("DeploymentStatus")]
        [Validation(Required=false)]
        public List<DescribeSDGDeploymentStatusResponseBodyDeploymentStatus> DeploymentStatus { get; set; }
        public class DescribeSDGDeploymentStatusResponseBodyDeploymentStatus : TeaModel {
            [NameInMap("BlockRwSplitSize")]
            [Validation(Required=false)]
            public int? BlockRwSplitSize { get; set; }

            [NameInMap("CacheSize")]
            [Validation(Required=false)]
            public int? CacheSize { get; set; }

            [NameInMap("DiskAccessProtocol")]
            [Validation(Required=false)]
            public string DiskAccessProtocol { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The ID of the AIC instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aic-xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The deployment type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>overlay: read/write splitting.</description></item>
            /// <item><description>common: common deployment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>overlay</para>
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
            /// <para>The ID of the edge node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The deployment status of the SDG.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>sdg_deploying</description></item>
            /// <item><description>success</description></item>
            /// <item><description>failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the status was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-17T02:44:31Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68B85217-03B8-5141-9216-EA4D7C496B9A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of queried deployment records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
