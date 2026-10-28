// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PreviewNotifyTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The rendering result object, which contains two mappings: success for successfully rendered items and failed for items that failed to render.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public PreviewNotifyTemplateResponseBodyData Data { get; set; }
        public class PreviewNotifyTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The mapping of failed rendering results. The key is the template identifier, and the value is the cause of the failure, such as a template syntax error or a reference to an undefined variable.</para>
            /// </summary>
            [NameInMap("failed")]
            [Validation(Required=false)]
            public Dictionary<string, object> Failed { get; set; }

            /// <summary>
            /// <para>The mapping of successful rendering results. The key is the template identifier, which corresponds to templates[].key in the request, and the value is the rendered string content.</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public Dictionary<string, object> Success { get; set; }

        }

        /// <summary>
        /// <para>The processing result message. The value is success if the request is successful, or an error message if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>452faed9-ab3b-4340-8a92-bc7d9b98f17a</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
