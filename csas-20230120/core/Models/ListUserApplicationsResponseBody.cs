// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of applications that the user is authorized to access.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListUserApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListUserApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The action for private application access:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Block</b>: blocks access.</para>
            /// </description></item>
            /// <item><description><para><b>Allow</b>: allows access.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Block</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The application address group. This parameter is returned when ConfigMode is set to Precise. This parameter is empty when ConfigMode is an empty string.</para>
            /// </summary>
            [NameInMap("AddressGroups")]
            [Validation(Required=false)]
            public List<AddressGroup> AddressGroups { get; set; }

            /// <summary>
            /// <para>The list of private access application addresses.</para>
            /// </summary>
            [NameInMap("Addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-application-b927baf3e592****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The configuration mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Empty string: default mode.</para>
            /// </description></item>
            /// <item><description><para>Precise: precise mode.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Precise</para>
            /// </summary>
            [NameInMap("ConfigMode")]
            [Validation(Required=false)]
            public string ConfigMode { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>private_access_application_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The port ranges of the private access application. Multiple port ranges cannot be repeated or overlap.</para>
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<ListUserApplicationsResponseBodyApplicationsPortRanges> PortRanges { get; set; }
            public class ListUserApplicationsResponseBodyApplicationsPortRanges : TeaModel {
                /// <summary>
                /// <para>The start port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Begin")]
                [Validation(Required=false)]
                public string Begin { get; set; }

                /// <summary>
                /// <para>The end port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

            }

            /// <summary>
            /// <para>The protocol of the private access application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>All</b>: all protocols.</para>
            /// </description></item>
            /// <item><description><para><b>TCP</b>: TCP.</para>
            /// </description></item>
            /// <item><description><para><b>UDP</b>: UDP.</para>
            /// </description></item>
            /// <item><description><para><b>HTTP</b>: HTTP.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: HTTPS.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of applications that the user is authorized to access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
