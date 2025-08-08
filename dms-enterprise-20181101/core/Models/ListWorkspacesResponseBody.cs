// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWorkspacesResponseBodyData Data { get; set; }
        public class ListWorkspacesResponseBodyData : TeaModel {
            [NameInMap("BaseWorkspaces")]
            [Validation(Required=false)]
            public List<ListWorkspacesResponseBodyDataBaseWorkspaces> BaseWorkspaces { get; set; }
            public class ListWorkspacesResponseBodyDataBaseWorkspaces : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AlreadyJoined")]
                [Validation(Required=false)]
                public bool? AlreadyJoined { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public long? CreatorId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>work*****</para>
                /// </summary>
                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1344****</para>
                /// </summary>
                [NameInMap("CreatorUid")]
                [Validation(Required=false)]
                public string CreatorUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>workspace-xxxx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123****</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hel****</para>
                /// </summary>
                [NameInMap("OwnerNickName")]
                [Validation(Required=false)]
                public string OwnerNickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15608564799****</para>
                /// </summary>
                [NameInMap("OwnerUid")]
                [Validation(Required=false)]
                public string OwnerUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("ServiceAccountId")]
                [Validation(Required=false)]
                public long? ServiceAccountId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testname</para>
                /// </summary>
                [NameInMap("ServiceAccountNickName")]
                [Validation(Required=false)]
                public string ServiceAccountNickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1422****</para>
                /// </summary>
                [NameInMap("ServiceAccountUid")]
                [Validation(Required=false)]
                public string ServiceAccountUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23456</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-25fl3qjqb****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8652340494****</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public long? WorkspaceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-workspace</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UserNotExist</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>token-xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE214ECD-4330-503A-82F0-FFB03975****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
