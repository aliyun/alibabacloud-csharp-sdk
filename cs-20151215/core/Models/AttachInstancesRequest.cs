// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The CPU management policy for the node. The following two policies are supported when the cluster version is 1.12.6 or later:</para>
        /// <list type="bullet">
        /// <item><description><c>static</c>: allows you to enhance CPU affinity and exclusivity for pods with specific resource characteristics on the node.</description></item>
        /// <item><description><c>none</c>: uses the existing default CPU affinity policy.</description></item>
        /// </list>
        /// <para>Default value: <c>none</c>.</para>
        /// <remarks>
        /// <para>This parameter is not supported if nodepool_id is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to store container data and images on a data cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: stores container data and images on a data cloud disk.</description></item>
        /// <item><description><c>false</c>: does not store container data and images on a data cloud disk.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>Data cloud disk mounting rules:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS instance has data cloud disks attached and the file system of the last data cloud disk is not initialized, the system automatically formats the data cloud disk to EXT4 to store the /var/lib/docker and /var/lib/kubelet directories, which are the default data directories for the Docker container runtime and kubelet component.</description></item>
        /// <item><description>If the ECS instance does not have data cloud disks attached, no new data cloud disk is attached.<remarks>
        /// <para>If you choose to store data on a data cloud disk and the ECS instance already has data cloud disks attached, the existing data on the data cloud disks will be lost. Back up your data first.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>The custom image ID.</para>
        /// <list type="bullet">
        /// <item><description>If you specify a custom image ID, the system cloud disk image of the instance is replaced with the custom image.</description></item>
        /// <item><description>If you do not specify this parameter, the default system image is used.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not supported if nodepool_id is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_2_1903_x64_20G_alibase_20200529.vhd</para>
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The list of ECS instances to be added.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>Specifies whether the node to be added is an edge node, namely an ENS node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The node to be added is an edge node.</description></item>
        /// <item><description><c>false</c>: The node to be added is not an edge node.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <remarks>
        /// <para>If the node is an edge node, you must set this parameter to <c>true</c> to identify the node type as an ENS node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_edge_worker")]
        [Validation(Required=false)]
        public bool? IsEdgeWorker { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the original instance name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains the instance name.</description></item>
        /// <item><description><c>false</c>: does not retain the instance name.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        /// <summary>
        /// <para>The name of the key pair for the instances to be added. You can specify either the key_pair or password parameter, or leave both empty.</para>
        /// <remarks>
        /// <para>This parameter is not supported if nodepool_id is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>security-key</para>
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// <para>The node pool ID. If you do not specify this parameter, the node is added to the default node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np615c0e0966124216a0412e10afe0****</para>
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// <para>The SSH logon password for the instances to be added. You can specify either the key_pair or password parameter, or leave both empty.</para>
        /// <para>The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The password must be 8 to 30 characters in length.</description></item>
        /// <item><description>The password must contain uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>The password cannot contain backslashes (\) or double quotation marks (&quot;).</description></item>
        /// </list>
        /// <para>For security purposes, the password is encrypted during transmission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello1234</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The list of ApsaraDB RDS instances.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// <para>The container runtime.</para>
        /// <remarks>
        /// <para>This parameter is not supported if nodepool_id is specified.</para>
        /// </remarks>
        /// <para>name: the name of the container runtime. ACK supports the following three container runtimes:</para>
        /// <list type="bullet">
        /// <item><description>containerd: recommended. Supported by all cluster versions.</description></item>
        /// <item><description>Sandboxed-Container.runv: sandboxed container. Provides higher isolation. Supported by clusters runtime version 1.24 and earlier.</description></item>
        /// <item><description>docker: supported by clusters runtime version 1.22 and earlier.</description></item>
        /// </list>
        /// <para>Default value: containerd.</para>
        /// <para>containerd: the version of the container runtime. The default value is the latest version.</para>
        /// <para>For more information about the changes to the sandboxed container runtime, see <a href="https://help.aliyun.com/document_detail/160312.html">Sandboxed container runtime release notes</a>.</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// <para>The node labels. Label definition rules:</para>
        /// <list type="bullet">
        /// <item><description>A label is a case-sensitive key-value pair. You can configure up to 20 labels.</description></item>
        /// <item><description>Label keys must be unique and can be up to 64 characters in length.</description></item>
        /// <item><description>Label values can be empty and can be up to 128 characters in length.</description></item>
        /// <item><description>Label keys and values cannot start with <c>aliyun</c>, <c>acs:</c>, <c>https://</c>, or <c>http://</c>.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</para>
        /// <remarks>
        /// <para>This parameter is not supported if nodepool_id is specified.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The custom data for the node. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate instance user data</a>.</para>
        /// <remarks>
        /// <para>This parameter is not supported if nodepool_id is specified.</para>
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
