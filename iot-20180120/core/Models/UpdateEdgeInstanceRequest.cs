// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateEdgeInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the edge instance. Valid values:
        /// 
        /// *   true: enables the edge instance.
        /// *   false: disables the edge instance.
        /// 
        /// If you do not set this parameter, this parameter is not updated.
        /// </summary>
        [NameInMap("BizEnable")]
        [Validation(Required=false)]
        public bool? BizEnable { get; set; }

        /// <summary>
        /// The ID of the edge instance. To obtain the instance ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Edge Instances** page, move the pointer over the name of the edge instance that you want to update and obtain the instance ID.
        /// 
        /// You can also call the [QueryEdgeInstance](~~135214~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the Internet of Things (IoT) service instance. This parameter is not required for the public instance but required for Enterprise Edition instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The name of the edge instance.
        /// 
        /// The name can be up to 20 characters in length and can contain letters, digits, underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The specifications of the edge instance. Valid values:
        /// 
        /// *   10: Lite Edition
        /// *   20: Standard Edition
        /// *   30: Pro Edition
        /// 
        /// If you do not set this parameter, this parameter is not updated.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public int? Spec { get; set; }

        /// <summary>
        /// The tags of the edge instance. Each tag is a key-value pair. Multiple tags are separated with commas (,). Example: `k1:v1,k2:v2`.
        /// 
        /// *   Take note of the following limits on tag keys:
        /// 
        ///     *   Tag keys cannot be left empty.
        ///     *   Tag keys must be unique in the edge instance.
        ///     *   Tag keys support only letters.
        ///     *   Each tag key can be up to 20 characters in length.
        /// 
        /// *   Take note of the following limits on tag values:
        /// 
        ///     *   Tag values cannot be left empty.
        ///     *   A tag value can contain letters, digits, underscores (\_), and hyphens (-).
        ///     *   Each tag value can be up to 20 characters in length.
        /// 
        /// If you do not set this parameter, this parameter is not updated.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
