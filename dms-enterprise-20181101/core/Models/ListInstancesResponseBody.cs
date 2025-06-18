// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstancesResponseBody : TeaModel {
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
        /// <para>The information about the database instances that are returned.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyInstanceList InstanceList { get; set; }
        public class ListInstancesResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstanceListInstance> Instance { get; set; }
            public class ListInstancesResponseBodyInstanceListInstance : TeaModel {
                /// <summary>
                /// <para>The name of the database link for the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dblink_test</para>
                /// </summary>
                [NameInMap("DataLinkName")]
                [Validation(Required=false)]
                public string DataLinkName { get; set; }

                /// <summary>
                /// <para>The password that is used to log on to the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("DatabasePassword")]
                [Validation(Required=false)]
                public string DatabasePassword { get; set; }

                /// <summary>
                /// <para>The account that is used to log on to the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbUser</para>
                /// </summary>
                [NameInMap("DatabaseUser")]
                [Validation(Required=false)]
                public string DatabaseUser { get; set; }

                /// <summary>
                /// <para>The ID of the database administrator (DBA) of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31****</para>
                /// </summary>
                [NameInMap("DbaId")]
                [Validation(Required=false)]
                public string DbaId { get; set; }

                /// <summary>
                /// <para>The nickname of the DBA of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbaName</para>
                /// </summary>
                [NameInMap("DbaNickName")]
                [Validation(Required=false)]
                public string DbaNickName { get; set; }

                /// <summary>
                /// <para>Indicates whether the lock-free schema change feature is enabled for the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DdlOnline")]
                [Validation(Required=false)]
                public int? DdlOnline { get; set; }

                /// <summary>
                /// <para>The ID of the ECS instance on which the database instance is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150****</para>
                /// </summary>
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the database instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("EcsRegion")]
                [Validation(Required=false)]
                public string EcsRegion { get; set; }

                /// <summary>
                /// <para>The type of the environment to which the database instance belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>product:</b> production environment</description></item>
                /// <item><description><b>dev</b>: development environment</description></item>
                /// <item><description><b>pre</b>: pre-release environment</description></item>
                /// <item><description><b>test</b>: test environment</description></item>
                /// <item><description><b>sit</b>: SIT environment</description></item>
                /// <item><description><b>uat</b>: UAT environment</description></item>
                /// <item><description><b>pet</b>: stress testing environment</description></item>
                /// <item><description><b>stag:</b> staging environment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>product</para>
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
                /// <para>****.mysql.rds.aliyuncs.com</para>
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
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150***</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The source of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("InstanceSource")]
                [Validation(Required=false)]
                public string InstanceSource { get; set; }

                /// <summary>
                /// <para>The type of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The IDs of the owners of the database instance.</para>
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstanceListInstanceOwnerIdList OwnerIdList { get; set; }
                public class ListInstancesResponseBodyInstanceListInstanceOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// <para>The nicknames of the owners of the database instance.</para>
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstanceListInstanceOwnerNameList OwnerNameList { get; set; }
                public class ListInstancesResponseBodyInstanceListInstanceOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// <para>The port number that is used to connect to the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout period for querying data in the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("QueryTimeout")]
                [Validation(Required=false)]
                public int? QueryTimeout { get; set; }

                /// <summary>
                /// <para>The ID of the security rule set of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SafeRuleId")]
                [Validation(Required=false)]
                public string SafeRuleId { get; set; }

                /// <summary>
                /// <para>Indicates whether the sensitive data protection feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SellSitd")]
                [Validation(Required=false)]
                public bool? SellSitd { get; set; }

                [NameInMap("SellTrust")]
                [Validation(Required=false)]
                public string SellTrust { get; set; }

                /// <summary>
                /// <para>The system ID (SID) of the database instance.</para>
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
                public ListInstancesResponseBodyInstanceListInstanceStandardGroup StandardGroup { get; set; }
                public class ListInstancesResponseBodyInstanceListInstanceStandardGroup : TeaModel {
                    /// <summary>
                    /// <para>The type of the control mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>COMMON</b>: Security Collaboration</description></item>
                    /// <item><description><b>NONE_CONTROL</b>: Flexible Management</description></item>
                    /// <item><description><b>STABLE</b>: Stable Change</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>COMMON</para>
                    /// </summary>
                    [NameInMap("GroupMode")]
                    [Validation(Required=false)]
                    public string GroupMode { get; set; }

                    /// <summary>
                    /// <para>The name of the security rule corresponding to the control mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                }

                /// <summary>
                /// <para>The status of the database instance.</para>
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
                /// <item><description><b>1:</b>: enabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UseDsql")]
                [Validation(Required=false)]
                public int? UseDsql { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the database instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-o6wrloqsdqc9io3mg****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4B07137-F6AE-4756-8474-7F92BB6C4E04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of database instances that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
