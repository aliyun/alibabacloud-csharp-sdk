// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEcGrantRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("EcGrantRelations")]
        [Validation(Required=false)]
        public List<DescribeEcGrantRelationResponseBodyEcGrantRelations> EcGrantRelations { get; set; }
        public class DescribeEcGrantRelationResponseBodyEcGrantRelations : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250123456123456</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The time when permissions on the VPC were granted to the VBR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-02T11:46Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The VBRs that have permissions on the VPC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>All</b>: VBRs that reside in the specified region and belong to the specified Alibaba Cloud account all have permissions on the VPC.</description></item>
            /// <item><description><b>Specify</b>: Only the specified VBR has permissions on the VPC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("GrantType")]
            [Validation(Required=false)]
            public string GrantType { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1brjuegjc88v3u9****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPCname</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The ID of the vRouter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vrt-bp1i0yzgjd8ra05ec****</para>
            /// </summary>
            [NameInMap("InstanceRouterId")]
            [Validation(Required=false)]
            public string InstanceRouterId { get; set; }

            /// <summary>
            /// <para>The ID of the region where the VPC is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The query result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b>: The VBR has permissions on the VPC.</description></item>
            /// <item><description><b>Deleted</b>: The VBR does not have permissions on the VPC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the VBR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-m5ex0xf63xk8s5bob****</para>
            /// </summary>
            [NameInMap("VbrInstanceId")]
            [Validation(Required=false)]
            public string VbrInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the VBR belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1210123456123456</para>
            /// </summary>
            [NameInMap("VbrOwnerUid")]
            [Validation(Required=false)]
            public long? VbrOwnerUid { get; set; }

            /// <summary>
            /// <para>The ID of the region where the VBR is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VbrRegionNo")]
            [Validation(Required=false)]
            public string VbrRegionNo { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6E90F6B-2B41-5AAF-ABEB-236ADBAAD91D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
