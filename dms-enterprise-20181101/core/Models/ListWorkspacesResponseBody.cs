// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The dataset.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWorkspacesResponseBodyData Data { get; set; }
        public class ListWorkspacesResponseBodyData : TeaModel {
            [NameInMap("BaseWorkspaces")]
            [Validation(Required=false)]
            public List<ListWorkspacesResponseBodyDataBaseWorkspaces> BaseWorkspaces { get; set; }
            public class ListWorkspacesResponseBodyDataBaseWorkspaces : TeaModel {
                /// <summary>
                /// <para>Whether the current user has joined the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AlreadyJoined")]
                [Validation(Required=false)]
                public bool? AlreadyJoined { get; set; }

                /// <summary>
                /// <para>The ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public long? CreatorId { get; set; }

                /// <summary>
                /// <para>The nickname of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>work*****</para>
                /// </summary>
                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account UID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1344****</para>
                /// </summary>
                [NameInMap("CreatorUid")]
                [Validation(Required=false)]
                public string CreatorUid { get; set; }

                /// <summary>
                /// <para>The description of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace-xxxx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123****</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The nickname of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hel****</para>
                /// </summary>
                [NameInMap("OwnerNickName")]
                [Validation(Required=false)]
                public string OwnerNickName { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud UID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15608564799****</para>
                /// </summary>
                [NameInMap("OwnerUid")]
                [Validation(Required=false)]
                public string OwnerUid { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The ID of the service account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("ServiceAccountId")]
                [Validation(Required=false)]
                public long? ServiceAccountId { get; set; }

                /// <summary>
                /// <para>The nickname of the service account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testname</para>
                /// </summary>
                [NameInMap("ServiceAccountNickName")]
                [Validation(Required=false)]
                public string ServiceAccountNickName { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account UID of the service account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1422****</para>
                /// </summary>
                [NameInMap("ServiceAccountUid")]
                [Validation(Required=false)]
                public string ServiceAccountUid { get; set; }

                /// <summary>
                /// <para>The ID of the tenant to which the workspace belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23456</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-25fl3qjqb****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8652340494****</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public long? WorkspaceId { get; set; }

                /// <summary>
                /// <para>The name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-workspace</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserNotExist</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The total number of workspaces that meet the condition, which is the same as the TotalCount parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>NextToken does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE214ECD-4330-503A-82F0-FFB03975****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request succeeded.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of workspaces that meet the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
