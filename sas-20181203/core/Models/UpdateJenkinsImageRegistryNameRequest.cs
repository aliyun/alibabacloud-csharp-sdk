// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateJenkinsImageRegistryNameRequest : TeaModel {
        /// <summary>
        /// The ID of the image repository.
        /// 
        /// > You can call the [PageImageRegistry](~~PageImageRegistry~~) operation to query the IDs of image repositories.
        /// </summary>
        [NameInMap("RegistryId")]
        [Validation(Required=false)]
        public long? RegistryId { get; set; }

        /// <summary>
        /// The name of the image repository.
        /// </summary>
        [NameInMap("RegistryName")]
        [Validation(Required=false)]
        public string RegistryName { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
