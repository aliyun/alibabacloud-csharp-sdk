// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class TagCloudResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The resource IDs. You can specify up to 50 resource IDs. You do not need to specify this parameter if you set ResourceType to AliUid.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The type of the cloud resource.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CenterImageId: center image ID.</description></item>
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
        /// <para>The tags that you want to remove from the cloud resources. System and custom tags are supported.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for system tags:</para>
        /// <list type="bullet">
        /// <item><description><c>System/Scheduler/GRAYSCALE</c>: canary tags.</description></item>
        /// <item><description><c>System/Scheduler/STOP_NEW_USER_CONNECTION</c>: tags used to stop new users bound to the delivery group from establishing a connection.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can create up to 20 custom tags.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Each tag key on a resource can have only one tag value. If you create a tag that has the same key as an existing tag, the value of the existing tag is overwritten.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<TagCloudResourcesRequestTags> Tags { get; set; }
        public class TagCloudResourcesRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of a tag. The value must be 1 to 128 characters in length and is case-sensitive. The name must be 1 to 128 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resolution</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of a tag. The value must be 1 to 128 characters in length and is case-sensitive. The name must be 1 to 128 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>720p</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
