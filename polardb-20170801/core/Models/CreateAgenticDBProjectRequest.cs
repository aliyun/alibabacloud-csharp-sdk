// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAgenticDBProjectRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AgenticDB cluster. The ID must have the pagc- prefix. You can obtain the ID after calling CreateDBCluster and specifying AgenticDbType=dedicated and ServerlessType=AgileServerless. A regular cluster ID with the pc- prefix is not supported. If an invalid ID is provided, the InvalidDBClusterId.NotFound error may be returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pagc-bp1abcdef1234567</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the default branch. Default value: main.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("DefaultBranchName")]
        [Validation(Required=false)]
        public string DefaultBranchName { get; set; }

        /// <summary>
        /// <para>The description of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production analytics database</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The retention period of historical data, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>604800</para>
        /// </summary>
        [NameInMap("HistoryRetentionSeconds")]
        [Validation(Required=false)]
        public long? HistoryRetentionSeconds { get; set; }

        /// <summary>
        /// <para>The name of the project. The name must be unique within the same tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analytics-prod</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can obtain the ID from the response after calling CreateAgenticDBTenant to create a tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-4b83e0da66674951</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the zone where the project storage resides. The zone must be the same as the zone where the cluster compute resides. If this parameter is not specified, the zone where the cluster compute resides is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-l</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
