// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class StartJobRequest : TeaModel {
        /// <summary>
        /// <para>List of caller numbers</para>
        /// 
        /// <b>Example:</b>
        /// <para>10086</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>da37319b-6c83-4268-9f19-814aed62e401</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Task group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f21446e-324e-46f2-bf62-7f341fb004ea</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>Job data, which includes the following fields:</para>
        /// <para>extras // Optional extra information</para>
        /// <list type="bullet">
        /// <item><description><para>key // Key for a custom variable</para>
        /// </description></item>
        /// <item><description><para>value // Value for a custom variable</para>
        /// </description></item>
        /// </list>
        /// <para>contacts // Required contact information for the callee</para>
        /// <list type="bullet">
        /// <item><description><para>phoneNumber // Required phone number of the callee</para>
        /// </description></item>
        /// <item><description><para>referenceId // Required contact ID (user-defined) to avoid duplicate names</para>
        /// </description></item>
        /// <item><description><para>role // Optional role of this contact in the outbound call scenario. If omitted, no role distinction is made</para>
        /// </description></item>
        /// <item><description><para>honorific // Optional honorific for the contact</para>
        /// </description></item>
        /// <item><description><para>name // Optional name of the contact</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;extras&quot;: [{
        ///         &quot;value&quot;: &quot;测试&quot;,
        ///         &quot;key&quot;: &quot;测试&quot;
        ///     }, {
        ///         &quot;key&quot;: &quot;ServiceId&quot;,
        ///         &quot;value&quot;: null
        ///     }, {
        ///         &quot;key&quot;: &quot;TenantId&quot;,
        ///         &quot;value&quot;: null
        ///     }],
        ///     &quot;contacts&quot;: [{
        ///         &quot;phonenumber&quot;: &quot;198********&quot;,
        ///         &quot;name&quot;: &quot;张三&quot;,
        ///         &quot;priority&quot;: 5,
        ///         &quot;referenceId&quot;: &quot;C01&quot;
        ///     }]
        /// }</para>
        /// </summary>
        [NameInMap("JobJson")]
        [Validation(Required=false)]
        public string JobJson { get; set; }

        /// <summary>
        /// <para>Scenario ID. This field supports backward compatibility with legacy outbound calling features. You can omit it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <para>Scenario ID (required)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1eeae263-54ca-4a52-ae14-62da58f3c473</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
