// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ReleaseInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid_Product_Code</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReleaseInstanceResponseBodyData Data { get; set; }
        public class ReleaseInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The site of the execution host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReleaseResult")]
            [Validation(Required=false)]
            public bool? ReleaseResult { get; set; }

        }

        /// <summary>
        /// <para>The description of the execution result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UUID</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A value of true indicates that the execution is complete.</para>
        /// <para>A value of false indicates that an error occurs during the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
