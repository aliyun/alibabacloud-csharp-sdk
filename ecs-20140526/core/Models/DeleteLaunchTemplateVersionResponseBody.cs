// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteLaunchTemplateVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The deleted launch template versions.</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersions")]
        [Validation(Required=false)]
        public DeleteLaunchTemplateVersionResponseBodyLaunchTemplateVersions LaunchTemplateVersions { get; set; }
        public class DeleteLaunchTemplateVersionResponseBodyLaunchTemplateVersions : TeaModel {
            [NameInMap("LaunchTemplateVersion")]
            [Validation(Required=false)]
            public List<DeleteLaunchTemplateVersionResponseBodyLaunchTemplateVersionsLaunchTemplateVersion> LaunchTemplateVersion { get; set; }
            public class DeleteLaunchTemplateVersionResponseBodyLaunchTemplateVersionsLaunchTemplateVersion : TeaModel {
                /// <summary>
                /// <para>The ID of the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lt-m5eiaupmvm2op9d****</para>
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// <para>The version number of the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LaunchTemplateVersionNumber")]
                [Validation(Required=false)]
                public long? LaunchTemplateVersionNumber { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
