// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The CPU management policy. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later.</para>
        /// <list type="bullet">
        /// <item><description><c>static</c>: This policy allows pods with specific resource characteristics on the node to be configured with enhanced CPU affinity and exclusivity.</description></item>
        /// <item><description><c>none</c>: The default CPU affinity is used.</description></item>
        /// </list>
        /// <para>Default value: <c>none</c>.</para>
        /// <remarks>
        /// <para> This parameter is not supported if you specify the <c>nodepool_id</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to store container data and images on data disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: stores container data and images on data disks.</description></item>
        /// <item><description><c>false</c>: does not store container data or images on data disks.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>How a data disk is mounted:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS instances are already mounted with data disks and the file system of the last data disk is not initialized, the system automatically formats this data disk to ext4 and mounts it to /var/lib/docker and /var/lib/kubelet.</description></item>
        /// <item><description>If no data disk is attached to the ECS instances, the system does not purchase a new data disk.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you choose to store container data and images on data disks and a data disk is already mounted to the ECS instance, the original data on this data disk will be cleared. You can back up the disk to avoid data loss.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>The ID of the custom image. If you do not set this parameter, the default system image is used.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify a custom image, the custom image is used to deploy the operating systems on the system disks of the nodes.</para>
        /// </description></item>
        /// <item><description><para>This parameter is not supported after you specify <c>nodepool_id</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_2_1903_x64_20G_alibase_20200529.vhd</para>
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ECS instances to be added.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>Specifies whether the nodes that you want to add are Edge Node Service (ENS) nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The nodes that you want to add are ENS nodes.</description></item>
        /// <item><description><c>false</c>: The nodes that you want to add are not ENS nodes.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <remarks>
        /// <para> If the nodes that you want to add are ENS nodes, you must set this parameter to <c>true</c>. This allows you to identify these nodes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_edge_worker")]
        [Validation(Required=false)]
        public bool? IsEdgeWorker { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the instance name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains the instance name.</description></item>
        /// <item><description><c>false</c>: does not retain the instance name.</description></item>
        /// </list>
        /// <para>Default value: <c>true</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        /// <summary>
        /// <para>The name of the key pair that is used to log on to the ECS instances. You must set key_pair or <c>login_password</c>.</para>
        /// <remarks>
        /// <para> This parameter is not supported if you specify the <c>nodepool_id</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>secrity-key</para>
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// <para>The node pool ID. If you do not set this parameter, the nodes are added to the default node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np615c0e0966124216a0412e10afe0****</para>
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// <para>The SSH logon password that is used to log on to the ECS instances. You must set login_password or <c>key_pair</c>. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. It cannot contain backslashes (\\) or double quotation marks (&quot;).</para>
        /// <para>For security considerations, the password is encrypted during data transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello1234</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>A list of ApsaraDB RDS instances.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// <para>The container runtime.</para>
        /// <remarks>
        /// <para> This parameter is not supported if you specify the <c>nodepool_id</c> parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// <para>The labels that you want to add to nodes. You must add labels based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>Each label is a case-sensitive key-value pair. You can add up to 20 labels.</description></item>
        /// <item><description>A key must be unique and cannot exceed 64 characters in length. A value can be empty and cannot exceed 128 characters in length. Keys and values cannot start with <c>aliyun</c>, <c>acs:</c>, <c>https://</c>, or <c>http://</c>. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is not supported if you specify the <c>nodepool_id</c> parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>User-defined data. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate user data</a>.</para>
        /// <remarks>
        /// <para> This parameter is not supported if you specify the <c>nodepool_id</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFDSyEi</para>
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
