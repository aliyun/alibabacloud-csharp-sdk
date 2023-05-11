// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateEdgeInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the Internet of Things (IoT) service instance. This parameter is not required for public instances. However, this parameter is required for the instances that you have purchased.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The name of the edge instance.
        /// 
        /// An instance name cannot exceed 20 characters in length and can contain uppercase letters, lowercase letters, digits, underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The specification of the edge instance.
        /// 
        /// *   10: Lite Edition.
        /// *   20: Standard Edition.
        /// *   30: Pro Edition.
        /// 
        /// Default value: 20.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public int? Spec { get; set; }

        /// <summary>
        /// The tags of the edge instance. Syntax of a tag: `key:value`. Multiple tags are separated with commas (,), for example, `k1:v1,k2:v2`.
        /// 
        /// *   Note the following limits on tag keys:
        /// 
        ///     *   Tag values cannot be left empty.
        ///     *   Tag keys must be unique in the edge instance.
        ///     *   Tag keys only support letters.
        ///     *   Each tag key cannot exceed 20 characters in length.
        /// 
        /// *   Note the following limits on tag values:
        /// 
        ///     *   Tag values cannot be left empty.
        ///     *   A tag value can contain uppercase letters, lowercase letters, digits, underscores (\_), and hyphens (-).
        ///     *   Each tag value cannot exceed 20 characters in length.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
