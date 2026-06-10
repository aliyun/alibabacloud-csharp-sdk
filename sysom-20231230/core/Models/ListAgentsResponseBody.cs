// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAgentsResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end Diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>66EAED72-542B-583B-BCED-64433DC27AD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates successful authorization;  </description></item>
        /// <item><description>Other status codes indicate authorization failure. When authorization fails, view the <c>message</c> field to obtain detailed error message;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned Data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAgentsResponseBodyData> Data { get; set; }
        public class ListAgentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Widget creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-14T20:46:08</para>
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Widget description</para>
            /// 
            /// <b>Example:</b>
            /// <para>SysOM Agent</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Widget ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Widget name</para>
            /// 
            /// <b>Example:</b>
            /// <para>SysOM Agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Supported architecture (multiple architectures separated by commas)</para>
            /// 
            /// <b>Example:</b>
            /// <para>x86</para>
            /// </summary>
            [NameInMap("support_arch")]
            [Validation(Required=false)]
            public string SupportArch { get; set; }

            /// <summary>
            /// <para>Widget type  </para>
            /// <list type="bullet">
            /// <item><description>Control: control-type widget  </description></item>
            /// <item><description>AI: AI widget</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Control</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Widget Update Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-14T20:46:08</para>
            /// </summary>
            [NameInMap("updated_at")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>Widget Version List</para>
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<ListAgentsResponseBodyDataVersions> Versions { get; set; }
            public class ListAgentsResponseBodyDataVersions : TeaModel {
                /// <summary>
                /// <para>Widget version creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-14T20:46:08</para>
                /// </summary>
                [NameInMap("created_at")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The widget\&quot;s install script</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysom.sh install</para>
                /// </summary>
                [NameInMap("install_script")]
                [Validation(Required=false)]
                public string InstallScript { get; set; }

                /// <summary>
                /// <para>Widget uninstall script</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysom.sh uninstall</para>
                /// </summary>
                [NameInMap("uninstall_script")]
                [Validation(Required=false)]
                public string UninstallScript { get; set; }

                /// <summary>
                /// <para>Widget version update time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-14T20:46:08</para>
                /// </summary>
                [NameInMap("updated_at")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                /// <summary>
                /// <para>Widget upgrade script</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysom.sh upgrade</para>
                /// </summary>
                [NameInMap("upgrade_script")]
                [Validation(Required=false)]
                public string UpgradeScript { get; set; }

                /// <summary>
                /// <para>Widget version number</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.4.0-1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIAssumeRoleException: EntityNotExist.Role The role not exists: acs:ram::xxxxx:role/aliyunserviceroleforsysom</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
