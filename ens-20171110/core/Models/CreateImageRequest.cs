// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateImageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically release the instance after the image is packaged and uploaded. Only image builders are supported. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The image is released when the instance is released.</description></item>
        /// <item><description>false: The image is retained when the instance is released.</description></item>
        /// <item><description>If you leave this parameter empty, the default value is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteAfterImageUpload")]
        [Validation(Required=false)]
        public string DeleteAfterImageUpload { get; set; }

        /// <summary>
        /// <para>The name of the image. The name must be 2 to 128 characters in length. The name can contain letters, digits, colons (:), underscores (<em>), and hyphens (-). It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (</em>), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5rr1bnyrc4tswr8cq3w6y****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
