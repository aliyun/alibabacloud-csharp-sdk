// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListPredefinedScopesResponseBody : TeaModel {
        [NameInMap("PredefinedScopes")]
        [Validation(Required=false)]
        public ListPredefinedScopesResponseBodyPredefinedScopes PredefinedScopes { get; set; }
        public class ListPredefinedScopesResponseBodyPredefinedScopes : TeaModel {
            [NameInMap("PredefinedScope")]
            [Validation(Required=false)]
            public List<ListPredefinedScopesResponseBodyPredefinedScopesPredefinedScope> PredefinedScope { get; set; }
            public class ListPredefinedScopesResponseBodyPredefinedScopesPredefinedScope : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>955C096D-EC99-480B-AF37-3921109107D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
