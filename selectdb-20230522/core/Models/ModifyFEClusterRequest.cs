// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class ModifyFEClusterRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The specifications of the FE cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>selectdb_fe.xlarge16: 4 cores and 16 GB.</para>
        /// </description></item>
        /// <item><description><para>selectdb_fe.2xlarge16: 8 cores and 32 GB.</para>
        /// </description></item>
        /// <item><description><para>selectdb_fe.4xlarge16: 16 cores and 64 GB.</para>
        /// </description></item>
        /// <item><description><para>selectdb_fe.8xlarge16: 32 cores and 128 GB.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb_fe.2xlarge16</para>
        /// </summary>
        [NameInMap("FEClassCode")]
        [Validation(Required=false)]
        public string FEClassCode { get; set; }

        /// <summary>
        /// <para>The FE cluster ID. Default value: {instance ID}-fe.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****-fe</para>
        /// </summary>
        [NameInMap("FEClusterId")]
        [Validation(Required=false)]
        public string FEClusterId { get; set; }

        /// <summary>
        /// <para>The number of nodes in the FE cluster. The value must be an odd number. Valid values for locally redundant instances: 1 to 11. Valid values for zone-redundant instances: 3 to 11.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("FENodeCount")]
        [Validation(Required=false)]
        public string FENodeCount { get; set; }

        /// <summary>
        /// <para>The product ID. Default value: selectdb.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
