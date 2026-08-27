// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetMigrationNamespacedServicesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMigrationNamespacedServicesResponseBodyData Data { get; set; }
        public class GetMigrationNamespacedServicesResponseBodyData : TeaModel {
            [NameInMap("namespacedServices")]
            [Validation(Required=false)]
            public List<GetMigrationNamespacedServicesResponseBodyDataNamespacedServices> NamespacedServices { get; set; }
            public class GetMigrationNamespacedServicesResponseBodyDataNamespacedServices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("services")]
                [Validation(Required=false)]
                public List<GetMigrationNamespacedServicesResponseBodyDataNamespacedServicesServices> Services { get; set; }
                public class GetMigrationNamespacedServicesResponseBodyDataNamespacedServicesServices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>nginx-ingress-lb</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>lb-xxxx / nlb-xxxx</para>
                    /// </summary>
                    [NameInMap("slbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D513911-206E-5E93-9C9E-71D63C0D68E7</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
