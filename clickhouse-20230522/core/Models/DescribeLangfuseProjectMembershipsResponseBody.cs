// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeLangfuseProjectMembershipsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeLangfuseProjectMembershipsResponseBodyData Data { get; set; }
        public class DescribeLangfuseProjectMembershipsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of user roles in the Langfuse project.</para>
            /// </summary>
            [NameInMap("Memberships")]
            [Validation(Required=false)]
            public List<DescribeLangfuseProjectMembershipsResponseBodyDataMemberships> Memberships { get; set; }
            public class DescribeLangfuseProjectMembershipsResponseBodyDataMemberships : TeaModel {
                /// <summary>
                /// <para>The email address of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:john@company.com">john@company.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>john</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The role of the user in the Langfuse organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADMIN</para>
                /// </summary>
                [NameInMap("OrgRole")]
                [Validation(Required=false)]
                public string OrgRole { get; set; }

                /// <summary>
                /// <para>The role of the user in the Langfuse project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIEWER</para>
                /// </summary>
                [NameInMap("ProjectRole")]
                [Validation(Required=false)]
                public string ProjectRole { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A82758F8-E793-5610-BE11-0E46664305C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
