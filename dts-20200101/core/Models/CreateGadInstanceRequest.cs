// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateGadInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the group. The name must be globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gad-sqlserver-hk-set4</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values: DR (disaster recovery) and GAD (active geo-redundancy).</para>
        /// 
        /// <b>Example:</b>
        /// <para>DR</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values: MySQL, SQL Server, and PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQLServer</para>
        /// </summary>
        [NameInMap("MasterDbEngineType")]
        [Validation(Required=false)]
        public string MasterDbEngineType { get; set; }

        /// <summary>
        /// <para>The ID of the primary ApsaraDB RDS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-j6c685vh0j0y1k***</para>
        /// </summary>
        [NameInMap("MasterDbInstanceId")]
        [Validation(Required=false)]
        public string MasterDbInstanceId { get; set; }

        /// <summary>
        /// <para>The region of the primary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong</para>
        /// </summary>
        [NameInMap("MasterDbInstanceRegion")]
        [Validation(Required=false)]
        public string MasterDbInstanceRegion { get; set; }

        /// <summary>
        /// <para>The zone of the primary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong-b</para>
        /// </summary>
        [NameInMap("MasterDbZoneId")]
        [Validation(Required=false)]
        public string MasterDbZoneId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The region of the primary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek3d****4mxya</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
