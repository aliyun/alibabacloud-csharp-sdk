// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListPredefinedScopesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of application permissions.</para>
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
                /// <para>The description of the permission scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Obtain the OpenID of the user. This is the default permission that you cannot remove.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openid</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>955C096D-EC99-480B-AF37-3921109107D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
