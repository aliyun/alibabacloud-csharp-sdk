// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListPredefinedScopesResponseBody : TeaModel {
        /// <summary>
        /// The information of application permissions.
        /// </summary>
        [NameInMap("PredefinedScopes")]
        [Validation(Required=false)]
        public ListPredefinedScopesResponseBodyPredefinedScopes PredefinedScopes { get; set; }
        public class ListPredefinedScopesResponseBodyPredefinedScopes : TeaModel {
            [NameInMap("PredefinedScope")]
            [Validation(Required=false)]
            public List<ListPredefinedScopesResponseBodyPredefinedScopesPredefinedScope> PredefinedScope { get; set; }
            public class ListPredefinedScopesResponseBodyPredefinedScopesPredefinedScope : TeaModel {
                /// <summary>
                /// The description of the permission scope.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the scope.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
