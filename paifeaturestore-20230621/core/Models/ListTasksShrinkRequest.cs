// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListTasksShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the object. You can call the ListModelFeatures or ListFeatureViews operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The type of the object.</para>
        /// <para>● <c>ModelFeature</c>: a model feature.</para>
        /// <para>● <c>FeatureView</c>: a feature view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModelFeature</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the project. You can call the ListProjects operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// <para>● <c>Initializing</c>: The task is being initialized.</para>
        /// <para>● <c>Running</c>: The task is running.</para>
        /// <para>● <c>Success</c>: The task is successful.</para>
        /// <para>● <c>Failure</c>: The task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task IDs by which to filter tasks.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIdsShrink { get; set; }

        /// <summary>
        /// <para>The task type by which to filter tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OfflineToOnline</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
