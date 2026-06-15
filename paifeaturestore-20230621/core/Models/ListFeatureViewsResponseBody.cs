// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewsResponseBody : TeaModel {
        /// <summary>
        /// <para>The feature view list.</para>
        /// </summary>
        [NameInMap("FeatureViews")]
        [Validation(Required=false)]
        public List<ListFeatureViewsResponseBodyFeatureViews> FeatureViews { get; set; }
        public class ListFeatureViewsResponseBodyFeatureViews : TeaModel {
            /// <summary>
            /// <para>The feature entity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>featureEntity1</para>
            /// </summary>
            [NameInMap("FeatureEntityName")]
            [Validation(Required=false)]
            public string FeatureEntityName { get; set; }

            /// <summary>
            /// <para>The feature view ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The feature view name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>featureView1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that created the feature view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12321421412****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project1</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The ID of the data source for the registered table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RegisterDatasourceId")]
            [Validation(Required=false)]
            public string RegisterDatasourceId { get; set; }

            /// <summary>
            /// <para>The name of the data source for the registered table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>datasource1</para>
            /// </summary>
            [NameInMap("RegisterDatasourceName")]
            [Validation(Required=false)]
            public string RegisterDatasourceName { get; set; }

            /// <summary>
            /// <para>The registered table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table1</para>
            /// </summary>
            [NameInMap("RegisterTable")]
            [Validation(Required=false)]
            public string RegisterTable { get; set; }

            /// <summary>
            /// <para>The TTL (Time to Live) of features in the feature view, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("TTL")]
            [Validation(Required=false)]
            public int? TTL { get; set; }

            /// <summary>
            /// <para>The type of the feature view. Valid values:</para>
            /// <para>● Batch feature</para>
            /// <para>● Stream feature</para>
            /// 
            /// <b>Example:</b>
            /// <para>Batch</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Indicates whether data is written to the online feature store.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WriteToFeatureDB")]
            [Validation(Required=false)]
            public bool? WriteToFeatureDB { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C03B2680-AC9C-59CD-93C5-8142B92537FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of feature views.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
