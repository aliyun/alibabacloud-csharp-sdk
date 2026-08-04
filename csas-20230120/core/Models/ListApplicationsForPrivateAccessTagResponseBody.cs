// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApplicationsForPrivateAccessTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B608C6AE-623D-55C4-9454-601B88AE937E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of private network access tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListApplicationsForPrivateAccessTagResponseBodyTags> Tags { get; set; }
        public class ListApplicationsForPrivateAccessTagResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The collection of private network access applications.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsForPrivateAccessTagResponseBodyTagsApplications> Applications { get; set; }
            public class ListApplicationsForPrivateAccessTagResponseBodyTagsApplications : TeaModel {
                /// <summary>
                /// <para>The collection of addresses for the private network access application.</para>
                /// </summary>
                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public List<string> Addresses { get; set; }

                /// <summary>
                /// <para>The ID of the private network access application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pa-application-7a9243dd02f4****</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <para>The time when the private network access application was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-27 18:10:25</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the private network access application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条内网访问应用</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the private network access application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>private_access_application_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The collection of port ranges for the private network access application. Port ranges must not overlap or duplicate each other.</para>
                /// </summary>
                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<ListApplicationsForPrivateAccessTagResponseBodyTagsApplicationsPortRanges> PortRanges { get; set; }
                public class ListApplicationsForPrivateAccessTagResponseBodyTagsApplicationsPortRanges : TeaModel {
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
                /// <para>The protocol used by the private network access application. Valid values:</para>
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
                /// <para>All</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The status of the private network access application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Enabled</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>Disabled</b>: Disabled.</para>
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
            /// <para>The ID of the private network access tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-7ffc82853476****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
