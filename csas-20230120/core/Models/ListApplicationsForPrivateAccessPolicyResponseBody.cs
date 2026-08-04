// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApplicationsForPrivateAccessPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of private access policies.</para>
        /// </summary>
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListApplicationsForPrivateAccessPolicyResponseBodyPolices> Polices { get; set; }
        public class ListApplicationsForPrivateAccessPolicyResponseBodyPolices : TeaModel {
            /// <summary>
            /// <para>A collection of private access applications.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplications> Applications { get; set; }
            public class ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplications : TeaModel {
                /// <summary>
                /// <para>A collection of private access application addresses.</para>
                /// </summary>
                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public List<string> Addresses { get; set; }

                /// <summary>
                /// <para>The ID of the private access application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pa-application-7a9243dd02f4****</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <para>The time when the private access application was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-27 18:10:25</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the private access application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条被内网访问策略引用的内网访问应用</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the private access application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>A collection of port ranges for the private access application.</para>
                /// </summary>
                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplicationsPortRanges> PortRanges { get; set; }
                public class ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplicationsPortRanges : TeaModel {
                    /// <summary>
                    /// <para>The start port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    /// <summary>
                    /// <para>The end port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>81</para>
                    /// </summary>
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                }

                /// <summary>
                /// <para>The protocol of the private access application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>All</b>: All protocols.</para>
                /// </description></item>
                /// <item><description><para><b>TCP</b></para>
                /// </description></item>
                /// <item><description><para><b>UDP</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The status of the private access application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Enabled</b>: The application is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>Disabled</b>: The application is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-policy-1b0d0e8b4bcf****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D169859-A4F2-5EC8-853B-8447787C0D8A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
