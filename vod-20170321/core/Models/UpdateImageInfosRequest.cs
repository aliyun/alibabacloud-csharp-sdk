// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateImageInfosRequest : TeaModel {
        /// <summary>
        /// The new information about the one or more images. You can modify the information about up to 20 images at a time. For more information about the parameter structure, see the **UpdateContent** section.
        /// 
        /// >  The values of the nested parameters Title, Description, and Tags under the UpdateContent parameter cannot contain emoticons.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
