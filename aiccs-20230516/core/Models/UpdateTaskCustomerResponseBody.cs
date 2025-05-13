// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class UpdateTaskCustomerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public UpdateTaskCustomerResponseBodyModel Model { get; set; }
        public class UpdateTaskCustomerResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>错误手机列表</para>
            /// </summary>
            [NameInMap("UnHandleNumbers")]
            [Validation(Required=false)]
            public List<string> UnHandleNumbers { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8EFC6D10-307B-1ECA-A8C6-7CBDF776AAD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1683440860035</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
