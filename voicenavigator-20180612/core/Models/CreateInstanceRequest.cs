// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of concurrent sessions. The value must be a non-negative integer and cannot exceed the current available concurrency quota.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public long? Concurrency { get; set; }

        /// <summary>
        /// <para>The description of the scenario. The description can be up to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test scenario</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the scenario.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test scenario</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The parameter settings of the natural language understanding (NLU) service, represented as a JSON character string. The parameters correspond to the type of NLU service used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;agentKey&quot;:&quot;20791f5f886b4826b3d9b676a029c33d&quot;,&quot;agentId&quot;:&quot;1340201&quot;,&quot;isCCCAgent&quot;:false,&quot;agentName&quot;:&quot;Cloud Chatbot Business Workspace 1&quot;,&quot;agentLlm&quot;:true}</para>
        /// </summary>
        [NameInMap("NluServiceParamsJson")]
        [Validation(Required=false)]
        public string NluServiceParamsJson { get; set; }

        /// <summary>
        /// <para>The instance ID of the integration source. When <c>UnionSource</c> is set to <c>CCC</c>, specify the ID of the Cloud Call Center instance to be associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-lctms</para>
        /// </summary>
        [NameInMap("UnionInstanceId")]
        [Validation(Required=false)]
        public string UnionInstanceId { get; set; }

        /// <summary>
        /// <para>The integration source of the intelligent navigation. When you integrate with Cloud Call Center, set the value to <c>CCC</c> and specify the associated Cloud Call Center instance by using <c>UnionInstanceId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CCC</para>
        /// </summary>
        [NameInMap("UnionSource")]
        [Validation(Required=false)]
        public string UnionSource { get; set; }

    }

}
