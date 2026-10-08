// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeResourceDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The storage space occupied by data backups, excluding archived backups. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8139046912</para>
        /// </summary>
        [NameInMap("BackupDataSize")]
        [Validation(Required=false)]
        public long? BackupDataSize { get; set; }

        /// <summary>
        /// <para>The size of backup logs. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21183797</para>
        /// </summary>
        [NameInMap("BackupLogSize")]
        [Validation(Required=false)]
        public long? BackupLogSize { get; set; }

        /// <summary>
        /// <para>The backup size. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53002759</para>
        /// </summary>
        [NameInMap("BackupSize")]
        [Validation(Required=false)]
        public long? BackupSize { get; set; }

        /// <summary>
        /// <para>The disk capacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("DbInstanceStorage")]
        [Validation(Required=false)]
        public long? DbInstanceStorage { get; set; }

        /// <summary>
        /// <para>The name of the database proxy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mr-n1m1wjrylfolvrt67s</para>
        /// </summary>
        [NameInMap("DbProxyInstanceName")]
        [Validation(Required=false)]
        public string DbProxyInstanceName { get; set; }

        /// <summary>
        /// <para>The used storage space, which consists of the space occupied by data files and log files. Unit: bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4871684096</para>
        /// </summary>
        [NameInMap("DiskUsed")]
        [Validation(Required=false)]
        public long? DiskUsed { get; set; }

        /// <summary>
        /// <para>The instance storage type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("InstanceStorageType")]
        [Validation(Required=false)]
        public string InstanceStorageType { get; set; }

        /// <summary>
        /// <para>The RDS whitelist group specifications.</para>
        /// </summary>
        [NameInMap("RdsEcsSecurityGroupRel")]
        [Validation(Required=false)]
        public List<DescribeResourceDetailsResponseBodyRdsEcsSecurityGroupRel> RdsEcsSecurityGroupRel { get; set; }
        public class DescribeResourceDetailsResponseBodyRdsEcsSecurityGroupRel : TeaModel {
            /// <summary>
            /// <para>The security group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_switch</para>
            /// </summary>
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA815761-F7AC-5CFE-A1AC-709D6A00B58A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmv3h25bj7yhq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/43185.html">IP whitelist</a> of the instance. Separate multiple entries with commas (,). Each entry must be unique. A maximum of 1,000 entries are supported. The following two formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>IP address format, such as 10.10.XX.XX.</description></item>
        /// <item><description>CIDR format, such as 10.10.XX.XX/24, where 24 indicates the length of the prefix in the IP address. The prefix length ranges from 1 to 32.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, the whitelist information of the default group of the original instance is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.1.14,172.16.1.13,172.16.1.44,172.16.1.43,172.16.1.74,172.16.1.73</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <remarks>
        /// <para>The vSwitch must belong to the same zone as the ApsaraDB RDS instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zelwi1jd271p670lzl8h</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>VPC ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-wz9rbibex7v0lxbeyo6at</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
