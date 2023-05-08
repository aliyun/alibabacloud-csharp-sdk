// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DeleteServiceMeshRequest : TeaModel {
        /// <summary>
        /// A JSON string that can be parsed into a string array. You can use this JSON string to specify the IDs of the resource instances that need to be retained when the ASM instance is deleted.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RetainResources")]
        [Validation(Required=false)]
        public string RetainResources { get; set; }

        /// <summary>
        /// Specifies whether to forcibly delete the ASM instance. Valid values:
        /// 
        /// *   `true`: forcibly deletes the ASM instance.
        /// *   `false`: does not forcibly delete the ASM instance.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
