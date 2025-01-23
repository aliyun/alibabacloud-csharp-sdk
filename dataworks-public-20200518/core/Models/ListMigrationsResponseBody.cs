// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMigrationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMigrationsResponseBodyData Data { get; set; }
        public class ListMigrationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of migration tasks.</para>
            /// </summary>
            [NameInMap("Migrations")]
            [Validation(Required=false)]
            public List<ListMigrationsResponseBodyDataMigrations> Migrations { get; set; }
            public class ListMigrationsResponseBodyDataMigrations : TeaModel {
                /// <summary>
                /// <para>The time when the migration task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123124123123123</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who created the migration task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123****</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The name of the user who created the migration task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3h1_test</para>
                /// </summary>
                [NameInMap("CreateUserName")]
                [Validation(Required=false)]
                public string CreateUserName { get; set; }

                /// <summary>
                /// <para>The description of the export task.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The URL that is used to download the package of the export task. You can use the URL to download the package of the export task.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://geoip-sdk-user.oss-cn-zhangjiakou.aliyuncs.com/product/v1/ipv4/trace/v1.20220424123842.dex?Expires=1650780849&OSSAccessKeyId=XXXXXXeF4Lv5j&Signature=qxxxxx">http://geoip-sdk-user.oss-cn-zhangjiakou.aliyuncs.com/product/v1/ipv4/trace/v1.20220424123842.dex?Expires=1650780849&amp;OSSAccessKeyId=XXXXXXeF4Lv5j&amp;Signature=qxxxxx</a></para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>436064</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The error message returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An internal system error occurred. datasource kafka region is not cn-chengdu, can\&quot;t open network for it</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The type of the migration task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IMPORT</description></item>
                /// <item><description>EXPORT</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EXPORT</para>
                /// </summary>
                [NameInMap("MigrationType")]
                [Validation(Required=false)]
                public string MigrationType { get; set; }

                /// <summary>
                /// <para>The name of the migration task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_task_1638498642279</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the import or export package. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DWMA (standard format)</description></item>
                /// <item><description>DATAWORKS_MODEL (standard format)</description></item>
                /// <item><description>DATAWORKS_V2 (Apsara Stack DataWorks V3.6.1 to V3.11)</description></item>
                /// <item><description>DATAWORKS_V3 (Apsara Stack DataWorks V3.12 and later)</description></item>
                /// </list>
                /// <para>The DWMA and DATAWORKS_MODEL types are interchangeable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATAWORKS_MODEL</para>
                /// </summary>
                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace to which the task belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72132</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The status of the migration task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INIT: The migration task is in the initial state.</description></item>
                /// <item><description>EDITING: The migration task is being edited.</description></item>
                /// <item><description>RUNNING: The migration task is running.</description></item>
                /// <item><description>FAILURE: The migration task fails to run.</description></item>
                /// <item><description>SUCCESS: The migration task is successfully run.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16307</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

                /// <summary>
                /// <para>The time when the migration task was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123123123123</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who last updated the migration task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231****</para>
                /// </summary>
                [NameInMap("UpdateUser")]
                [Validation(Required=false)]
                public string UpdateUser { get; set; }

                /// <summary>
                /// <para>The name of the user who last updated the migration task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3h1_test</para>
                /// </summary>
                [NameInMap("UpdateUserName")]
                [Validation(Required=false)]
                public string UpdateUserName { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F9198AA3-9010-53D5-9714-DC4461427D3E</para>
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
