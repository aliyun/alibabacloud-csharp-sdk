// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetPrivateAccessApplicationResponseBody : TeaModel {
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetPrivateAccessApplicationResponseBodyApplication Application { get; set; }
        public class GetPrivateAccessApplicationResponseBodyApplication : TeaModel {
            [NameInMap("Addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-application-e12860ef6c48****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            [NameInMap("BrowserAccessStatus")]
            [Validation(Required=false)]
            public string BrowserAccessStatus { get; set; }

            [NameInMap("ConnectorIds")]
            [Validation(Required=false)]
            public List<string> ConnectorIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-30 16:50:32</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("L7Config")]
            [Validation(Required=false)]
            public PAL7Config L7Config { get; set; }

            [NameInMap("L7ProxyDomainAutomatic")]
            [Validation(Required=false)]
            public string L7ProxyDomainAutomatic { get; set; }

            [NameInMap("L7ProxyDomainCustom")]
            [Validation(Required=false)]
            public string L7ProxyDomainCustom { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>private_access_application_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PolicyIds")]
            [Validation(Required=false)]
            public List<string> PolicyIds { get; set; }

            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<GetPrivateAccessApplicationResponseBodyApplicationPortRanges> PortRanges { get; set; }
            public class GetPrivateAccessApplicationResponseBodyApplicationPortRanges : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Begin")]
                [Validation(Required=false)]
                public int? Begin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>81</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public int? End { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3ACC5EDC-2B7D-5032-8C58-D7615D66C1D4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
