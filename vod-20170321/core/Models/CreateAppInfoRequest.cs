// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateAppInfoRequest : TeaModel {
        /// <summary>
        /// The name of the application, which must be unique. 
        /// 
        /// - The name can contain up to 128 characters in length, including Chinese letters, digits, and periods (.), dash (-), and at character (@).
        /// - The name can contain only UTF-8 characters.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The description of the application. 
        /// - The description can contain up to 512 characters in length.
        /// - The description can contain only UTF-8 characters.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
