// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListProjectFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned features.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<ListProjectFeaturesResponseBodyFeatures> Features { get; set; }
        public class ListProjectFeaturesResponseBodyFeatures : TeaModel {
            /// <summary>
            /// <para>A comma-separated list of aliases for the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age1,age2</para>
            /// </summary>
            [NameInMap("AliasNames")]
            [Validation(Required=false)]
            public string AliasNames { get; set; }

            /// <summary>
            /// <para>The ID of the parent feature view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            /// <summary>
            /// <para>The name of the parent feature view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fv1</para>
            /// </summary>
            [NameInMap("FeatureViewName")]
            [Validation(Required=false)]
            public string FeatureViewName { get; set; }

            /// <summary>
            /// <para>The time the feature was created, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The number of model features that reference this feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ModelFeatureCount")]
            [Validation(Required=false)]
            public int? ModelFeatureCount { get; set; }

            /// <summary>
            /// <para>The name of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The data type of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The total number of features that match the query criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D497816-607C-5B67-97B1-61354B6ACB2B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
