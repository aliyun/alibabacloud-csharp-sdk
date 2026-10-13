// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListMetaProfilingResultUdfPageResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListMetaProfilingResultUdfPageResponseBodyData> Data { get; set; }
        public class ListMetaProfilingResultUdfPageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>catalog_hive_prod</para>
            /// </summary>
            [NameInMap("catalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>com.example.udf.ParseJson</para>
            /// </summary>
            [NameInMap("className")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ods</para>
            /// </summary>
            [NameInMap("dbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MYSQL</para>
            /// </summary>
            [NameInMap("dsType")]
            [Validation(Required=false)]
            public string DsType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>解析 JSON 字符串的 UDF</para>
            /// </summary>
            [NameInMap("funcComment")]
            [Validation(Required=false)]
            public string FuncComment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("funcCrtTime")]
            [Validation(Required=false)]
            public string FuncCrtTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6001</para>
            /// </summary>
            [NameInMap("funcId")]
            [Validation(Required=false)]
            public string FuncId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-20 17:52:57</para>
            /// </summary>
            [NameInMap("funcModTime")]
            [Validation(Required=false)]
            public string FuncModTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>udf_parse_json</para>
            /// </summary>
            [NameInMap("funcName")]
            [Validation(Required=false)]
            public string FuncName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UDF</para>
            /// </summary>
            [NameInMap("funcType")]
            [Validation(Required=false)]
            public string FuncType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DONE</para>
            /// </summary>
            [NameInMap("migrationStatus")]
            [Validation(Required=false)]
            public string MigrationStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://lhm-bucket/udf/parse-json.jar</para>
            /// </summary>
            [NameInMap("resourceLocation")]
            [Validation(Required=false)]
            public string ResourceLocation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>JAR</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1009318965420000</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The parameter is invalid or missing.</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
