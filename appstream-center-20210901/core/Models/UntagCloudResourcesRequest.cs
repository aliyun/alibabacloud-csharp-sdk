// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UntagCloudResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The resource IDs. You can specify up to 50 resource IDs. You do not need to specify this parameter if you set ResourceType to AliUid.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The type of the resource from which you want to remove tags.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AppId: app ID.</description></item>
        /// <item><description>WyId: Alibaba Cloud Workspace user ID.</description></item>
        /// <item><description>AppInstanceGroupId: delivery group ID.</description></item>
        /// <item><description>AliUid: tenant ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppInstanceGroupId</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags that you want to remove from the cloud resources. System and custom tags are supported. You can specify up to 10 tags.</para>
        /// <para>Valid values for system tags:</para>
        /// <list type="bullet">
        /// <item><description><c>System/Scheduler/GRAYSCALE</c>: canary tags.</description></item>
        /// <item><description><c>System/Scheduler/STOP_NEW_USER_CONNECTION</c>: tags used to stop new users bound to the delivery group from establishing a connection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public List<string> TagKeys { get; set; }

    }

}
