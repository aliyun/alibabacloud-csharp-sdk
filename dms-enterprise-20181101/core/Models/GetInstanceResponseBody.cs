// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of the database instance.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>The name of the database link for the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DataLinkName")]
            [Validation(Required=false)]
            public string DataLinkName { get; set; }

            /// <summary>
            /// <para>The password that is used to log on to the database.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("DatabasePassword")]
            [Validation(Required=false)]
            public string DatabasePassword { get; set; }

            /// <summary>
            /// <para>The account that is used to log on to the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbuser</para>
            /// </summary>
            [NameInMap("DatabaseUser")]
            [Validation(Required=false)]
            public string DatabaseUser { get; set; }

            /// <summary>
            /// <para>The ID of the database administrator (DBA) for the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29****</para>
            /// </summary>
            [NameInMap("DbaId")]
            [Validation(Required=false)]
            public string DbaId { get; set; }

            /// <summary>
            /// <para>The nickname of the DBA for the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbaname</para>
            /// </summary>
            [NameInMap("DbaNickName")]
            [Validation(Required=false)]
            public string DbaNickName { get; set; }

            /// <summary>
            /// <para>Indicates whether the lock-free schema change feature is enabled for the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DdlOnline")]
            [Validation(Required=false)]
            public int? DdlOnline { get; set; }

            /// <summary>
            /// <para>The ID of the Elastic Compute Service (ECS) instance on which the database instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp124ldpklqz59y3****</para>
            /// </summary>
            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the database instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("EcsRegion")]
            [Validation(Required=false)]
            public string EcsRegion { get; set; }

            /// <summary>
            /// <para>The type of the environment to which the database instance belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>product</b>: production environment</description></item>
            /// <item><description><b>dev</b>: development environment</description></item>
            /// <item><description><b>pre</b>: staging environment</description></item>
            /// <item><description><b>test</b>: test environment</description></item>
            /// <item><description><b>sit</b>: system integration testing (SIT) environment</description></item>
            /// <item><description><b>uat</b>: user acceptance testing (UAT) environment</description></item>
            /// <item><description><b>pet</b>: stress testing environment</description></item>
            /// <item><description><b>stag</b>: STAG environment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The timeout period for exporting data from the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("ExportTimeout")]
            [Validation(Required=false)]
            public int? ExportTimeout { get; set; }

            /// <summary>
            /// <para>The host address that is used to connect to the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XXX.XXX</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The alias of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            /// <summary>
            /// <para>The ID of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>188****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The source of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_OWN</para>
            /// </summary>
            [NameInMap("InstanceSource")]
            [Validation(Required=false)]
            public string InstanceSource { get; set; }

            /// <summary>
            /// <para>The type of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>postgresql</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The IDs of the owners for the database instance.</para>
            /// </summary>
            [NameInMap("OwnerIdList")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceOwnerIdList OwnerIdList { get; set; }
            public class GetInstanceResponseBodyInstanceOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            /// <summary>
            /// <para>The nicknames of the owners for the database instance.</para>
            /// </summary>
            [NameInMap("OwnerNameList")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceOwnerNameList OwnerNameList { get; set; }
            public class GetInstanceResponseBodyInstanceOwnerNameList : TeaModel {
                [NameInMap("OwnerNames")]
                [Validation(Required=false)]
                public List<string> OwnerNames { get; set; }

            }

            /// <summary>
            /// <para>The port number that is used to connect to the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5432</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The timeout period for querying data in the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7200</para>
            /// </summary>
            [NameInMap("QueryTimeout")]
            [Validation(Required=false)]
            public int? QueryTimeout { get; set; }

            /// <summary>
            /// <para>The ID of the security rule set for the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3****</para>
            /// </summary>
            [NameInMap("SafeRuleId")]
            [Validation(Required=false)]
            public string SafeRuleId { get; set; }

            /// <summary>
            /// <para>Whether sensitive data protection is enabled.  Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enable.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Close.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SellSitd")]
            [Validation(Required=false)]
            public string SellSitd { get; set; }

            /// <summary>
            /// <para>The SID of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            /// <summary>
            /// <para>The control mode of the database instance.</para>
            /// </summary>
            [NameInMap("StandardGroup")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceStandardGroup StandardGroup { get; set; }
            public class GetInstanceResponseBodyInstanceStandardGroup : TeaModel {
                /// <summary>
                /// <para>The type of the control mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>COMMON</b>: Security Collaboration</description></item>
                /// <item><description><b>NONE_CONTROL</b>: Flexible Management</description></item>
                /// <item><description><b>STABLE</b>: Stable Change</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NONE_CONTROL</para>
                /// </summary>
                [NameInMap("GroupMode")]
                [Validation(Required=false)]
                public string GroupMode { get; set; }

                /// <summary>
                /// <para>The name of the security rule set corresponding to the control mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test group name</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <para>The status of the database instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NORMAL</b>: normal</description></item>
            /// <item><description><b>DISABLE</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Indicates whether the cross-database query feature is enabled for the database instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UseDsql")]
            [Validation(Required=false)]
            public int? UseDsql { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) to which the database instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-o6wrloqsdqc9io3mg****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6C80B69-3203-56AC-8021-18BA72A6F4E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
