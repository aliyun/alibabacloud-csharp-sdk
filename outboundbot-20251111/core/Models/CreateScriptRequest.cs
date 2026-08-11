// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class CreateScriptRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For testing</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The scenario name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test scenario</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The NLU engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BEEBOT: integrates with Chatbot.</description></item>
        /// <item><description>PROMPTS: prompt mode.</description></item>
        /// <item><description>FUNCTION: integrates with Function Compute.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BEEBOT</para>
        /// </summary>
        [NameInMap("NluEngine")]
        [Validation(Required=false)]
        public string NluEngine { get; set; }

    }

}
