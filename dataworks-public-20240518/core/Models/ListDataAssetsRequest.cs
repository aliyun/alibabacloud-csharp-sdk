// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The data asset IDs.</para>
        /// </summary>
        [NameInMap("DataAssetIds")]
        [Validation(Required=false)]
        public List<string> DataAssetIds { get; set; }

        /// <summary>
        /// <para>The type of the data asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACS::DataWorks::Table</description></item>
        /// <item><description>ACS::DataWorks::Task</description></item>
        /// </list>
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
        /// <item><description>Dev: development environment</description></item>
        /// <item><description>Prod: production environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The tags that are added to data assets. This parameter specifies a filter condition.</para>
        /// <list type="bullet">
        /// <item><description>You can specify multiple tags, which are in the logical OR relation. For example, you can query the data assets that contain one of the following tags: <c>[&quot;key1:v1&quot;, &quot;key2:v1&quot;, &quot;key3:v1&quot;]</c>.</description></item>
        /// <item><description>If you do not configure this parameter, tag-based filtering is not performed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListDataAssetsRequestTags> Tags { get; set; }
        public class ListDataAssetsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag key can be up to 64 characters in length and can contain letters, digits, and the following characters: <c>-@#*&lt;&gt;|[]()+=&amp;%$!~</c>. It cannot start with <c>dw:</c>.</para>
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
