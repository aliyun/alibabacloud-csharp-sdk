// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateLaunchTemplateVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the launch template. For more information, see <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a>.</para>
        /// <para>You must specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to specify a launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp1apo0bbbkuy0rj****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The number of the created version of the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersionNumber")]
        [Validation(Required=false)]
        public long? LaunchTemplateVersionNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DExxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
