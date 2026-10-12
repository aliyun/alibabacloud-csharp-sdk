// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DataFieldPathsValue : TeaModel {
        /// <summary>
        /// <para>The identifier key of the template field, such as input_token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>input_token</para>
        /// </summary>
        [NameInMap("fieldKey")]
        [Validation(Required=false)]
        public string FieldKey { get; set; }

        /// <summary>
        /// <para>The JSONPath expression of the template field in the request or response message, such as usage.prompt_tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usage.prompt_tokens</para>
        /// </summary>
        [NameInMap("jsonPath")]
        [Validation(Required=false)]
        public string JsonPath { get; set; }

        /// <summary>
        /// <para>The value source of the field, which indicates the part of the message from which the field is read, such as response_body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>response_body</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The statistical category to which the field belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usage</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

    }

}
