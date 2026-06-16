// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListBrowsersInput : TeaModel {
        /// <summary>
        /// <para>Filters the results by browser name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-browser</para>
        /// </summary>
        [NameInMap("browserName")]
        [Validation(Required=false)]
        public string BrowserName { get; set; }

        /// <summary>
        /// <para>The page number of the results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
