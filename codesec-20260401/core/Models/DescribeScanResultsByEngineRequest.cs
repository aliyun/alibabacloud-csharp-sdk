// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class DescribeScanResultsByEngineRequest : TeaModel {
        /// <summary>
        /// <para>Filters results by incremental scan baseline status. Valid values: new, unchanged, absent, updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unchanged</para>
        /// </summary>
        [NameInMap("baselineState")]
        [Validation(Required=false)]
        public string BaselineState { get; set; }

        /// <summary>
        /// <para>The language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese (default).</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Do not pass nextToken or pass an empty string for the first page. To retrieve the next page, pass the nextToken value from the previous response without any modification. When the nextToken in the response is empty, you have reached the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ0IjoiMjAyNi0wNy0xNlQwNzo1MzozOC4wMjFaIiwiaSI6MTAwMDQ0OH0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Performs a fuzzy match by component name. This parameter takes effect only when engine is set to sca.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app10000006824_fulljoin_61b2c_global_ad_budget_ctrl_v1.5.jar</para>
        /// </summary>
        [NameInMap("packageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

    }

}
