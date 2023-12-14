// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeLogFieldsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeLogFieldsResponseBodyData> Data { get; set; }
        public class DescribeLogFieldsResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the log to which the field belongs.
            /// </summary>
            [NameInMap("ActivityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            /// <summary>
            /// The internal code of the field description.
            /// </summary>
            [NameInMap("FieldDesc")]
            [Validation(Required=false)]
            public string FieldDesc { get; set; }

            /// <summary>
            /// The name of the field.
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// The data type of the field. Valid values:
            /// 
            /// *   varchar
            /// *   bigint
            /// </summary>
            [NameInMap("FieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            /// <summary>
            /// The log source to which the field belongs.
            /// </summary>
            [NameInMap("LogCode")]
            [Validation(Required=false)]
            public string LogCode { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
