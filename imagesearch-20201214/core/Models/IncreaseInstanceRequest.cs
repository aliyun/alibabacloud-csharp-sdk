// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class IncreaseInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the bucket.</para>
        /// <remarks>
        /// <para>Only a bucket in the same region as the instance is supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketName</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The callback URL of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxxx">http://xxxxx</a></para>
        /// </summary>
        [NameInMap("CallbackAddress")]
        [Validation(Required=false)]
        public string CallbackAddress { get; set; }

        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length.
        /// If you have purchased an Image Search instance, log on to the <a href="https://imagesearch.console.aliyun.com/">Image Search console</a> to view the instance name.
        /// If you have not purchased an Image Search instance, refer to <a href="https://help.aliyun.com/document_detail/179178.html">Activate the service</a> and <a href="https://help.aliyun.com/document_detail/66569.html">Create an instance</a>.</para>
        /// <remarks>
        /// <para>The instance name is not the instance ID. Make sure that you distinguish between the two.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imagesearchName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The absolute path of the increment.meta file in OSS. The path must start with a forward slash (/) and must not end with a forward slash (/).</para>
        /// <remarks>
        /// <para>Prepare the increment.meta file in advance. For more information, see <a href="https://help.aliyun.com/document_detail/66580.html">Batch operations</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/xxx/xxx</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
