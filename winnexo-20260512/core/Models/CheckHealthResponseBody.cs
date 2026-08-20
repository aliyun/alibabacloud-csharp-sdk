// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CheckHealthResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication source: bearer / aliyun_gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_gateway</para>
        /// </summary>
        [NameInMap("authSource")]
        [Validation(Required=false)]
        public string AuthSource { get; set; }

        /// <summary>
        /// <para>The caller type: user / aliyun_main / aliyun_ram / service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_main</para>
        /// </summary>
        [NameInMap("callerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The name of the currently effective digital employee. This value is empty if not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcitc-magent</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeName { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F4A9EB1C-6952-5CCC-B1DC-355576FC82A7</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The effective tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21577</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <para>The platform user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
