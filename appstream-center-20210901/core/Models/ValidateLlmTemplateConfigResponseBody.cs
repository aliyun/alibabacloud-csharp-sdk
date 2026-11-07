// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ValidateLlmTemplateConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ValidateLlmTemplateConfigResponseBodyData Data { get; set; }
        public class ValidateLlmTemplateConfigResponseBodyData : TeaModel {
            [NameInMap("Valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

            [NameInMap("ValidationErrors")]
            [Validation(Required=false)]
            public List<ValidateLlmTemplateConfigResponseBodyDataValidationErrors> ValidationErrors { get; set; }
            public class ValidateLlmTemplateConfigResponseBodyDataValidationErrors : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>UNKNOWN_FIELD</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>unknownField</para>
                /// </summary>
                [NameInMap("Field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Unknown field &quot;unknownField&quot; is not recognized by Agent and will be ignored.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
