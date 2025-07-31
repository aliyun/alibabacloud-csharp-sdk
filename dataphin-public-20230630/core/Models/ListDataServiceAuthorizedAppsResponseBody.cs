// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceAuthorizedAppsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListDataServiceAuthorizedAppsResponseBodyPageResult PageResult { get; set; }
        public class ListDataServiceAuthorizedAppsResponseBodyPageResult : TeaModel {
            [NameInMap("AuthorizedAppList")]
            [Validation(Required=false)]
            public List<ListDataServiceAuthorizedAppsResponseBodyPageResultAuthorizedAppList> AuthorizedAppList { get; set; }
            public class ListDataServiceAuthorizedAppsResponseBodyPageResultAuthorizedAppList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1022</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public int? AppId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30012101</para>
                /// </summary>
                [NameInMap("ApplyUserId")]
                [Validation(Required=false)]
                public string ApplyUserId { get; set; }

                [NameInMap("ApplyUserName")]
                [Validation(Required=false)]
                public string ApplyUserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30</para>
                /// </summary>
                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public string ExpireDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("IsProjectManager")]
                [Validation(Required=false)]
                public bool? IsProjectManager { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerUserName")]
                [Validation(Required=false)]
                public string OwnerUserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PrivilegeAccount")]
                [Validation(Required=false)]
                public int? PrivilegeAccount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PrivilegeType")]
                [Validation(Required=false)]
                public int? PrivilegeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>102122</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("RealHasOwnerPrivilege")]
                [Validation(Required=false)]
                public bool? RealHasOwnerPrivilege { get; set; }

                [NameInMap("RealHasPrivilege")]
                [Validation(Required=false)]
                public bool? RealHasPrivilege { get; set; }

                [NameInMap("RemarkForDebugList")]
                [Validation(Required=false)]
                public List<ListDataServiceAuthorizedAppsResponseBodyPageResultAuthorizedAppListRemarkForDebugList> RemarkForDebugList { get; set; }
                public class ListDataServiceAuthorizedAppsResponseBodyPageResultAuthorizedAppListRemarkForDebugList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>k1</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Revocable")]
                [Validation(Required=false)]
                public bool? Revocable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("RevocableDetail")]
                [Validation(Required=false)]
                public int? RevocableDetail { get; set; }

            }

            /// <summary>
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
