// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class MoveResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C00B89D3-3247-11DE-95D8-A7C01FB0AB4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response results.</para>
        /// </summary>
        [NameInMap("Responses")]
        [Validation(Required=false)]
        public List<MoveResourcesResponseBodyResponses> Responses { get; set; }
        public class MoveResourcesResponseBodyResponses : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// <remarks>
            /// <para>This parameter is returned when the resource transfer fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>NoPermission</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// <remarks>
            /// <para>This parameter is returned when the resource transfer fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>No permission</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The ID of the region to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C00B89D3-3247-11DE-95D8-A7C01FB0AB4F</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-23v38****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The code of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUCCESS: Succeeded.</description></item>
            /// <item><description>FAIL: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FAIL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
