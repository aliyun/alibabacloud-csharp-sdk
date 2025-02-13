// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DeleteImageRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demoinstance1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("IsDeleteByFilter")]
        [Validation(Required=false)]
        public bool? IsDeleteByFilter { get; set; }

        /// <summary>
        /// <para>The name of the image.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not set, the system deletes all the images that correspond to the specified ProductId parameter.</description></item>
        /// <item><description>If this parameter is set, the system deletes only the image that is specified by the ProductId and PicName parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1.jpg</para>
        /// </summary>
        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        /// <summary>
        /// <para>The ID of the commodity.</para>
        /// <remarks>
        /// <para> A commodity may have multiple images.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

    }

}
