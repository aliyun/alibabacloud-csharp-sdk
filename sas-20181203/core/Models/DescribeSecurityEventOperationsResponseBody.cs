// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityEventOperationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityEventOperationsResponse")]
        [Validation(Required=false)]
        public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponse> SecurityEventOperationsResponse { get; set; }
        public class DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponse : TeaModel {
            [NameInMap("MarkField")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField> MarkField { get; set; }
            public class DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField : TeaModel {
                [NameInMap("FiledAliasName")]
                [Validation(Required=false)]
                public string FiledAliasName { get; set; }

                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                [NameInMap("MarkMisType")]
                [Validation(Required=false)]
                public string MarkMisType { get; set; }

                [NameInMap("MarkMisValue")]
                [Validation(Required=false)]
                public string MarkMisValue { get; set; }

                [NameInMap("SupportedMisType")]
                [Validation(Required=false)]
                public List<string> SupportedMisType { get; set; }

                /// <summary>
                /// 资产uuid
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("MarkFieldsSource")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource> MarkFieldsSource { get; set; }
            public class DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource : TeaModel {
                [NameInMap("FiledAliasName")]
                [Validation(Required=false)]
                public string FiledAliasName { get; set; }

                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                [NameInMap("MarkMisValue")]
                [Validation(Required=false)]
                public string MarkMisValue { get; set; }

                [NameInMap("SupportedMisType")]
                [Validation(Required=false)]
                public List<string> SupportedMisType { get; set; }

            }

            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            [NameInMap("UserCanOperate")]
            [Validation(Required=false)]
            public bool? UserCanOperate { get; set; }

        }

    }

}
