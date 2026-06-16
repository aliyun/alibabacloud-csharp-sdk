// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListCodeInterpretersInput : TeaModel {
        /// <summary>
        /// <para>Filters results by code interpreter name.</para>
        /// </summary>
        [NameInMap("codeInterpreterName")]
        [Validation(Required=false)]
        public string CodeInterpreterName { get; set; }

        /// <summary>
        /// <para>The page number of the results to return. Default: 1.</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Maximum number of results to return per page. Valid values: 1 to 100. Default: 20.</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
