// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results by feature name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature1</para>
        /// </summary>
        [NameInMap("FeatureName")]
        [Validation(Required=false)]
        public string FeatureName { get; set; }

        /// <summary>
        /// <para>The feature view IDs by which to filter the results.</para>
        /// </summary>
        [NameInMap("FeatureViewIds")]
        [Validation(Required=false)]
        public string FeatureViewIdsShrink { get; set; }

        /// <summary>
        /// <para>Filters the results by feature view name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fv1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values: <c>Desc</c> (descending) and <c>Asc</c> (ascending).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>Filters the results by owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1232143243242****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number of the results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of feature views to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The project ID. You can obtain this ID by calling the <c>ListProjects</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Filters the results by tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>Filters the results by type. Valid values:</para>
        /// <para>● <c>Batch</c>: batch feature</para>
        /// <para>● <c>Stream</c>: stream feature</para>
        /// 
        /// <b>Example:</b>
        /// <para>Batch</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
