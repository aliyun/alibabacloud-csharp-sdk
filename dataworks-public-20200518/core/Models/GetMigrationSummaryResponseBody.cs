// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMigrationSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the migration task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMigrationSummaryResponseBodyData Data { get; set; }
        public class GetMigrationSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the user who created the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>982293332403****</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The URL that is used to download the package of the export task. You can use the URL to download the package of the export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://shanghai-xxx-oss.oss-cn-shanghai.aliyuncs.com/pre/store/f10_bf47_b4fa7df0860f.zip?Expires=1639540903&OSSAccessKeyId=XXXXXXeF4Lv5j&Signature=qxxxxx">https://shanghai-xxx-oss.oss-cn-shanghai.aliyuncs.com/pre/store/f10_bf47_b4fa7df0860f.zip?Expires=1639540903&amp;OSSAccessKeyId=XXXXXXeF4Lv5j&amp;Signature=qxxxxx</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589904000000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the task was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589904000000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("MigrationId")]
            [Validation(Required=false)]
            public long? MigrationId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_export_01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the user who managed the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>982293332403****</para>
            /// </summary>
            [NameInMap("OpUser")]
            [Validation(Required=false)]
            public string OpUser { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks workspace to which the migration task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The status of the migration task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT</description></item>
            /// <item><description>EDITING</description></item>
            /// <item><description>IMPORTING</description></item>
            /// <item><description>IMPORT_ERROR</description></item>
            /// <item><description>IMPORT_SUCCESS</description></item>
            /// <item><description>EXPORTING</description></item>
            /// <item><description>EXPORT_ERROR</description></item>
            /// <item><description>EXPORT_SUCCESS</description></item>
            /// <item><description>REVOKED</description></item>
            /// <item><description>PARTIAL_SUCCESS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXPORT_SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the request ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19999A96-71BA-2845-B455-ED620EF4E37F</para>
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
