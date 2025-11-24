// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ListServiceAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8349374D-0F22-5CAB-9DE3-8CCE8EFA71FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of service accounts.</para>
        /// </summary>
        [NameInMap("ServiceAccounts")]
        [Validation(Required=false)]
        public List<ListServiceAccountsResponseBodyServiceAccounts> ServiceAccounts { get; set; }
        public class ListServiceAccountsResponseBodyServiceAccounts : TeaModel {
            /// <summary>
            /// <para>The name of the service account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bookinfo-reviews</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace where the service account resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

        }

    }

}
