// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class InitDtsRdsInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtszvxa4qmot6p****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>If the node is a self-managed MySQL database that is connected over CEN, you must specify the ID of the CEN instance.</para>
        /// <remarks>
        /// <para>You must specify the <b>EndpointRegion</b> and <b>EndpointInstanceId</b> parameters or the EndpointCenId parameter based on the type of the node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cen-9kqshqum*******</para>
        /// </summary>
        [NameInMap("EndpointCenId")]
        [Validation(Required=false)]
        public string EndpointCenId { get; set; }

        /// <summary>
        /// <para>If the node is an ApsaraDB RDS for MySQL instance, you must specify the ID of the ApsaraDB RDS for MySQL instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must also specify the <b>EndpointRegion</b> parameter.</description></item>
        /// <item><description>You must specify the EndpointInstanceId parameter or the <b>EndpointCenId</b> parameter based on the type of the node.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1162kryivb8****</para>
        /// </summary>
        [NameInMap("EndpointInstanceId")]
        [Validation(Required=false)]
        public string EndpointInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: an ApsaraDB RDS for MySQL instance</description></item>
        /// <item><description><b>CEN</b>: a self-managed MySQL database that is connected over CEN</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("EndpointInstanceType")]
        [Validation(Required=false)]
        public string EndpointInstanceType { get; set; }

        /// <summary>
        /// <para>If the node is an ApsaraDB RDS for MySQL instance, you must specify the region in which the ApsaraDB RDS for MySQL instance resides.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must also specify the <b>EndpointInstanceId</b> parameter.</description></item>
        /// <item><description>You must specify the EndpointRegion parameter or the <b>EndpointCenId</b> parameter based on the type of the node.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("EndpointRegion")]
        [Validation(Required=false)]
        public string EndpointRegion { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the active geo-redundancy database cluster resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
