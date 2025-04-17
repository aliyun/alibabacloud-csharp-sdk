// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListImageLabelsRequest : TeaModel {
        /// <summary>
        /// <para>The image ID. You can call <a href="https://help.aliyun.com/document_detail/449118.html">ListImages</a> to obtain the image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-4c62******53uor</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The tag filter conditions, separated with commas (,). The format of a single condition filter is <c>key=value</c>. Takes effect independently from LabelKeys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system.framework=XGBoost 1.6.0,system.official=true</para>
        /// </summary>
        [NameInMap("LabelFilter")]
        [Validation(Required=false)]
        public string LabelFilter { get; set; }

        /// <summary>
        /// <para>The tag keys, separated with commas (,). System tags start with system and take effect independently from LabelFilter.</para>
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
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
