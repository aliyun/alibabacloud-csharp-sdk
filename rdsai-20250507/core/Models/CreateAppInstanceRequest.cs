// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateAppInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the RDS for PostgreSQL instance with which the RDS Supabase instances are associated.</para>
        /// <remarks>
        /// <para>: Only newly purchased empty RDS for PostgreSQL instances are supported. The major engine version must be PostgreSQL 17 and the minor version must be 20250630 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test-supabase</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The name of the new AI application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// </summary>
        [NameInMap("DBInstanceConfig")]
        [Validation(Required=false)]
        public CreateAppInstanceRequestDBInstanceConfig DBInstanceConfig { get; set; }
        public class CreateAppInstanceRequestDBInstanceConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pg.n2.2c.1m</para>
            /// </summary>
            [NameInMap("DBInstanceClass")]
            [Validation(Required=false)]
            public string DBInstanceClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DBInstanceStorage")]
            [Validation(Required=false)]
            public int? DBInstanceStorage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

        }

        /// <summary>
        /// <para>The instance type. Only <b>rdsai.supabase.basic</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-2ze49qv594vi****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The Supabase Dashboard user name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_Password</para>
        /// </summary>
        [NameInMap("DashboardPassword")]
        [Validation(Required=false)]
        public string DashboardPassword { get; set; }

        /// <summary>
        /// <para>The password used to access the RDS database.</para>
        /// <para>The password must be 8 to 32 characters in length and must contain at least three of the following characters: uppercase letters, lowercase letters, digits, and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("DashboardUsername")]
        [Validation(Required=false)]
        public string DashboardUsername { get; set; }

        /// <summary>
        /// <para>The idempotency token. The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_Password</para>
        /// </summary>
        [NameInMap("DatabasePassword")]
        [Validation(Required=false)]
        public string DatabasePassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public endpoint.</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InitializeWithExistingData")]
        [Validation(Required=false)]
        public bool? InitializeWithExistingData { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rdsai.supabase.basic</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The billing method of the RDS for PostgreSQL instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicEndpointEnabled")]
        [Validation(Required=false)]
        public bool? PublicEndpointEnabled { get; set; }

        /// <summary>
        /// <para>The Supabase Dashboard password.</para>
        /// <para>The password must be 8 to 32 characters in length and must contain at least three of the following characters: uppercase letters, lowercase letters, digits, and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PublicNetworkAccessEnabled")]
        [Validation(Required=false)]
        public bool? PublicNetworkAccessEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Internet NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enable the Internet NAT gateway.</description></item>
        /// <item><description><b>false</b> (default): disable the Internet NAT gateway.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If an Internet NAT gateway is enabled for the vSwitch that you specify for VSwitchId, select false for this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RAGEnabled")]
        [Validation(Required=false)]
        public bool? RAGEnabled { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>CreateAppInstance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The application type. Only <b>supabase</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-9dp2hkpm22gxscfgy****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
