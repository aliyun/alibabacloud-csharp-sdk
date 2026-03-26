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
            /// <para>The instance ID of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>710007423244</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2zez82ho69yex7s7g</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The password for the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The user type of the data source.</para>
            /// <list type="bullet">
            /// <item><description>Admin</description></item>
            /// <item><description>RegularUser</description></item>
            /// </list>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RegularUser: Normal user.</description></item>
            /// <item><description>Admin: Administrator.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The type of the data source. Supported types:</para>
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
            /// <para>The username for the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tom</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID (optional).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The user ID. If it is a role, the ROLE_ prefix must be added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROLE_300888674340307309</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud account</description></item>
        /// <item><description>RAM user</description></item>
        /// <item><description>Role</description></item>
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
