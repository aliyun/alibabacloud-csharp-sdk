// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndexFileDetailsRequest : TeaModel {
        /// <summary>
        /// <para>Filters the returned file details list by file name. Default value: empty, which means no filtering by file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>翻译平台运维文档</para>
        /// </summary>
        [NameInMap("DocumentName")]
        [Validation(Required=false)]
        public string DocumentName { get; set; }

        /// <summary>
        /// <para>Filters the returned file list by file import status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSERT_ERROR: Failed to import to the index.</description></item>
        /// <item><description>RUNNING: Index building in progress.</description></item>
        /// <item><description>DELETED: Deleted.</description></item>
        /// <item><description>FINISH: Index building succeeded.</description></item>
        /// <item><description>PARSE_FAILED: Parsing failed.</description></item>
        /// <item><description>DOC_PARSING: Parsing in progress.</description></item>
        /// </list>
        /// <para>Default value: empty, which means no filtering by file import status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISH</para>
        /// </summary>
        [NameInMap("DocumentStatus")]
        [Validation(Required=false)]
        public string DocumentStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable fuzzy matching for file names. This parameter is used together with the <c>DocumentName</c> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Performs fuzzy matching on the returned file list based on the file name.</description></item>
        /// <item><description>false: Performs exact matching on the returned file list based on the file name.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableNameLike")]
        [Validation(Required=false)]
        public string EnableNameLike { get; set; }

        /// <summary>
        /// <para>The knowledge base ID, which is the <c>Data.Id</c> returned by the <b>CreateIndex</b> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <para>The page number to query. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of files to display per page for paging. Maximum value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
