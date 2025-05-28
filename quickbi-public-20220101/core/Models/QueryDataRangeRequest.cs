// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataRangeRequest : TeaModel {
        /// <summary>
        /// <para>Name, for fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Data range type:</para>
        /// <list type="bullet">
        /// <item><description>llmCube: LlmCube resource.</description></item>
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
