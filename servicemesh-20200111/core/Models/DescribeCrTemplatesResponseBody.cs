// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeCrTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74E97AE2-2900-55C1-A069-C3C1EA*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The common YAML templates for the specified type of Istio resource.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeCrTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeCrTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>The Chinese name of the YAML template.</para>
            /// </summary>
            [NameInMap("ChineseName")]
            [Validation(Required=false)]
            public string ChineseName { get; set; }

            /// <summary>
            /// <para>The English name of the YAML template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP basic routing</para>
            /// </summary>
            [NameInMap("EnglishName")]
            [Validation(Required=false)]
            public string EnglishName { get; set; }

            /// <summary>
            /// <para>The content in the YAML template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiVersion: networking.istio.io/v1beta1\nkind: VirtualService\nmetadata:\n  name: reviews-route # Name for this VirtualService.\nspec:\n  hosts:\n  - reviews.prod.svc.cluster.local # Service that this VirtualSerivce belongs to. \n  http:\n  - name: \&quot;reviews-route\&quot; # Name for the route.\n    route:\n    - destination: # Uniquely identifies the instances of a service to which all traffic should be forwarded to.\n        host: reviews.prod.svc.cluster.local # The name of a service from the service registry or ServiceEntry.\n        port:\n          number: 8080&quot;</para>
            /// </summary>
            [NameInMap("Yaml")]
            [Validation(Required=false)]
            public string Yaml { get; set; }

        }

    }

}
