// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceLogDeliveryStatusResponseBody : TeaModel {
        [NameInMap("LogConfigs")]
        [Validation(Required=false)]
        public List<DescribeResourceLogDeliveryStatusResponseBodyLogConfigs> LogConfigs { get; set; }
        public class DescribeResourceLogDeliveryStatusResponseBodyLogConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>export-kafka</para>
            /// </summary>
            [NameInMap("DeliveryName")]
            [Validation(Required=false)]
            public string DeliveryName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kafka</para>
            /// </summary>
            [NameInMap("DeliveryType")]
            [Validation(Required=false)]
            public string DeliveryType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.waf.com-waf</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19****5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
