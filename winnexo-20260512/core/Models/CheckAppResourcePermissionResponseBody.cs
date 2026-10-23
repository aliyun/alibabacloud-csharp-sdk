// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CheckAppResourcePermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the target user has the permission on the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allowed")]
        [Validation(Required=false)]
        public bool? Allowed { get; set; }

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
        /// <para>The error description. This field is empty if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The target permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP/VIEW</para>
        /// </summary>
        [NameInMap("permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The dot-separated resource key. The first segment is the APP application key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app.demo.resource_1</para>
        /// </summary>
        [NameInMap("resourceKey")]
        [Validation(Required=false)]
        public string ResourceKey { get; set; }

        /// <summary>
        /// <para>The resource type. Set the value to APP_RESOURCE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP_RESOURCE</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
