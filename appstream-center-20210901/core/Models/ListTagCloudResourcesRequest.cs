// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListTagCloudResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Maximum value: 1000. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ptnJAAAAAAAxNzE5OTEwNQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The tag type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>All (default): all tags.</description></item>
        /// <item><description>Custom: custom tag.</description></item>
        /// <item><description>System: system tag.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
