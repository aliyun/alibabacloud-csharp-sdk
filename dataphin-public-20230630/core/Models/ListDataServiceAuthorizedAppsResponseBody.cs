// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceAuthorizedAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paging query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListDataServiceAuthorizedAppsResponseBodyPageResult PageResult { get; set; }
        public class ListDataServiceAuthorizedAppsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paginated list of authorized applications.</para>
            /// </summary>
            [NameInMap("AuthorizedAppList")]
            [Validation(Required=false)]
            public List<ListDataServiceAuthorizedAppsResponseBodyPageResultAuthorizedAppList> AuthorizedAppList { get; set; }
            public class ListDataServiceAuthorizedAppsResponseBodyPageResultAuthorizedAppList : TeaModel {
                /// <summary>
                /// <para>The primary key ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1022</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public int? AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The ID of the permission account, which is the applicant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012101</para>
                /// </summary>
                [NameInMap("ApplyUserId")]
                [Validation(Required=false)]
                public string ApplyUserId { get; set; }

                /// <summary>
                /// <para>The permission account, which is the applicant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试</para>
                /// </summary>
                [NameInMap("ApplyUserName")]
                [Validation(Required=false)]
                public string ApplyUserName { get; set; }

                /// <summary>
                /// <para>The expiration date in the format of yyyy-MM-dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30</para>
                /// </summary>
                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public string ExpireDate { get; set; }

                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the current user is a project administrator.</para>
                /// </summary>
                [NameInMap("IsProjectManager")]
                [Validation(Required=false)]
                public bool? IsProjectManager { get; set; }

                /// <summary>
                /// <para>The ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The name of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerUserName")]
                [Validation(Required=false)]
                public string OwnerUserName { get; set; }

                /// <summary>
                /// <para>The permission account. Valid values: 0: individual account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PrivilegeAccount")]
                [Validation(Required=false)]
                public int? PrivilegeAccount { get; set; }

                /// <summary>
                /// <para>The permission type. Valid values: 0: usage permission. 1: development permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PrivilegeType")]
                [Validation(Required=false)]
                public int? PrivilegeType { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102122</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>Indicates whether the user actually has owner permissions on this application. The user may lack permissions because of expiration or other reasons.</para>
                /// </summary>
                [NameInMap("RealHasOwnerPrivilege")]
                [Validation(Required=false)]
                public bool? RealHasOwnerPrivilege { get; set; }

                /// <summary>
                /// <para>Indicates whether the user actually has permissions.</para>
                /// </summary>
                [NameInMap("RealHasPrivilege")]
                [Validation(Required=false)]
                public bool? RealHasPrivilege { get; set; }

                /// <summary>
                /// <para>The descriptions used for troubleshooting.</para>
                /// </summary>
                [NameInMap("RemarkForDebugList")]
                [Validation(Required=false)]
                public List<ListDataServiceAuthorizedAppsResponseBodyPageResultAuthorizedAppListRemarkForDebugList> RemarkForDebugList { get; set; }
                public class ListDataServiceAuthorizedAppsResponseBodyPageResultAuthorizedAppListRemarkForDebugList : TeaModel {
                    /// <summary>
                    /// <para>The configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>k1</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the permissions can be returned or revoked.</para>
                /// </summary>
                [NameInMap("Revocable")]
                [Validation(Required=false)]
                public bool? Revocable { get; set; }

                /// <summary>
                /// <para>The detailed status of the revoke button. Valid values: -1: super administrators cannot revoke. -2: owners cannot revoke. -3: project administrators without actual permissions are grayed out. -4: regular users without permissions cannot revoke. 1: project administrators with actual permissions can revoke. 2: regular users with permissions can revoke.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("RevocableDetail")]
                [Validation(Required=false)]
                public int? RevocableDetail { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
