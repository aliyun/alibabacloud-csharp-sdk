// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823.Models
{
    public class DeleteColumnRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>column-AAAAAAAAh6Q9ERazKYFvkA</para>
        /// </summary>
        [NameInMap("columnIdKey")]
        [Validation(Required=false)]
        public string ColumnIdKey { get; set; }

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
