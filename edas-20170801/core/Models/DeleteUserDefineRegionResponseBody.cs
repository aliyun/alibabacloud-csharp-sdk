// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeleteUserDefineRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The custom namespace.</para>
        /// </summary>
        [NameInMap("RegionDefine")]
        [Validation(Required=false)]
        public DeleteUserDefineRegionResponseBodyRegionDefine RegionDefine { get; set; }
        public class DeleteUserDefineRegionResponseBodyRegionDefine : TeaModel {
            /// <summary>
            /// <para>The ID of the region to which the custom namespace belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("BelongRegion")]
            [Validation(Required=false)]
            public string BelongRegion { get; set; }

            /// <summary>
            /// <para>The description of the custom namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logic region</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique identifier of the custom namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8848</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the custom namespace. The ID cannot be changed after the custom namespace is created. The format is <c>region ID:custom namespace ID</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:test</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the custom namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_region</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the custom namespace belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11727****22398</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234-1sda-321d-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
