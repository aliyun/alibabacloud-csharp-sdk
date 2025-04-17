// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetFileMetasResponseBody : TeaModel {
        [NameInMap("DatasetFileMetas")]
        [Validation(Required=false)]
        public List<DatasetFileMeta> DatasetFileMetas { get; set; }

        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90******-f5c5-4cd4-927e-1f45e1cb8b62_1729644433000</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
