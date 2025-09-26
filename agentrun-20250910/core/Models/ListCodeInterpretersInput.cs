// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListCodeInterpretersInput : TeaModel {
        /// <summary>
        /// <para>按代码解释器名称过滤</para>
        /// </summary>
        [NameInMap("codeInterpreterName")]
        [Validation(Required=false)]
        public string CodeInterpreterName { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
