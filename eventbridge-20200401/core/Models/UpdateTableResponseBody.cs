// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateTableResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TableARN&quot;:&quot;acs:eventbridge:cn-hangzhou:123456789:catalog/my_catalog/namespace/my_namespace/table/my_table&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateTableResponseBodyData Data { get; set; }
        public class UpdateTableResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Table ARN</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:eventbridge:cn-hangzhou:123456789:catalog/my_catalog/namespace/my_namespace/table/my_table</para>
            /// </summary>
            [NameInMap("TableARN")]
            [Validation(Required=false)]
            public string TableARN { get; set; }

        }

        /// <summary>
        /// <para>API return message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
