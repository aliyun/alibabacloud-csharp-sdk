// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteImageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the image. You can specify only one image ID.</para>
        /// <para>You can delete only custom images that you created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-5taesrgwpo9zqj9cjqu792****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

    }

}
