// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateTenantShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The character set.<br>For more information, see <a href="https://www.alibabacloud.com/help/en/apsaradb-for-oceanbase/latest/api-oceanbasepro-2019-09-01-describecharset">DescribeCharset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8mb4</para>
        /// </summary>
        [NameInMap("Charset")]
        [Validation(Required=false)]
        public string Charset { get; set; }

        /// <summary>
        /// <para>The number of CPU cores of the tenant.   </para>
        /// <remarks>
        /// <para><br>The CPU specification of a single tenant cannot exceed that of the corresponding cluster. <br>For example, if the specification of the cluster is 14 CPU cores and 70 GB of memory, the CPU specification of the tenant cannot exceed 14 cores.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The initialization parameters.</para>
        /// </summary>
        [NameInMap("CreateParams")]
        [Validation(Required=false)]
        public string CreateParamsShrink { get; set; }

        /// <summary>
        /// <para>The description of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test database</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The size of the log disk allocated to the tenant, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("LogDisk")]
        [Validation(Required=false)]
        public long? LogDisk { get; set; }

        /// <summary>
        /// <para>The memory size of the tenant, in GB.   </para>
        /// <remarks>
        /// <para><br>The memory size of a single tenant cannot exceed that of the corresponding cluster. <br>For example, if the specification of the cluster is 14 CPU cores and 70 GB of memory, the memory size of the tenant cannot exceed 70 GB.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The primary zone of the tenant.<br>It is one of the zones in which the cluster is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        /// <summary>
        /// <para>Specifies to create a read-only zone. Separate the names of multiple zones with commas (,).</para>
        /// <remarks>
        /// <para>Notice: <br>At present, this parameter is unavailable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-g-ro,cn-shanghai-h-ro</para>
        /// </summary>
        [NameInMap("ReadOnlyZoneList")]
        [Validation(Required=false)]
        public string ReadOnlyZoneList { get; set; }

        /// <summary>
        /// <para>The tenant mode.<br>Valid values: Oracle and MySQL.<br>For more information, see <a href="https://www.alibabacloud.com/help/en/apsaradb-for-oceanbase/latest/api-oceanbasepro-2019-09-01-describeinstancetenantmodes">DescribeInstanceTenantModes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Oracle</para>
        /// </summary>
        [NameInMap("TenantMode")]
        [Validation(Required=false)]
        public string TenantMode { get; set; }

        /// <summary>
        /// <para>The name of the tenant.<br>It must start with a letter or an underscore (<em>), and contain 2 to 20 characters, which can be uppercase letters, lowercase letters, digits, and underscores (</em>).  It cannot be set to sys.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pay_online</para>
        /// </summary>
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// <para>The time zone of the tenant. For more information, see <a href="https://www.alibabacloud.com/help/en/apsaradb-for-oceanbase/latest/api-oceanbasepro-2019-09-01-describetimezones">DescribeTimeZones</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>The number of resource distribution nodes in the tenant.<br>The number is determined by the deployment mode of the cluster. If the cluster is deployed in 2-2-2 mode, the maximum number of resource distribution nodes is 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UnitNum")]
        [Validation(Required=false)]
        public int? UnitNum { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.<br>If no suitable vSwitch is available, create a vSwitch as prompted.<br>For more information, see Use a vSwitch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp11k1aypnzu1l3whi****</para>
        /// </summary>
        [NameInMap("UserVSwitchId")]
        [Validation(Required=false)]
        public string UserVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.<br> If no suitable VPC is available, create a VPC as prompted.<br>For more information, see &quot;What is a VPC&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1d2q3mhg9i23ofi****</para>
        /// </summary>
        [NameInMap("UserVpcId")]
        [Validation(Required=false)]
        public string UserVpcId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-********</para>
        /// </summary>
        [NameInMap("UserVpcOwnerId")]
        [Validation(Required=false)]
        public string UserVpcOwnerId { get; set; }

    }

}
