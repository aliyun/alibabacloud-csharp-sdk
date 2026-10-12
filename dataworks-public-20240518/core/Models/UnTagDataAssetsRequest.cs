// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UnTagDataAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The unique IDs of the data assets.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataAssetIds")]
        [Validation(Required=false)]
        public List<string> DataAssetIds { get; set; }

        /// <summary>
        /// <para>The type of the data asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Data table (ACS::DataWorks::Table)</description></item>
        /// <item><description>Scheduled task (ACS::DataWorks::Task)</description></item>
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
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The tags to disassociate.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UnTagDataAssetsRequestTags> Tags { get; set; }
        public class UnTagDataAssetsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
