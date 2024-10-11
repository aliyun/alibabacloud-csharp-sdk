// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateImageInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the images that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistImageIds")]
        [Validation(Required=false)]
        public UpdateImageInfosResponseBodyNonExistImageIds NonExistImageIds { get; set; }
        public class UpdateImageInfosResponseBodyNonExistImageIds : TeaModel {
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public List<string> ImageId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
