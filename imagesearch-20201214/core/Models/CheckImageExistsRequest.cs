// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class CheckImageExistsRequest : TeaModel {
        /// <summary>
        /// <para>Image Search instance name. Supports up to 20 characters.<br>If you have already purchased an Image Search instance, you can logon to the <a href="https://imagesearch.console.aliyun.com/">Image Search console</a> to view it.<br>If you have not purchased an Image Search instance, see <a href="https://help.aliyun.com/document_detail/179178.html">Activate the service</a> and <a href="https://help.aliyun.com/document_detail/66569.html">Create an instance</a>.  </para>
        /// <remarks>
        /// <para>The instance name here is not the instance ID. Please distinguish between them when using.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demoinstance1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Image name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1</para>
        /// </summary>
        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        /// <summary>
        /// <para>Product ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

    }

}
