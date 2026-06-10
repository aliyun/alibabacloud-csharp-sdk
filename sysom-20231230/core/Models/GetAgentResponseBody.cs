// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end Diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-14T20:46:08</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that authorization succeeded.  </description></item>
        /// <item><description>Other status codes indicate that authorization failed. When authorization fails, view the <c>message</c> field to obtain detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAgentResponseBodyData Data { get; set; }
        public class GetAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation Time of the widget</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-14T20:46:08</para>
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Description of the widget</para>
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
            /// <para>Name of the widget</para>
            /// 
            /// <b>Example:</b>
            /// <para>SysOM</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Supported architecture</para>
            /// 
            /// <b>Example:</b>
            /// <para>x86</para>
            /// </summary>
            [NameInMap("support_arch")]
            [Validation(Required=false)]
            public string SupportArch { get; set; }

            /// <summary>
            /// <para>Type of the Agent</para>
            /// 
            /// <b>Example:</b>
            /// <para>control</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Update Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-14T20:46:08</para>
            /// </summary>
            [NameInMap("updated_at")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>Widget version information</para>
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyDataVersions> Versions { get; set; }
            public class GetAgentResponseBodyDataVersions : TeaModel {
                /// <summary>
                /// <para>Creation Time of the Agent version</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-14T20:46:08</para>
                /// </summary>
                [NameInMap("created_at")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>Installation script for this version of the Agent</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysom.sh install</para>
                /// </summary>
                [NameInMap("install_script")]
                [Validation(Required=false)]
                public string InstallScript { get; set; }

                /// <summary>
                /// <para>Uninstall script for this Agent version</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysom.sh uninstall</para>
                /// </summary>
                [NameInMap("uninstall_script")]
                [Validation(Required=false)]
                public string UninstallScript { get; set; }

                /// <summary>
                /// <para>Update Time of the Agent version</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-14T20:46:08</para>
                /// </summary>
                [NameInMap("updated_at")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                /// <summary>
                /// <para>Upgrade script for this Agent version</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysom.sh upgrade</para>
                /// </summary>
                [NameInMap("upgrade_script")]
                [Validation(Required=false)]
                public string UpgradeScript { get; set; }

                /// <summary>
                /// <para>Version number of the Agent</para>
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
        /// <item><description>If <c>code == Success</c>, this field is empty;  </description></item>
        /// <item><description>Otherwise, this field contains the Request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIException: SysomOpenAPI.InvalidParameter Invalid params, should be json string or dict</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
