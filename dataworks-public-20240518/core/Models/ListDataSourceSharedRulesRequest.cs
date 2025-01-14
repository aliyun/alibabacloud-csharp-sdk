// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataSourceSharedRulesRequest : TeaModel {
        /// <summary>
        /// <para>The data source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the data source is shared. You cannot share the data source to the workspace with which the data source is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TargetProjectId")]
        [Validation(Required=false)]
        public long? TargetProjectId { get; set; }

    }

}
