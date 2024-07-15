// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetUploadCredentialsRequest : TeaModel {
        /// <summary>
        /// The file name to upload.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Specifies whether the file is publicly accessible. Valid values: **public** or **private**. The default value is **private**.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
