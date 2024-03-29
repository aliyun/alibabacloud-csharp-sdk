// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateLaunchTemplateVersionResponseBody : TeaModel {
        /// <summary>
        /// 启动模板ID。更多信息，请参见[DescribeLaunchTemplates](~~73759~~)。
        /// 
        /// 使用启动模板创建实例时，您必须指定`LaunchTemplateId`或`LaunchTemplateName`以确定启动模板。
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
