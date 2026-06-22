// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSoarStrategyTaskRequest : TeaModel {
        /// <summary>
        /// <para>The policy ID.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeSoarSubscribedStrategy~~">DescribeSoarSubscribedStrategy</a> operation to obtain this parameter.</para>
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
        /// <para>The policy name. Fixed value: Automated Batch Vulnerability Fix Policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Automated Batch Vulnerability Fixing Policy for Multiple Servers</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The name of the policy task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task1</para>
        /// </summary>
        [NameInMap("StrategyTaskName")]
        [Validation(Required=false)]
        public string StrategyTaskName { get; set; }

        /// <summary>
        /// <para>The parameter information of the policy. A string in JSONArray format with the following items:</para>
        /// <para>Vulnerability configuration item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>name: vluList</description></item>
        /// <item><description>associationProperty: sasAllVul</description></item>
        /// <item><description>value: basic information about the vulnerability</description></item>
        /// </list>
        /// <para>Snapshot configuration item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>name: snapshotConfig</description></item>
        /// <item><description>associationProperty: snapshotConfig</description></item>
        /// <item><description>value: storage time information</description></item>
        /// </list>
        /// <para>Notification configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>name: notifyConfig</description></item>
        /// <item><description>associationProperty: notifyConfig</description></item>
        /// <item><description>value: email or DingTalk configuration information.</description></item>
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
        /// <para>The planned execution timestamp of the policy task. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1586739841000</para>
        /// </summary>
        [NameInMap("StrategyTaskPlanExeTime")]
        [Validation(Required=false)]
        public long? StrategyTaskPlanExeTime { get; set; }

    }

}
