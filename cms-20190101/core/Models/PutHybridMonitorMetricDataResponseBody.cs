// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutHybridMonitorMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>The value 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the invalid parameters.</para>
        /// <para>If the request parameters that you specify do not meet the requirements, the details of the invalid parameters are displayed.</para>
        /// </summary>
        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public List<PutHybridMonitorMetricDataResponseBodyErrorDetail> ErrorDetail { get; set; }
        public class PutHybridMonitorMetricDataResponseBodyErrorDetail : TeaModel {
            /// <summary>
            /// <para>The error message that is returned for the invalid parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>label name :123 not match [a-zA-Z_][a-zA-Z0-9_]*</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The position of the error information in the array.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5DB1CBCA-D14A-55FA-814F-B4DBD9735F68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
