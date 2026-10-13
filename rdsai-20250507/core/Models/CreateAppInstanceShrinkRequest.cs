// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateAppInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the AI application to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-supabase</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The application type. Currently, only <b>supabase</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The client generates the value of this parameter to prevent duplicate requests from being submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of components.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        /// <summary>
        /// <para>The database instance configuration.</para>
        /// </summary>
        [NameInMap("DBInstanceConfig")]
        [Validation(Required=false)]
        public string DBInstanceConfigShrink { get; set; }

        /// <summary>
        /// <para>The instance ID of the RDS PostgreSQL database instance to which the AI application connects.</para>
        /// <para><notice>Only <b>newly purchased empty RDS PostgreSQL instances</b> are supported. The major engine version must be <b>17</b>, and the minor engine version must be <b>20250630 or later</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-2ze49qv594vi****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The password for the Supabase Dashboard.</para>
        /// <para>The password must be 8 to 32 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_Password</para>
        /// </summary>
        [NameInMap("DashboardPassword")]
        [Validation(Required=false)]
        public string DashboardPassword { get; set; }

        /// <summary>
        /// <para>The username for the Supabase Dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("DashboardUsername")]
        [Validation(Required=false)]
        public string DashboardUsername { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_database_01</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The password for accessing the RDS database.</para>
        /// <para>The password must be 8 to 32 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_Password</para>
        /// </summary>
        [NameInMap("DatabasePassword")]
        [Validation(Required=false)]
        public string DatabasePassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore from existing PostgreSQL data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: restores from existing data.</para>
        /// </description></item>
        /// <item><description><para>false (default): does not restore from existing data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InitializeWithExistingData")]
        [Validation(Required=false)]
        public bool? InitializeWithExistingData { get; set; }

        /// <summary>
        /// <para>The instance type. Currently, only <b>rdsai.supabase.basic</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rdsai.supabase.basic</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the public network connection endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicEndpointEnabled")]
        [Validation(Required=false)]
        public bool? PublicEndpointEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Internet NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the Internet NAT gateway.</description></item>
        /// <item><description><b>false</b> (default): does not enable the Internet NAT gateway.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: If an Internet NAT gateway is already enabled for the vSwitch specified by the <b>VSwitchId</b> parameter settings, set this parameter to <b>false</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PublicNetworkAccessEnabled")]
        [Validation(Required=false)]
        public bool? PublicNetworkAccessEnabled { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RAGEnabled")]
        [Validation(Required=false)]
        public bool? RAGEnabled { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-9dp2hkpm22gxscfgy****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
