// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSoarStrategyTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the policy.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeSoarSubscribedStrategy~~">DescribeSoarSubscribedStrategy</a> operation to obtain the ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13840</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// <para>The name of the policy. Set the value to Automated Batch Vulnerability Fixing Policy for Multiple Servers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The name of.the policy task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task1</para>
        /// </summary>
        [NameInMap("StrategyTaskName")]
        [Validation(Required=false)]
        public string StrategyTaskName { get; set; }

        /// <summary>
        /// <para>The parameters of the policy task. The value is a JSON array.</para>
        /// <para>Vulnerability-related parameters:</para>
        /// <list type="bullet">
        /// <item><description>name: vluList</description></item>
        /// <item><description>associationProperty: sasAllVul</description></item>
        /// <item><description>value: basic vulnerability information</description></item>
        /// </list>
        /// <para>Snapshot-related parameters:</para>
        /// <list type="bullet">
        /// <item><description>name: snapshotConfig</description></item>
        /// <item><description>associationProperty: snapshotConfig</description></item>
        /// <item><description>value: retention period</description></item>
        /// </list>
        /// <para>Notification-related parameters:</para>
        /// <list type="bullet">
        /// <item><description>name: notifyConfig</description></item>
        /// <item><description>associationProperty: notifyConfig</description></item>
        /// <item><description>value: email or DingTalk configuration information</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;name&quot;: &quot;vulList&quot;,
        ///         &quot;associationProperty&quot;: &quot;sasAllVul&quot;,
        ///         &quot;value&quot;: [
        ///             {
        ///                 &quot;regionId&quot;: &quot;cn-hangzhou&quot;,
        ///                 &quot;instanceId&quot;: &quot;i-bp10i<b><b><b>68lo5e&quot;,
        ///                 &quot;instanceName&quot;: &quot;instance</b></b>&quot;,
        ///                 &quot;vulId&quot;: 3974347681,
        ///                 &quot;vulName&quot;: &quot;centos:7:cesa-2024:1249&quot;,
        ///                 &quot;vulAliasName&quot;: &quot;CESA-2024:1249&quot;,
        ///                 &quot;vulTag&quot;: &quot;oval&quot;,
        ///                 &quot;vulUuid&quot;: &quot;3c5eb76a-</b>****-85ef-67562cdc2344&quot;,
        ///                 &quot;vulType&quot;: &quot;cve&quot;,
        ///                 &quot;vulModifyTs&quot;: 1721324258000
        ///             }
        ///         ]
        ///     },
        ///     {
        ///         &quot;name&quot;: &quot;snapshotConfig&quot;,
        ///         &quot;associationProperty&quot;: &quot;snapshotConfig&quot;,
        ///         &quot;value&quot;: {
        ///             &quot;ttl&quot;: 1
        ///         }
        ///     },
        ///     {
        ///         &quot;name&quot;: &quot;notifyConfig&quot;,
        ///         &quot;associationProperty&quot;: &quot;notifyConfig&quot;,
        ///         &quot;value&quot;: {
        ///             &quot;ding&quot;: [
        ///                 {
        ///                     &quot;value&quot;: 2195,
        ///                     &quot;label&quot;: &quot;test&quot;
        ///                 }
        ///             ]
        ///         }
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("StrategyTaskParams")]
        [Validation(Required=false)]
        public string StrategyTaskParams { get; set; }

        /// <summary>
        /// <para>The timestamp when the task is scheduled to start. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1586739841000</para>
        /// </summary>
        [NameInMap("StrategyTaskPlanExeTime")]
        [Validation(Required=false)]
        public long? StrategyTaskPlanExeTime { get; set; }

    }

}
