// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateAgentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event bus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Connection configuration description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The associated metadata.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string MetadataShrink { get; set; }

        /// <summary>
        /// <para>The name of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>You are an IoT data analytics assistant...</para>
        /// 
        /// <b>Example:</b>
        /// <para>I want her, you add the request header to obtain the user IP CF-Connecting-IP%3B</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
