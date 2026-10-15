// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetListRequest : TeaModel {
        /// <summary>
        /// <para>The directory ID.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is specified, all datasets in the specified directory are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>schemaad8aad00-9c55-4984-a767-b4e0ec60****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The keyword used to search for dataset names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number of the dataset list.</para>
        /// <list type="bullet">
        /// <item><description>Minimum value: 1</description></item>
        /// <item><description>Default value: 1</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of rows per page for a paged query.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 10</description></item>
        /// <item><description>Maximum value: 1000</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to recursively include datasets in subdirectories. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Returns datasets in all recursive subdirectories under the directory specified by directoryId.</description></item>
        /// <item><description>false: Returns only datasets in the directory specified by directoryId, excluding subdirectories.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithChildren")]
        [Validation(Required=false)]
        public bool? WithChildren { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
