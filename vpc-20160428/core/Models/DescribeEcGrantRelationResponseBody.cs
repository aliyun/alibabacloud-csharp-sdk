// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEcGrantRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of authorization relationship query results.</para>
        /// </summary>
        [NameInMap("EcGrantRelations")]
        [Validation(Required=false)]
        public List<DescribeEcGrantRelationResponseBodyEcGrantRelations> EcGrantRelations { get; set; }
        public class DescribeEcGrantRelationResponseBodyEcGrantRelations : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the VPC instance owner in the authorization relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250123456123456</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The time when the VPC-connected instance granted authorization to the VBR instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-02T11:46Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The scope of VBR instances that are granted authorization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>All</b>: The VPC-connected instance is authorized to all VBR instances under the specified region and Alibaba Cloud account.</description></item>
            /// <item><description><b>Specify</b>: The VPC-connected instance is authorized to a specified VBR instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("GrantType")]
            [Validation(Required=false)]
            public string GrantType { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC-connected instance in the authorization relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1brjuegjc88v3u9****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the VPC instance in the authorization relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPCname</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The vRouter ID of the VPC instance in the authorization relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vrt-bp1i0yzgjd8ra05ec****</para>
            /// </summary>
            [NameInMap("InstanceRouterId")]
            [Validation(Required=false)]
            public string InstanceRouterId { get; set; }

            /// <summary>
            /// <para>The region ID of the VPC instance in the authorization relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The status of the authorization relationship. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b>: An authorization relationship exists between the VPC-connected instance and the VBR instance.</description></item>
            /// <item><description><b>Deleted</b>: No authorization relationship exists between the VPC-connected instance and the VBR instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The instance ID of the VBR instance in the authorization relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-m5ex0xf63xk8s5bob****</para>
            /// </summary>
            [NameInMap("VbrInstanceId")]
            [Validation(Required=false)]
            public string VbrInstanceId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the VBR instance owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1210123456123456</para>
            /// </summary>
            [NameInMap("VbrOwnerUid")]
            [Validation(Required=false)]
            public long? VbrOwnerUid { get; set; }

            /// <summary>
            /// <para>The region ID of the VBR instance in the authorization relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VbrRegionNo")]
            [Validation(Required=false)]
            public string VbrRegionNo { get; set; }

        }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
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
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
