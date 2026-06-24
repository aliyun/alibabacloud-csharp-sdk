// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UntagCloudResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The list of resource IDs. A maximum of 50 resource IDs are supported. You do not need to specify this parameter when the resource type is tenant ID.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppInstanceGroupId</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags. System tags and custom tags are supported. You can specify up to 10 tags.</para>
        /// <para>Enumerated values for system tags:</para>
        /// <list type="bullet">
        /// <item><description><c>System/Scheduler/GRAYSCALE</c>: canary release tag</description></item>
        /// <item><description><c>System/Scheduler/STOP_NEW_USER_CONNECTION</c>: tag that prevents newly bound users in a delivery group from establishing connections.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public List<string> TagKeys { get; set; }

    }

}
