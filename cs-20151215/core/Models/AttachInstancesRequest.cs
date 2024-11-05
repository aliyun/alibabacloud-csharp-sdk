// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The CPU management policy of the node. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later:</para>
        /// <list type="bullet">
        /// <item><description><c>static</c>: allows pods with specific resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.</description></item>
        /// <item><description><c>none</c>: specifies that the default CPU affinity is used.</description></item>
        /// </list>
        /// <para>Default value: <c>none</c>.</para>
        /// <remarks>
        /// <para> This parameter is not supported if you specify <c>nodepool_id</c>.</para>
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
        /// <para>How data disks are attached:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS instance is already attached with data disks and the file system of the last data disk is not initialized, the system automatically formats this data disk to ext4. Then, the system uses the disk to store the data in the /var/lib/docker and /var/lib/kubelet directories.</description></item>
        /// <item><description>If no data disk is attached to the ECS instance, the system does not purchase a new data disk.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you choose to store container data and images on data disks and a data disk is already attached to the ECS instance, the original data on this data disk is cleared. You can back up the disk to prevent data loss.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>The custom image ID. If you do not specify this parameter, the default system image is used.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify a custom image, the custom image is used to deploy the operating system on the system disk of the node.</para>
        /// </description></item>
        /// <item><description><para>This parameter is not supported if you specify <c>nodepool_id</c>.</para>
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
        /// <para>The ECS instances that you want to add.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>Specifies whether the node that you want to add is an Edge Node Service (ENS) node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: the node that you want to add is an ENS node.</description></item>
        /// <item><description><c>false</c>: the node that you want to add is not an ENS node.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <remarks>
        /// <para> If the node that you want to add is an ENS node, you must set the value to <c>true</c>. This allows you to identify the node.</para>
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
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        /// <summary>
        /// <para>The name of the key pair used to log on to the ECS instances. You must specify this parameter or <c>login_password</c>.</para>
        /// <remarks>
        /// <para> This parameter is not supported if you specify <c>nodepool_id</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>secrity-key</para>
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// <para>The ID of the node pool to which the node is added. If you do not specify this parameter, the node is added to the default node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np615c0e0966124216a0412e10afe0****</para>
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// <para>The SSH logon password used to log on to the ECS instances. You must specify this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The password cannot contain backslashes (\\) or double quotation marks (&quot;).</para>
        /// <para>The password is encrypted during data transfer to ensure security.</para>
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
        /// <para> This parameter is not supported if you specify <c>nodepool_id</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// <para>The labels that you want to add to the node. When you add labels to a node, the following rules apply:</para>
        /// <list type="bullet">
        /// <item><description>A label is a case-sensitive key-value pair. You can add up to 20 labels.</description></item>
        /// <item><description>The key must be unique and cannot exceed 64 characters in length. The value can be empty and cannot exceed 128 characters in length. Keys and values cannot start with <c>aliyun</c>, <c>acs:</c>, <c>https://</c>, or <c>http://</c>. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is not supported if you specify <c>nodepool_id</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The user-defined data on the node. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate user-defined data</a>.</para>
        /// <remarks>
        /// <para> This parameter is not supported if you specify <c>nodepool_id</c>.</para>
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
