// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApplicationsForPrivateAccessTagResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>B608C6AE-623D-55C4-9454-601B88AE937E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListApplicationsForPrivateAccessTagResponseBodyTags> Tags { get; set; }
        public class ListApplicationsForPrivateAccessTagResponseBodyTags : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsForPrivateAccessTagResponseBodyTagsApplications> Applications { get; set; }
            public class ListApplicationsForPrivateAccessTagResponseBodyTagsApplications : TeaModel {
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
                /// <para>内网访问应用创建时间。</para>
                /// 
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
                /// <para>private_access_application_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<ListApplicationsForPrivateAccessTagResponseBodyTagsApplicationsPortRanges> PortRanges { get; set; }
                public class ListApplicationsForPrivateAccessTagResponseBodyTagsApplicationsPortRanges : TeaModel {
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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tag-7ffc82853476****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
