// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5db780a0-9d3e-4f35-a84a-xxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request.</para>
        /// <list type="bullet">
        /// <item><description><para>true: sends a precheck request without performing the actual operation. If the precheck fails, the corresponding error is returned. If the precheck succeeds, the error code DryRunOperation is returned.</para>
        /// </description></item>
        /// <item><description><para>false: sends a normal request. This is the default value.</para>
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
        /// <para>The type of the child service to update. Note: This parameter takes effect only for aggregated services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLMPrefill</para>
        /// </summary>
        [NameInMap("MemberToUpdate")]
        [Validation(Required=false)]
        public string MemberToUpdate { get; set; }

        /// <summary>
        /// <para>The update type of the service. Both merge and replace modes are supported. If this parameter is not specified, the merge mode is used by default.</para>
        /// <list type="bullet">
        /// <item><description>merge: the merge mode. If the original service configuration JSON is
        /// <c>{&quot;a&quot;:&quot;b&quot;}</c> and the updated configuration is <c>{&quot;c&quot;:&quot;d&quot;}</c>, the final configuration in merge mode is <c>{&quot;a&quot;:&quot;b&quot;,&quot;c&quot;:&quot;d&quot;}</c>.</description></item>
        /// <item><description>replace: the replace mode. If the original service configuration JSON is
        /// <c>{&quot;a&quot;:&quot;b&quot;}</c> and the updated configuration is <c>{&quot;c&quot;:&quot;d&quot;}</c>, the final configuration in replace mode is <c>{&quot;c&quot;:&quot;d&quot;}</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>merge</para>
        /// </summary>
        [NameInMap("UpdateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

        /// <summary>
        /// <para>The updated configuration. For more information about parameter settings, see <a href="https://help.aliyun.com/document_detail/412086.html">CreateService</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;name&quot;: &quot;foo&quot;,
        ///       &quot;model_path&quot;: &quot;<a href="http://path/to/model.tar.gz">http://path/to/model.tar.gz</a>&quot;,
        ///       &quot;processor&quot;: &quot;tensorflow_cpu&quot;,
        ///       &quot;metadata&quot;: {
        ///             &quot;instance&quot;: 2,
        ///             &quot;memory&quot;: 7000,
        ///             &quot;cpu&quot;: 4
        ///       }
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
