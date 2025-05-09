// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataSourceSharedRuleRequest : TeaModel {
        /// <summary>
        /// <para>The data source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>144544</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>Share data sources to the target project environment, including</para>
        /// <list type="bullet">
        /// <item><description>Dev (Development Environment)</description></item>
        /// <item><description>Prod (production environment)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dev</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The user with which you want to share the data source. If you do not configure this parameter, the data source is shared to an entire workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1107550004253538</para>
        /// </summary>
        [NameInMap("SharedUser")]
        [Validation(Required=false)]
        public string SharedUser { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which you want to share the data source. You cannot share the data source to the workspace with which the data source is associated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>106560</para>
        /// </summary>
        [NameInMap("TargetProjectId")]
        [Validation(Required=false)]
        public long? TargetProjectId { get; set; }

    }

}
