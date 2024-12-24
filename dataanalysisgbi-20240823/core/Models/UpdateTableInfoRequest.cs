// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823.Models
{
    public class UpdateTableInfoRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("foreignKeys")]
        [Validation(Required=false)]
        public List<string> ForeignKeys { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("primaryKey")]
        [Validation(Required=false)]
        public string PrimaryKey { get; set; }

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
