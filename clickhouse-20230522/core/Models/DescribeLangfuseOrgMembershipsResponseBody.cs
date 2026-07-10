// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeLangfuseOrgMembershipsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeLangfuseOrgMembershipsResponseBodyData Data { get; set; }
        public class DescribeLangfuseOrgMembershipsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of user roles in the organization.</para>
            /// </summary>
            [NameInMap("Memberships")]
            [Validation(Required=false)]
            public List<DescribeLangfuseOrgMembershipsResponseBodyDataMemberships> Memberships { get; set; }
            public class DescribeLangfuseOrgMembershipsResponseBodyDataMemberships : TeaModel {
                /// <summary>
                /// <para>The time when the user was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-24T10:14:33Z</para>
                /// </summary>
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

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
                /// <para>The role of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIEWER</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
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
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1F488A93-83FD-540F-9B67-0333AF64E6A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
