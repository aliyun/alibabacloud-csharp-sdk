// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListGraphSchemasRequest : TeaModel {
        /// <summary>
        /// <para>The keyword for fuzzy match of component data in the form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The semantic tags used for filtering. A graph is retained if any tag matches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Sales&quot;]</para>
        /// </summary>
        [NameInMap("semanticTags")]
        [Validation(Required=false)]
        public List<string> SemanticTags { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If this parameter is not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
