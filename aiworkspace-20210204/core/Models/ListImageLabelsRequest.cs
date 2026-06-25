// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListImageLabelsRequest : TeaModel {
        /// <summary>
        /// <para>The image ID. For more information about how to obtain an image ID, see <a href="https://help.aliyun.com/document_detail/449118.html">ListImages</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-4c62******53uor</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The filter conditions for labels. Separate multiple conditions with commas.
        /// The format for a single condition is <c>key=value</c>.
        /// This parameter works independently of the LabelKeys parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system.framework=XGBoost 1.6.0,system.official=true</para>
        /// </summary>
        [NameInMap("LabelFilter")]
        [Validation(Required=false)]
        public string LabelFilter { get; set; }

        /// <summary>
        /// <para>The list of tag keys. Separate multiple keys with commas (,).
        /// System tags start with &quot;system&quot;. This parameter works independently of the LabelFilter parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system.framework,system.official</para>
        /// </summary>
        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public string LabelKeys { get; set; }

        /// <summary>
        /// <para>The region where the image resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The workspace ID. For more information about how to obtain a workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
