// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertClusterRequest : TeaModel {
        /// <summary>
        /// <para>The name of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****_product_test2</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2: ECS cluster.</description></item>
        /// <item><description>3: EDAS built-in Kubernetes cluster.</description></item>
        /// <item><description>5: Kubernetes cluster.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public int? ClusterType { get; set; }

        /// <summary>
        /// <para>The IaaS resource provider.</para>
        /// <para><note>When you select Alibaba Cloud, you must use uppercase Pinyin, such as <c>ALIYUN</c>.</note></para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("IaasProvider")]
        [Validation(Required=false)]
        public string IaasProvider { get; set; }

        /// <summary>
        /// <para>The region ID of the custom namespace. Format: <c>physical region:custom namespace identifier</c>, such as <c>cn-hangzhou:test</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:td****</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Classic network.</description></item>
        /// <item><description>2: VPC.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NetworkMode")]
        [Validation(Required=false)]
        public int? NetworkMode { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The CPU overselling ratio for Docker clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2: 1:2 ratio.</description></item>
        /// <item><description>4: 1:4 ratio.</description></item>
        /// <item><description>8: 1:8 ratio.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("OversoldFactor")]
        [Validation(Required=false)]
        public int? OversoldFactor { get; set; }

        /// <summary>
        /// <para>The ID of the VPC. This parameter is required if the network type is set to VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zef6ob8mrlzv8x3q****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
