// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewsResponseBody : TeaModel {
        [NameInMap("FeatureViews")]
        [Validation(Required=false)]
        public List<ListFeatureViewsResponseBodyFeatureViews> FeatureViews { get; set; }
        public class ListFeatureViewsResponseBodyFeatureViews : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>featureEntity1</para>
            /// </summary>
            [NameInMap("FeatureEntityName")]
            [Validation(Required=false)]
            public string FeatureEntityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>featureView1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12321421412****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>project1</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RegisterDatasourceId")]
            [Validation(Required=false)]
            public string RegisterDatasourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>datasource1</para>
            /// </summary>
            [NameInMap("RegisterDatasourceName")]
            [Validation(Required=false)]
            public string RegisterDatasourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>table1</para>
            /// </summary>
            [NameInMap("RegisterTable")]
            [Validation(Required=false)]
            public string RegisterTable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("TTL")]
            [Validation(Required=false)]
            public int? TTL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Batch</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("WriteToFeatureDB")]
            [Validation(Required=false)]
            public bool? WriteToFeatureDB { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C03B2680-AC9C-59CD-93C5-8142B92537FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
