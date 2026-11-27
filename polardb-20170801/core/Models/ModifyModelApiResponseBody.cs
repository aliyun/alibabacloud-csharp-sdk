// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyModelApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The category of the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The time when the model API was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-09T06:43:33Z</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The time when the model API was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-09T06:43:33Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the model API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mi-xxxxx</para>
        /// </summary>
        [NameInMap("ModelApiId")]
        [Validation(Required=false)]
        public string ModelApiId { get; set; }

        /// <summary>
        /// <para>The current model name mappings, returned as a JSON array string. This parameter is empty if no mappings are configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Source&quot;:&quot;client-model-a&quot;,&quot;Target&quot;:&quot;upstream-model-a&quot;}]</para>
        /// </summary>
        [NameInMap("ModelMappings")]
        [Validation(Required=false)]
        public string ModelMappings { get; set; }

        /// <summary>
        /// <para>The current intelligent routing candidate list, returned as a JSON object string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AllowedModels&quot;:[&quot;deepseek-v4-pro&quot;,&quot;glm-5.3&quot;,&quot;glm-5.3-flash&quot;]}</para>
        /// </summary>
        [NameInMap("ModelRouting")]
        [Validation(Required=false)]
        public string ModelRouting { get; set; }

        /// <summary>
        /// <para>The updated name of the model API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jev-chat-api</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The API path prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/jev/v1</para>
        /// </summary>
        [NameInMap("PathPrefix")]
        [Validation(Required=false)]
        public string PathPrefix { get; set; }

        /// <summary>
        /// <para>The access protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai-chat</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>925B84D9-CA72-432C-95CF-738C22******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The current routing rules, returned as a JSON string. A byte-for-byte exact match of the input is not guaranteed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RuleName&quot;:&quot;default&quot;,&quot;Providers&quot;:[{&quot;ModelServiceName&quot;:&quot;model-service-a&quot;,&quot;ModelList&quot;:&quot;[\&quot;deepseek-v4-pro\&quot;]&quot;,&quot;Weight&quot;:100}]}]</para>
        /// </summary>
        [NameInMap("RouteRules")]
        [Validation(Required=false)]
        public string RouteRules { get; set; }

        /// <summary>
        /// <para>The status of the model API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
