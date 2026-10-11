// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class CreateEgressProxyConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>Note If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The default actions to be performed in each effective phase (PreDns, PreRequest, and PostResponse) when traffic does not match any rules.</para>
        /// </summary>
        [NameInMap("DefaultRulePhaseActions")]
        [Validation(Required=false)]
        public CreateEgressProxyConfigurationRequestDefaultRulePhaseActions DefaultRulePhaseActions { get; set; }
        public class CreateEgressProxyConfigurationRequestDefaultRulePhaseActions : TeaModel {
            /// <summary>
            /// <para>The default action to be performed in the PostResponse phase (after the response is returned) when traffic does not match any rules. This phase supports only the <b>Allow</b> value (default), which allows the traffic to pass through.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PostResponse")]
            [Validation(Required=false)]
            public string PostResponse { get; set; }

            /// <summary>
            /// <para>The default action to be performed in the PreDns phase (before DNS resolution) when traffic does not match any rules. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Allow</b> (default): allows the traffic to pass through.</para>
            /// </description></item>
            /// <item><description><para><b>Deny</b>: denies the traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PreDns")]
            [Validation(Required=false)]
            public string PreDns { get; set; }

            /// <summary>
            /// <para>The default action to be performed in the PreRequest phase (before the request is forwarded) when traffic does not match any rules. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Allow</b> (default): allows the traffic to pass through.</para>
            /// </description></item>
            /// <item><description><para><b>Deny</b>: denies the traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PreRequest")]
            [Validation(Required=false)]
            public string PreRequest { get; set; }

        }

        /// <summary>
        /// <para>The description of the egress proxy configuration. The description must be 2 to 256 characters in length, and can contain Chinese characters, letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run and does not create the egress proxy configuration. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the request fails the dry run, the corresponding error code is returned. If the request passes the dry run, the DryRunOperation error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the check, an HTTP 2xx status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The name of the egress proxy configuration. The name must be 2 to 128 characters in length, and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationName")]
        [Validation(Required=false)]
        public string EgressProxyConfigurationName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm4jcyx5e****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEgressProxyConfigurationRequestTag> Tag { get; set; }
        public class CreateEgressProxyConfigurationRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 256 characters in length, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
