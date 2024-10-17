// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetPermApplyOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of the permission application ticket.</para>
        /// </summary>
        [NameInMap("PermApplyOrderDetail")]
        [Validation(Required=false)]
        public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetail PermApplyOrderDetail { get; set; }
        public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetail : TeaModel {
            /// <summary>
            /// <para>The type of objects on which you apply for permissions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DB</b>: database</description></item>
            /// <item><description><b>TAB</b>: table</description></item>
            /// <item><description><b>COL</b>: column</description></item>
            /// <item><description><b>INSTANT</b>: instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DB</para>
            /// </summary>
            [NameInMap("ApplyType")]
            [Validation(Required=false)]
            public string ApplyType { get; set; }

            /// <summary>
            /// <para>The type of the permissions that you apply for. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: the permissions to query information.</description></item>
            /// <item><description><b>2</b>: the permissions to export information.</description></item>
            /// <item><description><b>3</b>: the permissions to query and export information.</description></item>
            /// <item><description><b>4</b>: the permissions to modify information.</description></item>
            /// <item><description><b>5</b>: the permissions to query and modify information.</description></item>
            /// <item><description><b>6</b>: the permissions to export and modify information.</description></item>
            /// <item><description><b>7</b>: the permissions to query, export, and modify information.</description></item>
            /// <item><description><b>8</b>: the permissions to log on to the database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("PermType")]
            [Validation(Required=false)]
            public long? PermType { get; set; }

            /// <summary>
            /// <para>The list of resources.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResources> Resources { get; set; }
            public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResources : TeaModel {
                /// <summary>
                /// <para>The information about the column.</para>
                /// </summary>
                [NameInMap("ColumnInfo")]
                [Validation(Required=false)]
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesColumnInfo ColumnInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesColumnInfo : TeaModel {
                    /// <summary>
                    /// <para>The name of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_col</para>
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// <para>The name of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_tb</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// <para>The information about the database.</para>
                /// </summary>
                [NameInMap("DatabaseInfo")]
                [Validation(Required=false)]
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesDatabaseInfo DatabaseInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesDatabaseInfo : TeaModel {
                    /// <summary>
                    /// <para>The database ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public long? DbId { get; set; }

                    /// <summary>
                    /// <para>The type of the database engine.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL</para>
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// <para>The type of the environment to which the instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/163309.html">Change the environment type of an instance</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>product</para>
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the database is a logical database. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public bool? Logic { get; set; }

                    /// <summary>
                    /// <para>The IDs of the owners of the database.</para>
                    /// </summary>
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    /// <summary>
                    /// <para>The nicknames of the owners of the database.</para>
                    /// </summary>
                    [NameInMap("OwnerNickNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNickNames { get; set; }

                    /// <summary>
                    /// <para>The name that is used to search for the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test@xxxx:3306【test】</para>
                    /// </summary>
                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                }

                /// <summary>
                /// <para>The information about the instance.</para>
                /// </summary>
                [NameInMap("InstanceInfo")]
                [Validation(Required=false)]
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesInstanceInfo InstanceInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesInstanceInfo : TeaModel {
                    /// <summary>
                    /// <para>The type of the database engine.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL</para>
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// <para>The ID of the database administrator (DBA) of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("DbaId")]
                    [Validation(Required=false)]
                    public long? DbaId { get; set; }

                    /// <summary>
                    /// <para>The nickname of the DBA of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_dba</para>
                    /// </summary>
                    [NameInMap("DbaNickName")]
                    [Validation(Required=false)]
                    public string DbaNickName { get; set; }

                    /// <summary>
                    /// <para>The type of the environment to which the instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/163309.html">Change the environment type of an instance</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>product</para>
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// <para>The endpoint of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxxx</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The IDs of the owners of the instance.</para>
                    /// </summary>
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    /// <summary>
                    /// <para>The nicknames of the owners of the instance.</para>
                    /// </summary>
                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public List<string> OwnerNickName { get; set; }

                    /// <summary>
                    /// <para>The port that is used to connect to the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public long? Port { get; set; }

                    /// <summary>
                    /// <para>The name that is used to search for the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxxx:3306</para>
                    /// </summary>
                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                }

                /// <summary>
                /// <para>The information about the table.</para>
                /// </summary>
                [NameInMap("TableInfo")]
                [Validation(Required=false)]
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesTableInfo TableInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesTableInfo : TeaModel {
                    /// <summary>
                    /// <para>The name of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_tb</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

            }

            /// <summary>
            /// <para>The validity duration of the permissions. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Seconds")]
            [Validation(Required=false)]
            public long? Seconds { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4C4499E-5AC2-4318-9FCF-03E426781A04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
