// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiStatisticsPathField : TeaModel {
        /// <summary>
        /// <para>The secondary business category of the field. Optional. Valid values: conversation (conversation content), config (configuration parameters), tools (tool calling), usage (usage statistics), metadata (metadata), choices (candidate results), identity (identity identifier), cache (cache information), media (multimedia content), logprobs (log probabilities), and custom (custom field). Set custom fields to custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conversation</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The field description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The question content entered by the user</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The log key (field name).</para>
        /// 
        /// <b>Example:</b>
        /// <para>question</para>
        /// </summary>
        [NameInMap("fieldKey")]
        [Validation(Required=false)]
        public string FieldKey { get; set; }

        /// <summary>
        /// <para>The request or response attribution. The backend normalizes this to request or response based on source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request</para>
        /// </summary>
        [NameInMap("io")]
        [Validation(Required=false)]
        public string Io { get; set; }

        /// <summary>
        /// <para>The corresponding jsonPath (gjson syntax).</para>
        /// 
        /// <b>Example:</b>
        /// <para>messages.#.content</para>
        /// </summary>
        [NameInMap("jsonPath")]
        [Validation(Required=false)]
        public string JsonPath { get; set; }

        /// <summary>
        /// <para>The annotation for the field key name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Question content</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether collection is enabled to create a log record for the corresponding field in AI request logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("recordEnabled")]
        [Validation(Required=false)]
        public bool? RecordEnabled { get; set; }

        /// <summary>
        /// <para>The aggregation rule for streaming response fields. Valid values: append, first, and replace. append: appends the matched values from each streaming chunk in sequence. first: retains the first matched value. replace: uses the last matched value. When source is response_streaming_body and rule is not specified, first is used by default. This field is not required for non-streaming scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>append</para>
        /// </summary>
        [NameInMap("rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Specifies whether the field is sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sensitive")]
        [Validation(Required=false)]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// <para>The source of the field value. Valid values: fixed_value (fixed value), request_body (request body), request_header (request header), response_header (response header), response_body (non-streaming response body), and response_streaming_body (streaming response body).</para>
        /// 
        /// <b>Example:</b>
        /// <para>request_body</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
