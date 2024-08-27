// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateAppCodeRequest : TeaModel {
        /// <summary>
        /// The application AppCode.
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// The application ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
