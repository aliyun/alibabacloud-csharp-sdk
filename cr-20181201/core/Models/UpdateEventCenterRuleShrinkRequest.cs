// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateEventCenterRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The event notification channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EVENT_BRIDGE</para>
        /// </summary>
        [NameInMap("EventChannel")]
        [Validation(Required=false)]
        public string EventChannel { get; set; }

        /// <summary>
        /// <para>The event configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;notifyMethod&quot;:&quot;http&quot;,
        ///         &quot;notifyConfig&quot;:{
        ///             &quot;Url&quot;:&quot;<a href="http://www.aliyundoc.com">http://www.aliyundoc.com</a>&quot;,
        ///             &quot;id&quot;:&quot;MaAV3HgTkO5Fh8l1V********&quot;,
        ///         },
        ///         &quot;notifyFilter&quot;:{}
        ///     }</para>
        /// </summary>
        [NameInMap("EventConfig")]
        [Validation(Required=false)]
        public string EventConfig { get; set; }

        /// <summary>
        /// <para>The event scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>INSTANCE</c></description></item>
        /// <item><description><c>NAMESPACE</c></description></item>
        /// <item><description><c>REPO</c></description></item>
        /// </list>
        /// <para>Default value: <c>INSTANCE</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("EventScope")]
        [Validation(Required=false)]
        public string EventScope { get; set; }

        /// <summary>
        /// <para>The type of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cr:Artifact:DeliveryChainCompleted</c>: The delivery chain is processed.</description></item>
        /// <item><description><c>cr:Artifact:SynchronizationCompleted</c>: The image is replicated.</description></item>
        /// <item><description><c>cr:Artifact:BuildCompleted</c>: The image is built.</description></item>
        /// <item><description><c>cr:Artifact:ScanCompleted</c>: The image is scanned.</description></item>
        /// <item><description><c>cr:Artifact:SigningCompleted</c>: The image is signed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cr:Artifact:DeliveryChainCompleted</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The namespaces to which the event notification rule applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns</para>
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public string NamespacesShrink { get; set; }

        /// <summary>
        /// <para>The names of the repositories to which the event notification rule applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reponame</para>
        /// </summary>
        [NameInMap("RepoNames")]
        [Validation(Required=false)]
        public string RepoNamesShrink { get; set; }

        /// <summary>
        /// <para>The regular expression for image tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("RepoTagFilterPattern")]
        [Validation(Required=false)]
        public string RepoTagFilterPattern { get; set; }

        /// <summary>
        /// <para>The ID of the event notification rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crecr-n6pbhgjxt*****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the event notification rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chain-demo</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
