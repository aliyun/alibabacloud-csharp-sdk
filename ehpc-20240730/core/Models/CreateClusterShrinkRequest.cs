// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateClusterShrinkRequest : TeaModel {
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public string AdditionalPackagesShrink { get; set; }

        [NameInMap("Addons")]
        [Validation(Required=false)]
        public string AddonsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.1.0</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ClusterCategory")]
        [Validation(Required=false)]
        public string ClusterCategory { get; set; }

        [NameInMap("ClusterCredentials")]
        [Validation(Required=false)]
        public string ClusterCredentialsShrink { get; set; }

        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public string ClusterCustomConfigurationShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>slurm22.05.8-cluster-20240718</para>
        /// </summary>
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Integrated</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>slurm22.05.8-cluster-20240718</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-f8za5p0mwzgdu3wgx****</para>
        /// </summary>
        [NameInMap("ClusterVSwitchId")]
        [Validation(Required=false)]
        public string ClusterVSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-m5efjevmclc0xdmys****</para>
        /// </summary>
        [NameInMap("ClusterVpcId")]
        [Validation(Required=false)]
        public string ClusterVpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsEnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        [NameInMap("Manager")]
        [Validation(Required=false)]
        public string ManagerShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxCoreCount")]
        [Validation(Required=false)]
        public int? MaxCoreCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public int? MaxCount { get; set; }

        [NameInMap("Queues")]
        [Validation(Required=false)]
        public string QueuesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sg-bp13n61xsydodfyg****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public string SharedStoragesShrink { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
