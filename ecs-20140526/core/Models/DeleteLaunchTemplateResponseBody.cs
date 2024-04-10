// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteLaunchTemplateResponseBody : TeaModel {
        /// <summary>
        /// The ID of the launch template. For more information, see [DescribeLaunchTemplates](~~73759~~).
        /// 
        /// You must specify `LaunchTemplateId` or `LaunchTemplateName` to specify a launch template.
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// The versions of the deleted launch template.
        /// </summary>
        [NameInMap("LaunchTemplateVersionNumbers")]
        [Validation(Required=false)]
        public DeleteLaunchTemplateResponseBodyLaunchTemplateVersionNumbers LaunchTemplateVersionNumbers { get; set; }
        public class DeleteLaunchTemplateResponseBodyLaunchTemplateVersionNumbers : TeaModel {
            [NameInMap("versionNumbers")]
            [Validation(Required=false)]
            public List<long?> VersionNumbers { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
