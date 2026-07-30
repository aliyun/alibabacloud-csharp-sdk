// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetFileMetasResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of dataset file metadata details.</para>
        /// </summary>
        [NameInMap("DatasetFileMetas")]
        [Validation(Required=false)]
        public List<DatasetFileMeta> DatasetFileMetas { get; set; }

        /// <summary>
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-rbvg5*****jhc9ks92</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The dataset version name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The maximum number of results returned per request when using NextToken-based pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. If the results that match the query conditions exceed the page size, this pagination token is returned. Pass the returned token value as a request parameter to retrieve the next page, until no token is returned, which indicates that all data has been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90******-f5c5-4cd4-927e-1f45e1cb8b62_1729644433000</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The current page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>105173</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
