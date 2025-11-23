// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUserOwnedResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUserOwnedResourcesResponseBodyData Data { get; set; }
        public class ListUserOwnedResourcesResponseBodyData : TeaModel {
            [NameInMap("resourceList")]
            [Validation(Required=false)]
            public List<ListUserOwnedResourcesResponseBodyDataResourceList> ResourceList { get; set; }
            public class ListUserOwnedResourcesResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// <para>The alias of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DMS_GYX_TESTupdata</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The ID of the database in DMS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29697059</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public string DbId { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>876XXX</para>
                /// </summary>
                [NameInMap("DbInstanceId")]
                [Validation(Required=false)]
                public string DbInstanceId { get; set; }

                /// <summary>
                /// <para>The database engine type. For more information about the valid values of the DbType parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
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
                /// <para>The endpoint of the instance to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-wz98bw60x1i1303c5.mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>291594</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database</description></item>
                /// <item><description><b>false</b>: The database is a physical database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The connection port of the instance to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6379</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>as_task_engine</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The query name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstest [dtstest_dms]</para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                /// <summary>
                /// <para>The table ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1760934555</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>addepmap</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

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
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the request ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8E88933E-E3D4-5BA8-8CBF-0A1CAE666690</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned. By default, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
