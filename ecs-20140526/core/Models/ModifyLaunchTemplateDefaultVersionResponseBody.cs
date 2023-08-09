// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyLaunchTemplateDefaultVersionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the launch template. For more information, see [DescribeLaunchTemplates](~~73759~~). You must specify `LaunchTemplateId` or `LaunchTemplateName` to specify a launch template.
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
