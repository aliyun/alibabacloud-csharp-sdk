// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListModelFeaturesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the model features.</para>
        /// </summary>
        [NameInMap("ModelFeatureIds")]
        [Validation(Required=false)]
        public string ModelFeatureIdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the model feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model_feature1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// <list type="bullet">
        /// <item><description><para><c>ASC</c>: ascending order.</para>
        /// </description></item>
        /// <item><description><para><c>DESC</c>: descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the user who creates the model feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323143****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The project ID. You can call the <c>ListProjects</c> API to obtain the project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// <list type="bullet">
        /// <item><description><para><c>GmtCreateTime</c>: the creation time.</para>
        /// </description></item>
        /// <item><description><para><c>GmtModifiedTime</c>: the update time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
