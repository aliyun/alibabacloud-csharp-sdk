// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// The image tag of the operating system. The tag is used only for management nodes.
        /// </summary>
        [NameInMap("BaseOsTag")]
        [Validation(Required=false)]
        public string BaseOsTag { get; set; }

        /// <summary>
        /// The instance type of the node.
        /// 
        /// *   If a value is passed to the parameter, the list of images that are supported by the specified instance type is queried.
        /// *   If no value is passed to the parameter, the list of images that are supported by all instance types is queried.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
