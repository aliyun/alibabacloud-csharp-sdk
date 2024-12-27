// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class UpdateLocationDateClusterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The custom ID of the cluster. When the cluster is indexed into the dataset, the custom ID is stored as the data attribute. You can map the custom ID to other data in your business system. For example, you can pass the custom ID to map a URI to an ID. We recommend that you specify a globally unique value. The value can be up to 1,024 bytes in size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>member-id-0001</para>
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// <para>The custom labels. The parameter stores custom key-value labels, which can be used to filter data. You can specify up to 100 custom labels for a cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;UserScore&quot;: &quot;5&quot;
        /// }</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public string CustomLabelsShrink { get; set; }

        /// <summary>
        /// <para>The name of the dataset.<a href="~~478160~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The ID of the cluster that you want to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>location-date-cluster-71dd4f32-9597-4085-a2ab-3a7b0fd0aff9</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The name of the cluster. The name can be used to search for the cluster. The value can be up to 1,024 bytes in size.</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
