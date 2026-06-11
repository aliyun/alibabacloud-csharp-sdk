// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the folder.</para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, all datasets in the folder are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>schemaad8aad00-9c55-4984-a767-b4e0ec60****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The keyword used to search for datasets by name.</para>
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
        /// <item><description><para>Start value: 1</para>
        /// </description></item>
        /// <item><description><para>Default value: 1</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: 10</para>
        /// </description></item>
        /// <item><description><para>Maximum value: 1000</para>
        /// </description></item>
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
        /// <item><description><para>true: Returns all datasets in the folder specified by DirectoryId and its subdirectories.</para>
        /// </description></item>
        /// <item><description><para>false: Returns only the datasets in the folder specified by DirectoryId.</para>
        /// </description></item>
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
