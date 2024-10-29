// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApplicationsForPrivateAccessPolicyResponseBody : TeaModel {
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListApplicationsForPrivateAccessPolicyResponseBodyPolices> Polices { get; set; }
        public class ListApplicationsForPrivateAccessPolicyResponseBodyPolices : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplications> Applications { get; set; }
            public class ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplications : TeaModel {
                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public List<string> Addresses { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pa-application-7a9243dd02f4****</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-09-27 18:10:25</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>application_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplicationsPortRanges> PortRanges { get; set; }
                public class ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplicationsPortRanges : TeaModel {
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
                /// <para>TCP</para>
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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-policy-1b0d0e8b4bcf****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4D169859-A4F2-5EC8-853B-8447787C0D8A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
