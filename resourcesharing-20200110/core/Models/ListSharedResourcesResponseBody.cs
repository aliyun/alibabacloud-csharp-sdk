// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListSharedResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that is used to initiate the next request. If the response of the current request is truncated, you can use the token to initiate another request and obtain the remaining records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04677DCA-7C33-464B-8811-1B1DA3C3D197</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the shared resources.</para>
        /// </summary>
        [NameInMap("SharedResources")]
        [Validation(Required=false)]
        public List<ListSharedResourcesResponseBodySharedResources> SharedResources { get; set; }
        public class ListSharedResourcesResponseBodySharedResources : TeaModel {
            /// <summary>
            /// <para>The time when the shared resource was associated with the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-07T07:39:02.921Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ResourceArn")]
            [Validation(Required=false)]
            public string ResourceArn { get; set; }

            /// <summary>
            /// <para>The ID of the shared resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1upw03qyz8n7us9****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The ID of the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rs-6GRmdD3X****</para>
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// <para>The status of the shared resource. This parameter is returned only when you query the resources that other accounts share with you.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Available: The resource is available.</description></item>
            /// <item><description>ZonalResourceInaccessible: The resource is unavailable in the current zone.</description></item>
            /// <item><description>LimitExceeded: The resource is unavailable because the maximum number of resources that other accounts can share with you exceeds the upper limit.</description></item>
            /// <item><description>Unavailable: The resource is unavailable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The cause of the association failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The reason for the association failure.</para>
            /// </summary>
            [NameInMap("ResourceStatusMessage")]
            [Validation(Required=false)]
            public string ResourceStatusMessage { get; set; }

            /// <summary>
            /// <para>The type of the shared resource.</para>
            /// <para>For more information about the types of resources that can be shared, see <a href="https://help.aliyun.com/document_detail/450526.html">Services that work with Resource Sharing</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VSwitch</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The time when the association of the shared resource was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-07T07:39:02.921Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
