// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ReinitInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the image file that is used to reset the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The password of the instance.
        /// 
        /// It must be 8 to 30 characters in length. It must include at least three of the following characters types: uppercase letters, lowercase letters, digits, and special characters. The following special character are supported: `()\\"~! @#$%^&*-_+={}[]:;\\"<>,.?/`
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
