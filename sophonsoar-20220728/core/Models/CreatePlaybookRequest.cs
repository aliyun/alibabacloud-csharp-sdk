// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class CreatePlaybookRequest : TeaModel {
        /// <summary>
        /// <para>Description of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a new version</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Name of the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test09</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;: &quot;value1&quot;, &quot;key2&quot;: &quot;value2&quot;}</para>
        /// </summary>
        [NameInMap("InputParams")]
        [Validation(Required=false)]
        public string InputParams { get; set; }

        /// <summary>
        /// <para>Language type for receiving messages. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;result&quot;: &quot;success&quot;}</para>
        /// </summary>
        [NameInMap("OutputParams")]
        [Validation(Required=false)]
        public string OutputParams { get; set; }

        /// <summary>
        /// <para>Playbook TaskFlow type.</para>
        /// <list type="bullet">
        /// <item><description><b>x6</b> : x6</description></item>
        /// <item><description><b>bpmn</b>: bpmn</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>x6</para>
        /// </summary>
        [NameInMap("TaskflowType")]
        [Validation(Required=false)]
        public string TaskflowType { get; set; }

    }

}
