// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DataPathConfigsFieldPathsValue : TeaModel {
        /// <summary>
        /// <para>The identity key of the field, which is unique within the same request path, such as input_token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>input_token</para>
        /// </summary>
        [NameInMap("fieldKey")]
        [Validation(Required=false)]
        public string FieldKey { get; set; }

        /// <summary>
        /// <para>The JSONPath expression of the field in the request or response message, such as usage.prompt_tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usage.prompt_tokens</para>
        /// </summary>
        [NameInMap("jsonPath")]
        [Validation(Required=false)]
        public string JsonPath { get; set; }

        /// <summary>
        /// <para>The value extraction rule for the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>first</para>
        /// </summary>
        [NameInMap("rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The display name of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Input token</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The description of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Input token statistics</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The source of the field value, indicating which part of the message the field is read from, such as response_body.</para>
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

        /// <summary>
        /// <para>The message direction to which the field belongs, indicating whether it is extracted from the request or the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>response</para>
        /// </summary>
        [NameInMap("io")]
        [Validation(Required=false)]
        public string Io { get; set; }

        /// <summary>
        /// <para>Indicates whether the field contains sensitive information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sensitive")]
        [Validation(Required=false)]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// <para>Indicates whether collection is enabled for the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("recordEnabled")]
        [Validation(Required=false)]
        public bool? RecordEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether the collection status of the field can be toggled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("toggleAllowed")]
        [Validation(Required=false)]
        public bool? ToggleAllowed { get; set; }

        /// <summary>
        /// <para>Indicates whether the JSONPath of the field can be rewritten.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("jsonPathRewriteAllowed")]
        [Validation(Required=false)]
        public bool? JsonPathRewriteAllowed { get; set; }

        /// <summary>
        /// <para>Indicates whether the field configuration is derived from a field template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("fromTemplate")]
        [Validation(Required=false)]
        public bool? FromTemplate { get; set; }

    }

}
