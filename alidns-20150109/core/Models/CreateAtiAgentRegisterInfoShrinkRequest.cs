// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreateAtiAgentRegisterInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the agent capabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>支付服务</para>
        /// </summary>
        [NameInMap("AgentDescription")]
        [Validation(Required=false)]
        public string AgentDescription { get; set; }

        /// <summary>
        /// <para>The display name of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试Agent</para>
        /// </summary>
        [NameInMap("AgentDisplayName")]
        [Validation(Required=false)]
        public string AgentDisplayName { get; set; }

        /// <summary>
        /// <para>The endpoint domain name through which the agent provides services.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("AgentHost")]
        [Validation(Required=false)]
        public string AgentHost { get; set; }

        /// <summary>
        /// <para>The version of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>Provides idempotency. Within 3 minutes, the same value takes effect only once.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The endpoint information of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;EndpointValue\&quot;:\&quot;<a href="http://www.baidu.com%5C%5C%22,%5C%5C%22EndpointType%5C%5C%22:%5C%5C%22http%5C%5C%22%7D%5D">http://www.baidu.com\\&quot;,\\&quot;EndpointType\\&quot;:\\&quot;http\\&quot;}]</a></para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public string EndpointsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the verified registrant. Obtain this ID by invoking the identity verification API operation or from the ATS console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2072277378616354816</para>
        /// </summary>
        [NameInMap("RegistrantId")]
        [Validation(Required=false)]
        public string RegistrantId { get; set; }

    }

}
