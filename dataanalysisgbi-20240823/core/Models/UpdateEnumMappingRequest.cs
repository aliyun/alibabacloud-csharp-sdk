// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823.Models
{
    public class UpdateEnumMappingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>column-AAAAAAAAh6cWOUPagYstkg</para>
        /// </summary>
        [NameInMap("columnIdKey")]
        [Validation(Required=false)]
        public string ColumnIdKey { get; set; }

        [NameInMap("enumMapping")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> EnumMapping { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table-AAAAAAAAFQBwSLJkUj4CYg</para>
        /// </summary>
        [NameInMap("tableIdKey")]
        [Validation(Required=false)]
        public string TableIdKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2v3934xtp49esw64</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
