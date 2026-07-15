// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateAppGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Information about the created Application Group.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAppGroupResponseBodyData Data { get; set; }
        public class CreateAppGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Application Group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6607</para>
            /// </summary>
            [NameInMap("AppGroupId")]
            [Validation(Required=false)]
            public long? AppGroupId { get; set; }

            /// <summary>
            /// <para>The Application Key (AppKey).</para>
            /// 
            /// <b>Example:</b>
            /// <para>adcExHZviL******</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

        }

        /// <summary>
        /// <para>The error message. Returned only when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Your request is denied as lack of ssl protect.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>883AFE93-FB03-4FA9-A958-E750C6DE120C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the Application Group was successfully created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The Application Group was successfully created.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The Application Group failed to be created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
