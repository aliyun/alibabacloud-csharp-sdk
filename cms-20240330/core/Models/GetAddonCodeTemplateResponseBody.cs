// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAddonCodeTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of code templates.</para>
        /// </summary>
        [NameInMap("codes")]
        [Validation(Required=false)]
        public List<GetAddonCodeTemplateResponseBodyCodes> Codes { get; set; }
        public class GetAddonCodeTemplateResponseBodyCodes : TeaModel {
            /// <summary>
            /// <para>The code template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>javascript\nnpm install @arms/rum-miniapp --save</para>
            /// </summary>
            [NameInMap("codeTemplate")]
            [Validation(Required=false)]
            public string CodeTemplate { get; set; }

            /// <summary>
            /// <para>The name of the code template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs-default-CS-cs-default-1753236205394-cs-default-CS-kubeApiserver</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-***</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
