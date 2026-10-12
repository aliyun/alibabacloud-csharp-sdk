// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetApiPathFieldTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetApiPathFieldTemplateResponseBodyData Data { get; set; }
        public class GetApiPathFieldTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description text of the field template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAI chat completion API..</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The set of fields defined by the field template, grouped by mapping key. Each group contains a set of template field items.</para>
            /// </summary>
            [NameInMap("fieldPaths")]
            [Validation(Required=false)]
            public Dictionary<string, List<DataFieldPathsValue>> FieldPaths { get; set; }

            /// <summary>
            /// <para>The API request path corresponding to the field template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/v1/chat/completions</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The API protocol applicable to the field template, such as openai.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openai</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The name of the field template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAI Chat Completions</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
