// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ValidateLlmTemplateConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The validation result of the LLM template configuration, which includes whether the configuration is valid and a list of validation errors.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ValidateLlmTemplateConfigResponseBodyData Data { get; set; }
        public class ValidateLlmTemplateConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the configuration is valid. The value is true if all validation items pass.</para>
            /// </summary>
            [NameInMap("Valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

            /// <summary>
            /// <para>The list of validation errors. This list is empty if Valid is true.</para>
            /// </summary>
            [NameInMap("ValidationErrors")]
            [Validation(Required=false)]
            public List<ValidateLlmTemplateConfigResponseBodyDataValidationErrors> ValidationErrors { get; set; }
            public class ValidateLlmTemplateConfigResponseBodyDataValidationErrors : TeaModel {
                /// <summary>
                /// <para>The error code, such as MISSING_FIELD, UNKNOWN_FIELD, INVALID_TYPE, or INVALID_JSON.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UNKNOWN_FIELD</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The name of the field where the error occurred, such as id, name, or contextWindow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>unknownField</para>
                /// </summary>
                [NameInMap("Field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Unknown field &quot;unknownField&quot; is not recognized by Agent and will be ignored.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
