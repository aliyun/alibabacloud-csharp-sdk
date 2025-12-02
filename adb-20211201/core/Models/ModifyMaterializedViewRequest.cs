// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyMaterializedViewRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-******</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database where the materialized view resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myDB</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>Enable the refresh delay alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables alert.</description></item>
        /// <item><description>false: Disables alert.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableDelayAlert")]
        [Validation(Required=false)]
        public bool? EnableDelayAlert { get; set; }

        /// <summary>
        /// <para>Specifies whether to send alerts when the refresh task fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Send alerts.</description></item>
        /// <item><description>false: Alerts disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableFailureAlert")]
        [Validation(Required=false)]
        public bool? EnableFailureAlert { get; set; }

        /// <summary>
        /// <para>The name of the resource group to which the materialized view is bound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>res_1</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Refresh delay tolerance (in minutes).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LatencyTolerance")]
        [Validation(Required=false)]
        public int? LatencyTolerance { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable query rewrite. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables query rewrite.</description></item>
        /// <item><description>false: Disables query rewrite.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("QueryWrite")]
        [Validation(Required=false)]
        public bool? QueryWrite { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the materialized view.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mv_1</para>
        /// </summary>
        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

    }

}
