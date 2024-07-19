// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteServiceInstancesRequest : TeaModel {
        /// <summary>
        /// The name of the container whose process needs to be restarted. This parameter takes effect only if the SoftRestart parameter is set to true.
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public string Container { get; set; }

        /// <summary>
        /// The instances that you want to restart. Separate multiple instance names with commas (,). For more information about how to query the instance name, see [ListServiceInstances](https://help.aliyun.com/document_detail/412108.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceList { get; set; }

        /// <summary>
        /// Specifies whether to restart only the container process without recreating the instance. Default value: false. Valid values: true and false.
        /// </summary>
        [NameInMap("SoftRestart")]
        [Validation(Required=false)]
        public bool? SoftRestart { get; set; }

    }

}
