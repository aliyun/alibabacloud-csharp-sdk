// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class TagDataAssetsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic data lineage backtracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoTraceEnabled")]
        [Validation(Required=false)]
        public bool? AutoTraceEnabled { get; set; }

        /// <summary>
        /// <para>The list of unique IDs of the data assets. You can call the ListDataAssets operation to query the IDs of data assets to which tags can be attached.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataAssetIds")]
        [Validation(Required=false)]
        public string DataAssetIdsShrink { get; set; }

        /// <summary>
        /// <para>The data asset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DataWorks table (ACS::DataWorks::Table)</description></item>
        /// <item><description>DataWorks scheduled task (ACS::DataWorks::Task)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::DataWorks::Task</para>
        /// </summary>
        [NameInMap("DataAssetType")]
        [Validation(Required=false)]
        public string DataAssetType { get; set; }

        /// <summary>
        /// <para>The workspace environment to which the data asset belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Dev (development environment)</description></item>
        /// <item><description>Prod (production environment)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The list of data asset tags to attach.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
