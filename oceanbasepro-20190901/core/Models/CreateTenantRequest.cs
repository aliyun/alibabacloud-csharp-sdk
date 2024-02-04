// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateTenantRequest : TeaModel {
        /// <summary>
        /// The character set.    
        /// For more information, see DescribeCharset.
        /// </summary>
        [NameInMap("Charset")]
        [Validation(Required=false)]
        public string Charset { get; set; }

        /// <summary>
        /// The number of CPU cores of the tenant.   
        /// 
        /// > <br>The CPU specification of a single tenant cannot exceed that of the corresponding cluster. <br>For example, if the specification of the cluster is 14 CPU cores and 70 GB of memory, the CPU specification of the tenant cannot exceed 14 cores.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// The description of the database.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The size of the log disk allocated to the tenant, in GB.
        /// </summary>
        [NameInMap("LogDisk")]
        [Validation(Required=false)]
        public long? LogDisk { get; set; }

        /// <summary>
        /// The memory size of the tenant, in GB.   
        /// 
        /// > <br>The memory size of a single tenant cannot exceed that of the corresponding cluster. <br>For example, if the specification of the cluster is 14 CPU cores and 70 GB of memory, the memory size of the tenant cannot exceed 70 GB.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// The primary zone of the tenant.    
        /// It is one of the zones in which the cluster is deployed.
        /// </summary>
        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        /// <summary>
        /// Specifies to create a read-only zone. Separate the names of multiple zones with commas (,).
        /// ><notice><br>At present, this parameter is unavailable.></notice>
        /// </summary>
        [NameInMap("ReadOnlyZoneList")]
        [Validation(Required=false)]
        public string ReadOnlyZoneList { get; set; }

        /// <summary>
        /// The tenant mode.    
        /// Valid values: Oracle and MySQL.   
        /// For more information, see [DescribeInstanceTenantModes](~~410354~~).
        /// </summary>
        [NameInMap("TenantMode")]
        [Validation(Required=false)]
        public string TenantMode { get; set; }

        /// <summary>
        /// The name of the tenant.    
        /// It must start with a letter or an underscore (_), and contain 2 to 20 characters, which can be uppercase letters, lowercase letters, digits, and underscores (_).  It cannot be set to sys.
        /// </summary>
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// The time zone of the tenant. For more information, see [DescribeTimeZones](https://www.alibabacloud.com/help/en/apsaradb-for-oceanbase/latest/api-oceanbasepro-2019-09-01-describetimezones).
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// The number of resource distribution nodes in the tenant.    
        /// The number is determined by the deployment mode of the cluster. If the cluster is deployed in 2-2-2 mode, the maximum number of resource distribution nodes is 2.
        /// </summary>
        [NameInMap("UnitNum")]
        [Validation(Required=false)]
        public int? UnitNum { get; set; }

        /// <summary>
        /// The ID of the vSwitch.    
        /// If no suitable vSwitch is available, create a vSwitch as prompted.   
        /// For more information, see Use a vSwitch.
        /// </summary>
        [NameInMap("UserVSwitchId")]
        [Validation(Required=false)]
        public string UserVSwitchId { get; set; }

        /// <summary>
        /// The ID of the VPC.   
        ///  If no suitable VPC is available, create a VPC as prompted.   
        /// For more information, see "What is a VPC".
        /// </summary>
        [NameInMap("UserVpcId")]
        [Validation(Required=false)]
        public string UserVpcId { get; set; }

    }

}
