// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateLaunchTemplateVersionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the launch template. For more information, see [DescribeLaunchTemplates](https://help.aliyun.com/document_detail/73759.html).
        /// 
        /// You must specify `LaunchTemplateId` or `LaunchTemplateName` to specify a launch template.
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// The version number of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateVersionNumber")]
        [Validation(Required=false)]
        public long? LaunchTemplateVersionNumber { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
