// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of tenants.</para>
        /// </summary>
        [NameInMap("Tenants")]
        [Validation(Required=false)]
        public List<DescribeTenantsResponseBodyTenants> Tenants { get; set; }
        public class DescribeTenantsResponseBodyTenants : TeaModel {
            /// <summary>
            /// <para>The character set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>utf8mb4</para>
            /// </summary>
            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            /// <summary>
            /// <para>The collation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>utf8mb4_general_ci</para>
            /// </summary>
            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

            /// <summary>
            /// <para>The total number of CPU cores of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The time when the tenant was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-17 15:52:17.0</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The data replica distribution mode of the tenant.   </para>
            /// <list type="bullet">
            /// <item><description>For the high availability version, N-N-N indicates the three-zone mode, and N-N indicates the dual-zone or single-zone mode.</description></item>
            /// <item><description>For the basic version, N indicates the single-zone mode.</description></item>
            /// </list>
            /// <remarks>
            /// <para><br>N represents the number of nodes in a single zone.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1-1-1</para>
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// <para>The deployment type of the tenant. <br></para>
            /// <list type="bullet">
            /// <item><description>multiple: multi-IDC deployment</description></item>
            /// <item><description>single: single-IDC deployment</description></item>
            /// <item><description>dual: dual-IDC deployment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>multiple</para>
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// <para>The description of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayCore business database</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether read-only replicas are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableReadOnlyReplica")]
            [Validation(Required=false)]
            public bool? EnableReadOnlyReplica { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public int? Iops { get; set; }

            /// <summary>
            /// <para>The total memory size of the tenant, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <para>The parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>express_oltp</para>
            /// </summary>
            [NameInMap("ParameterTemplate")]
            [Validation(Required=false)]
            public string ParameterTemplate { get; set; }

            /// <summary>
            /// <para>The primary zone of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            /// <summary>
            /// <para>The status of the tenant.  <br></para>
            /// <list type="bullet">
            /// <item><description>PENDING_CREATE: The tenant is being created.</description></item>
            /// <item><description>RESTORE: The tenant is being recovered.</description></item>
            /// <item><description>ONLINE: The tenant is running.</description></item>
            /// <item><description>SPEC_MODIFYING: The specification of the tenant is being modified.
            /// ALLOCATING_INTERNET_ADDRESS: An Internet address is being allocated.
            /// PENDING_OFFLINE_INTERNET_ADDRESS: The Internet address is being disabled.</description></item>
            /// <item><description>PRIMARY_ZONE_MODIFYING: The tenant is switching to a new primary zone.</description></item>
            /// <item><description>PARAMETER_MODIFYING: Parameters are being modified.</description></item>
            /// <item><description>WHITE_LIST_MODIFYING: The whitelist is being modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t33h8y08k****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The tenant mode.<br>Valid values:<br>Oracle
            /// MySQL</para>
            /// 
            /// <b>Example:</b>
            /// <para>Oracle</para>
            /// </summary>
            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

            /// <summary>
            /// <para>The name of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pay_online</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The number of CPU cores in each resource unit of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("UnitCpu")]
            [Validation(Required=false)]
            public int? UnitCpu { get; set; }

            /// <summary>
            /// <para>The memory size of each resource unit of the tenant, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnitMem")]
            [Validation(Required=false)]
            public int? UnitMem { get; set; }

            /// <summary>
            /// <para>The number of resource units in the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public int? UnitNum { get; set; }

            /// <summary>
            /// <para>The number of used disks of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedDiskSize")]
            [Validation(Required=false)]
            public double? UsedDiskSize { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.   <br>If no suitable VPC is available, create a VPC as prompted. For more information, see &quot;What is a VPC&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1d2q3mhg9i23ofi****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The total number of tenants in the specified OceanBase cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
