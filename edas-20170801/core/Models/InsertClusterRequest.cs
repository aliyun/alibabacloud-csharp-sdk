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
        /// <item><description>2: Elastic Compute Service (ECS) cluster</description></item>
        /// <item><description>3: self-managed Kubernetes cluster in Enterprise Distributed Application Service (EDAS)</description></item>
        /// <item><description>5: Kubernetes cluster</description></item>
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
        /// <para>The provider of Infrastructure as a Service (IaaS) resources that are used in the cluster.</para>
        /// <para>When you use Alibaba Cloud, set the value to <c>ALIYUN</c>. The value is case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("IaasProvider")]
        [Validation(Required=false)]
        public string IaasProvider { get; set; }

        /// <summary>
        /// <para>The ID of the custom namespace. The ID is in the <c>physical region ID:custom namespace identifier</c> format. Example: <c>cn-hangzhou:test</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:td****</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// <para>The network type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: classic network</description></item>
        /// <item><description>2: virtual private cloud (VPC)</description></item>
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
        /// <para><b>This parameter is deprecated.</b> The CPU overcommit ratio supported by a Docker cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2: 1:2, which means that resources are overcommitted by 1:2.</description></item>
        /// <item><description>4: 1:4, which means that resources are overcommitted by 1:4.</description></item>
        /// <item><description>8: 1:8, which means that resources are overcommitted by 1:8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("OversoldFactor")]
        [Validation(Required=false)]
        public int? OversoldFactor { get; set; }

        /// <summary>
        /// <para>The ID of the VPC. This parameter is required if you set the NetworkMode parameter to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zef6ob8mrlzv8x3q****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
