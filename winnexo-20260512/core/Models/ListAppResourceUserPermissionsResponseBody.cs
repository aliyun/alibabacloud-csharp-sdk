// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAppResourceUserPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The resources and permissions on the current page.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListAppResourceUserPermissionsResponseBodyItems> Items { get; set; }
        public class ListAppResourceUserPermissionsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The stored and valid permission points.</para>
            /// </summary>
            [NameInMap("permissions")]
            [Validation(Required=false)]
            public List<string> Permissions { get; set; }

            /// <summary>
            /// <para>The resource key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app.demo.resource_1</para>
            /// </summary>
            [NameInMap("resourceKey")]
            [Validation(Required=false)]
            public string ResourceKey { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APP_RESOURCE</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The error description. This parameter is empty if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
