// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMigrationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
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
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123124123123123</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123****</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3h1_test</para>
                /// </summary>
                [NameInMap("CreateUserName")]
                [Validation(Required=false)]
                public string CreateUserName { get; set; }

                /// <summary>
                /// <para>The description of the export task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Automated Test creation</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The download URL of the export task package. You can use this URL to download the package.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://geoip-sdk-user.oss-cn-zhangjiakou.aliyuncs.com/product/v1/ipv4/trace/v1.20220424123842.dex?Expires=1650780849&OSSAccessKeyId=*****&Signature=qxxxxx">http://geoip-sdk-user.oss-cn-zhangjiakou.aliyuncs.com/product/v1/ipv4/trace/v1.20220424123842.dex?Expires=1650780849&amp;OSSAccessKeyId=*****&amp;Signature=qxxxxx</a></para>
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
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An internal system error occurred. datasource kafka region is not cn-chengdu, can\&quot;t open network for it</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The operation type of the migration task. Valid values:</para>
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
                /// <para>The name of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_task_1638498642279</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the import and export package. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DWMA: Standard format.</description></item>
                /// <item><description>DATAWORKS_MODEL: Standard format.</description></item>
                /// <item><description>DATAWORKS_V2: Apsara Stack (V3.6.1 to V3.11).</description></item>
                /// <item><description>DATAWORKS_V3: Apsara Stack (V3.12 and later).</description></item>
                /// </list>
                /// <para>DWMA and DATAWORKS_MODEL are interchangeable.</para>
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
                /// <para>The execution status of the import and export migration task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INIT: The task is in the initial state.</description></item>
                /// <item><description>EDITING: The task is being edited.</description></item>
                /// <item><description>RUNNING: The task is running.</description></item>
                /// <item><description>FAILURE: The task failed.</description></item>
                /// <item><description>SUCCESS: The task succeeded.</description></item>
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
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123123123123</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The updater.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231****</para>
                /// </summary>
                [NameInMap("UpdateUser")]
                [Validation(Required=false)]
                public string UpdateUser { get; set; }

                /// <summary>
                /// <para>The name of the updater.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3h1_test</para>
                /// </summary>
                [NameInMap("UpdateUserName")]
                [Validation(Required=false)]
                public string UpdateUserName { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: 10. Maximum value: 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which uniquely identifies the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F9198AA3-9010-53D5-9714-DC4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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
