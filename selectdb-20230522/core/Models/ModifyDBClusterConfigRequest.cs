// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class ModifyDBClusterConfigRequest : TeaModel {
        /// <summary>
        /// <para>Configuration file to modify. For compute clusters, it is fixed as be.conf. For fe clusters, it is fixed as fe.conf.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>be.conf</para>
        /// </summary>
        [NameInMap("ConfigKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// <para>Cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213c8*****-be</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213c8*****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Whether to operate cluster nodes in parallel</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ParallelOperation")]
        [Validation(Required=false)]
        public bool? ParallelOperation { get; set; }

        /// <summary>
        /// <para>JSON string of parameters and parameter values.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;param1_name&quot;:&quot;param1_value&quot;,&quot;param2_name&quot;:&quot;param2_value&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Upgrade method. If not specified, the upgrade will be performed immediately. If set to 1, the upgrade will be performed during the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

    }

}
