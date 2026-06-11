// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataCenterDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of databases.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataCenterDatabaseResponseBodyData> Data { get; set; }
        public class ListDataCenterDatabaseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a sample database.</para>
            /// </summary>
            [NameInMap("DatabaseDesc")]
            [Validation(Required=false)]
            public string DatabaseDesc { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// <list type="bullet">
            /// <item><description>If <c>ImportType</c> is <c>FILE</c>, this is the file name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>diamonds.csv</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6kv159u9vtpvl**********b8</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public string DbId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>If <c>ImportType</c> is <c>FILE</c>:</para>
            /// <list type="bullet">
            /// <item><description>The file format, such as <c>csv</c>, <c>xlsx</c>, or <c>xls</c>.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>csv</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The time the database description was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("DescUpdateTime")]
            [Validation(Required=false)]
            public string DescUpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the database in DMS.</para>
            /// <list type="bullet">
            /// <item><description>This parameter is not returned if <c>ImportType</c> is <c>FILE</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>73088962</para>
            /// </summary>
            [NameInMap("DmsDbId")]
            [Validation(Required=false)]
            public long? DmsDbId { get; set; }

            /// <summary>
            /// <para>The ID of the DMS instance that manages the database.</para>
            /// <list type="bullet">
            /// <item><description>This parameter is not returned if <c>ImportType</c> is <c>FILE</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2740966</para>
            /// </summary>
            [NameInMap("DmsInstanceId")]
            [Validation(Required=false)]
            public long? DmsInstanceId { get; set; }

            [NameInMap("DownloadLink")]
            [Validation(Required=false)]
            public string DownloadLink { get; set; }

            /// <summary>
            /// <para>The time the entry was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The import type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>FILE</para>
            /// </description></item>
            /// <item><description><para>RDS</para>
            /// </description></item>
            /// <item><description><para>ADB</para>
            /// </description></item>
            /// <item><description><para>PolarDB</para>
            /// </description></item>
            /// <item><description><para>Hologres</para>
            /// </description></item>
            /// <item><description><para>DMS</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FILE</para>
            /// </summary>
            [NameInMap("ImportType")]
            [Validation(Required=false)]
            public string ImportType { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// <list type="bullet">
            /// <item><description>If <c>ImportType</c> is <c>FILE</c>, this parameter specifies the file ID in the data center.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>f-ean8u5881qk4*********xh5y</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("IntranetDownloadLink")]
            [Validation(Required=false)]
            public string IntranetDownloadLink { get; set; }

            /// <summary>
            /// <para>Indicates whether the dataset is built-in. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Y: The dataset is built-in.</para>
            /// </description></item>
            /// <item><description><para>N: The dataset is not built-in.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("IsInternal")]
            [Validation(Required=false)]
            public string IsInternal { get; set; }

            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <para>The size of the file, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>999</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("UseUserOssBucket")]
            [Validation(Required=false)]
            public bool? UseUserOssBucket { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
