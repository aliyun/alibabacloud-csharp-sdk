// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAuthorizedInstancesForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instances on which the user has permissions.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListAuthorizedInstancesForUserResponseBodyInstances> Instances { get; set; }
        public class ListAuthorizedInstancesForUserResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The database engine that the instance runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The type of the environment to which the database instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The endpoint that is used to connect to the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2zex9lrc0gz0****.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The alias of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DMS_TEST</para>
            /// </summary>
            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The details of permissions. The format of the permission details varies with the permission source. For example, if the permission source is a normal permission, the following parameters are returned.</para>
            /// </summary>
            [NameInMap("PermissionDetail")]
            [Validation(Required=false)]
            public ListAuthorizedInstancesForUserResponseBodyInstancesPermissionDetail PermissionDetail { get; set; }
            public class ListAuthorizedInstancesForUserResponseBodyInstancesPermissionDetail : TeaModel {
                /// <summary>
                /// <para>The type of object on which the operation is performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATABASE</para>
                /// </summary>
                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// <para>The time when the permission expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-06 10:00:00</para>
                /// </summary>
                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public string ExpireDate { get; set; }

                /// <summary>
                /// <para>If the permission source is a permission policy, the value of this parameter includes the policy name and the operations that are allowed for the user.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The type of the permission. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>QUERY</b>: the query permission</description></item>
                /// <item><description><b>EXPORT</b>: the data export permission</description></item>
                /// <item><description><b>CORRECT</b>: the data change permission</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CORRECT</para>
                /// </summary>
                [NameInMap("PermType")]
                [Validation(Required=false)]
                public string PermType { get; set; }

            }

            /// <summary>
            /// <para>The port number that is used to connect to the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The user IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The user name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_test</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7DB89CC-017D-5503-8953-38FFE241A618</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
