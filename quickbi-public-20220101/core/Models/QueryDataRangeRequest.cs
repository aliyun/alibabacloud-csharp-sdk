// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataRangeRequest : TeaModel {
        /// <summary>
        /// <para>The name. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The data scope type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>llmCube: Data query resource.</description></item>
        /// <item><description>llmCubeTheme: Analysis theme.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llmCube</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
