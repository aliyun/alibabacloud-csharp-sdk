// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Paged query results of data quality rule templates.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListDataQualityTemplatesResponseBodyPageInfo PageInfo { get; set; }
        public class ListDataQualityTemplatesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The list of rule templates.</para>
            /// </summary>
            [NameInMap("DataQualityTemplates")]
            [Validation(Required=false)]
            public List<ListDataQualityTemplatesResponseBodyPageInfoDataQualityTemplates> DataQualityTemplates { get; set; }
            public class ListDataQualityTemplatesResponseBodyPageInfoDataQualityTemplates : TeaModel {
                /// <summary>
                /// <para>The time when the data quality rule template was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1729816478147</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator of the data quality rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7892346529452</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The ID of the data quality rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>819cf1f8-29be-4f94-a9d0-c5c06c0c3d2a</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The time when the data quality rule template was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1729816478147</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The last updater of the data quality rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>205250754596036836</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The owner of the data quality rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>205250754596036836</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7635</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>Specific configurations of the data quality rule template. For more information, see <a href="~2963394~">Data quality Spec configuration description</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;assertion&quot;: &quot;anomaly detection fro id_not_null_cnt&quot;,
                ///     &quot;id_not_null_cnt&quot;: {
                ///         &quot;query&quot;: &quot;SELECT COUNT(*) AS cnt FROM ${tableName} WHERE dt = \&quot;$[yyyymmdd-1]\&quot;;&quot;
                ///     },
                ///     &quot;identity&quot;: &quot;819cf1f8-29be-4f94-a9d0-c5c06c0c3d2a&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

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
            /// <para>The number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The API request ID, which is generated as a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc14115***159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
