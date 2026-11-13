// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class IdentifyCredential : TeaModel {
        /// <summary>
        /// <para>The data source.</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public IdentifyCredentialDataSource DataSource { get; set; }
        public class IdentifyCredentialDataSource : TeaModel {
            /// <summary>
            /// <para>The data source instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>710007423244</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The data source instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2zez82ho69yex7s7g</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The data source password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExamplePass***2026</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The data source user type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Admin: administrator.</description></item>
            /// <item><description>RegularUser: regular user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>hive</description></item>
            /// <item><description>lindorm_for_engine</description></item>
            /// <item><description>starrocks</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hologres</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The data source username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tom</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The user ID. For a role, add the ROLE_ prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROLE_300888674340307309</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The user type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrimaryAccount: Alibaba Cloud account.</description></item>
        /// <item><description>SubAccount: RAM user.</description></item>
        /// <item><description>Role: role.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>primaryAccount</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
