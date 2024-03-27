// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeOperatorsResponseBody : TeaModel {
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
        public List<DescribeOperatorsResponseBodyData> Data { get; set; }
        public class DescribeOperatorsResponseBodyData : TeaModel {
            /// <summary>
            /// The position of the operator in the operator list.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// The operator.
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The description of the operator in Chinese.
            /// </summary>
            [NameInMap("OperatorDescCn")]
            [Validation(Required=false)]
            public string OperatorDescCn { get; set; }

            /// <summary>
            /// The description of the operator in English.
            /// </summary>
            [NameInMap("OperatorDescEn")]
            [Validation(Required=false)]
            public string OperatorDescEn { get; set; }

            /// <summary>
            /// The name of the operator.
            /// </summary>
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// The data types that are supported by the operator. The data types are separated by commas (,).
            /// </summary>
            [NameInMap("SupportDataType")]
            [Validation(Required=false)]
            public string SupportDataType { get; set; }

            /// <summary>
            /// The scenarios that are supported by the operator. Multiple scenarios are separated by commas (,), such as AGGREGATE scenarios. By default, this parameter is empty.
            /// </summary>
            [NameInMap("SupportTag")]
            [Validation(Required=false)]
            public List<string> SupportTag { get; set; }

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
