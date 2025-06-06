// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListEnterpriseAcceleratePoliciesResponseBody : TeaModel {
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListEnterpriseAcceleratePoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListEnterpriseAcceleratePoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>whitelist</para>
            /// </summary>
            [NameInMap("AccelerationType")]
            [Validation(Required=false)]
            public string AccelerationType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eap-eec34d4b12fcca61</para>
            /// </summary>
            [NameInMap("EapId")]
            [Validation(Required=false)]
            public string EapId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public int? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnTls")]
            [Validation(Required=false)]
            public int? OnTls { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShowInClient")]
            [Validation(Required=false)]
            public int? ShowInClient { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12.34.56.XX</para>
            /// </summary>
            [NameInMap("UpstreamHost")]
            [Validation(Required=false)]
            public string UpstreamHost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("UpstreamPort")]
            [Validation(Required=false)]
            public int? UpstreamPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>connector</para>
            /// </summary>
            [NameInMap("UpstreamType")]
            [Validation(Required=false)]
            public string UpstreamType { get; set; }

            [NameInMap("UserAttributeGroup")]
            [Validation(Required=false)]
            public string UserAttributeGroup { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DB0471D0-C05C-556D-9F40-0325D890036F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
