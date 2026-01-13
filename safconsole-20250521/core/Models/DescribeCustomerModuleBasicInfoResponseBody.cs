// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class DescribeCustomerModuleBasicInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>055f1546-f465-4c92-a2da-bfb86abe6f56</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeCustomerModuleBasicInfoResponseBodyResultObject ResultObject { get; set; }
        public class DescribeCustomerModuleBasicInfoResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Customer model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ModuleName</para>
            /// </summary>
            [NameInMap("CustomerModuleName")]
            [Validation(Required=false)]
            public string CustomerModuleName { get; set; }

            /// <summary>
            /// <para>Remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>备注。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Model identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ModuleName</para>
            /// </summary>
            [NameInMap("InnerModuleName")]
            [Validation(Required=false)]
            public string InnerModuleName { get; set; }

            /// <summary>
            /// <para>Module type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PMML</para>
            /// </summary>
            [NameInMap("ModuleType")]
            [Validation(Required=false)]
            public string ModuleType { get; set; }

            /// <summary>
            /// <para>Test address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model.pmml</para>
            /// </summary>
            [NameInMap("StorePath")]
            [Validation(Required=false)]
            public string StorePath { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the application configuration information was successfully retrieved. Possible values: true: Success; false: Failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
