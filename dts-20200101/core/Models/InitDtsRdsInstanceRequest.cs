// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class InitDtsRdsInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the synchronization node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtszvxa4qmot6p****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The instance ID of the CEN instance. This parameter is required if the unit node is a self-managed MySQL database connected through CEN.</para>
        /// <remarks>
        /// <para>You must specify either this parameter or the ApsaraDB RDS for MySQL-related parameters (<b>EndpointRegion</b> and <b>EndpointInstanceId</b>).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cen-9kqshqum*******</para>
        /// </summary>
        [NameInMap("EndpointCenId")]
        [Validation(Required=false)]
        public string EndpointCenId { get; set; }

        /// <summary>
        /// <para>The instance ID of the ApsaraDB RDS for MySQL instance. This parameter is required if the unit node is an ApsaraDB RDS for MySQL instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must also specify the <b>EndpointRegion</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must specify either this parameter or <b>EndpointCenId</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1162kryivb8****</para>
        /// </summary>
        [NameInMap("EndpointInstanceId")]
        [Validation(Required=false)]
        public string EndpointInstanceId { get; set; }

        /// <summary>
        /// <para>The instance type of the unit node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS for MySQL instance.</description></item>
        /// <item><description><b>CEN</b>: self-managed MySQL database connected through CEN.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("EndpointInstanceType")]
        [Validation(Required=false)]
        public string EndpointInstanceType { get; set; }

        /// <summary>
        /// <para>The region in which the ApsaraDB RDS for MySQL instance resides. This parameter is required if the unit node is an ApsaraDB RDS for MySQL instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must also specify the <b>EndpointInstanceId</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must specify either this parameter or <b>EndpointCenId</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("EndpointRegion")]
        [Validation(Required=false)]
        public string EndpointRegion { get; set; }

        /// <summary>
        /// <para>The region in which the active geo-redundancy database cluster resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. This is a global parameter and does not need to be specified for this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>资源组ID，全局参数，当前API无需传入。</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
