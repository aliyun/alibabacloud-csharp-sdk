// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataList> List { get; set; }
            public class ListInstancesResponseBodyDataList : TeaModel {
                [NameInMap("AdminList")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyDataListAdminList> AdminList { get; set; }
                public class ListInstancesResponseBodyDataListAdminList : TeaModel {
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                    /// </summary>
                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8032****</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ccc-test</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>agent</para>
                    /// </summary>
                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1382114****</para>
                    /// </summary>
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Admin@ccc-test</para>
                    /// </summary>
                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public string RoleId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Admin</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>agent@ccc-test</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ON_SITE</para>
                    /// </summary>
                    [NameInMap("WorkMode")]
                    [Validation(Required=false)]
                    public string WorkMode { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>157123456789****</para>
                /// </summary>
                [NameInMap("AliyunUid")]
                [Validation(Required=false)]
                public string AliyunUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://ccc-v2.aliyun.com/#/workbench/ccc-test">https://ccc-v2.aliyun.com/#/workbench/ccc-test</a></para>
                /// </summary>
                [NameInMap("ConsoleUrl")]
                [Validation(Required=false)]
                public string ConsoleUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1624679747000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NumberList")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyDataListNumberList> NumberList { get; set; }
                public class ListInstancesResponseBodyDataListNumberList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0830011****</para>
                    /// </summary>
                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26A34338-5CD9-4C95-A7A6-5BDCE76C6B94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
