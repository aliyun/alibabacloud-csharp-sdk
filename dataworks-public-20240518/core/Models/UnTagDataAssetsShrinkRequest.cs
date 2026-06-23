// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UnTagDataAssetsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The data asset IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataAssetIds")]
        [Validation(Required=false)]
        public string DataAssetIdsShrink { get; set; }

        /// <summary>
        /// <para>The type of the data asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ACS::DataWorks::Table</para>
        /// </description></item>
        /// <item><description><para>ACS::DataWorks::Task</para>
        /// </description></item>
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
        /// <para>The environment of the workspace to which the data asset belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Dev: development environment</para>
        /// </description></item>
        /// <item><description><para>Prod: production environment</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The tags that you want to remove.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
