// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAgentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which can be used for end-to-end diagnostics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66EAED72-542B-583B-BCED-64433DC27AD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description>If code is Success, the authorization is successful.</description></item>
        /// <item><description>Other status codes indicate authorization failed. Check the message field for the detailed fault information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAgentsResponseBodyData> Data { get; set; }
        public class ListAgentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the component was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-14T20:46:08</para>
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The component description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SysOM Agent</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The component ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The component name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SysOM Agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The supported architectures. Multiple architectures are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x86</para>
            /// </summary>
            [NameInMap("support_arch")]
            [Validation(Required=false)]
            public string SupportArch { get; set; }

            /// <summary>
            /// <para>The type of the component. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Control: control-type component.</description></item>
            /// <item><description>AI: AI component.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Control</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the component was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-14T20:46:08</para>
            /// </summary>
            [NameInMap("updated_at")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The list of component versions.</para>
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<ListAgentsResponseBodyDataVersions> Versions { get; set; }
            public class ListAgentsResponseBodyDataVersions : TeaModel {
                /// <summary>
                /// <para>The time when the component version was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-14T20:46:08</para>
                /// </summary>
                [NameInMap("created_at")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The installation script of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysom.sh install</para>
                /// </summary>
                [NameInMap("install_script")]
                [Validation(Required=false)]
                public string InstallScript { get; set; }

                /// <summary>
                /// <para>The uninstallation script of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysom.sh uninstall</para>
                /// </summary>
                [NameInMap("uninstall_script")]
                [Validation(Required=false)]
                public string UninstallScript { get; set; }

                /// <summary>
                /// <para>The time when the component version was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-14T20:46:08</para>
                /// </summary>
                [NameInMap("updated_at")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                /// <summary>
                /// <para>The update script of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysom.sh upgrade</para>
                /// </summary>
                [NameInMap("upgrade_script")]
                [Validation(Required=false)]
                public string UpgradeScript { get; set; }

                /// <summary>
                /// <para>The component version number.</para>
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
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If code is Success, this field is empty.</description></item>
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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
