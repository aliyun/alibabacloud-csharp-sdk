// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserApplicationsResponseBody : TeaModel {
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListUserApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListUserApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Block</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("AddressGroups")]
            [Validation(Required=false)]
            public List<AddressGroup> AddressGroups { get; set; }

            [NameInMap("Addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-application-b927baf3e592****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            [NameInMap("ConfigMode")]
            [Validation(Required=false)]
            public string ConfigMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>private_access_application_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<ListUserApplicationsResponseBodyApplicationsPortRanges> PortRanges { get; set; }
            public class ListUserApplicationsResponseBodyApplicationsPortRanges : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Begin")]
                [Validation(Required=false)]
                public string Begin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>81</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
