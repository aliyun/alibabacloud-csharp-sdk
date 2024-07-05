// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateAppInfoRequest : TeaModel {
        /// <summary>
        /// The name of the application. The application name must be unique.
        /// 
        /// *   The name can contain letters, digits, periods (.), hyphens (-), and at signs (@). The name can be up to 128 characters in length.
        /// *   The value must be encoded in UTF-8.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The description of the application.
        /// 
        /// *   The description can contain up to 512 characters in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
