// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndexFileDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the documents to return. If you do not specify this parameter, the results are not filtered by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>翻译平台运维文档</para>
        /// </summary>
        [NameInMap("DocumentName")]
        [Validation(Required=false)]
        public string DocumentName { get; set; }

        /// <summary>
        /// <para>The import status of the documents to return. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>INSERT_ERROR: The document failed to be imported.</para>
        /// </description></item>
        /// <item><description><para>RUNNING: The document is being imported.</para>
        /// </description></item>
        /// <item><description><para>DELETED: The document has been deleted.</para>
        /// </description></item>
        /// <item><description><para>FINISH: The document was imported successfully.</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the results are not filtered by import status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISH</para>
        /// </summary>
        [NameInMap("DocumentStatus")]
        [Validation(Required=false)]
        public string DocumentStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a fuzzy search based on the document name. This parameter is used with the <c>DocumentName</c> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Performs a fuzzy search based on the document name.</para>
        /// </description></item>
        /// <item><description><para>false: Performs an exact match based on the document name.</para>
        /// </description></item>
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
        /// <para>The ID of the knowledge base. This is the value of the <c>Data.Id</c> parameter returned by the <b>CreateIndex</b> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value starts from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of documents to return on each page. Maximum value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
