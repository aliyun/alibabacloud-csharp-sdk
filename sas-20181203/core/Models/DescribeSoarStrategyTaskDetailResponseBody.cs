// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarStrategyTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FBBEB173-1F43-505F-A876-C03ECDF6CE4C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the task.</para>
        /// </summary>
        [NameInMap("TaskDetail")]
        [Validation(Required=false)]
        public DescribeSoarStrategyTaskDetailResponseBodyTaskDetail TaskDetail { get; set; }
        public class DescribeSoarStrategyTaskDetailResponseBodyTaskDetail : TeaModel {
            /// <summary>
            /// <para>The operational log information of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            /// &quot;resultContent&quot;: &quot;{\&quot;failedNum\&quot;:0,\&quot;totalNum\&quot;:1,\&quot;successNum\&quot;:1}&quot;,
            /// &quot;resultStatus&quot;: 0,
            /// &quot;status&quot;: 2
            /// }</para>
            /// </summary>
            [NameInMap("LogInfo")]
            [Validation(Required=false)]
            public string LogInfo { get; set; }

            /// <summary>
            /// <para>The parameters of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///     {
            ///         &quot;name&quot;: &quot;vulList&quot;,
            ///         &quot;associationProperty&quot;: &quot;sasAllVul&quot;,
            ///         &quot;value&quot;: [
            ///             {
            ///                 &quot;regionId&quot;: &quot;cn-hangzhou&quot;,
            ///                 &quot;instanceId&quot;: &quot;i-bp10i3dtyq7x4<b><b>5e&quot;,
            ///                 &quot;instanceName&quot;: &quot;xxx&quot;,
            ///                 &quot;vulId&quot;: 1222,
            ///                 &quot;vulName&quot;: &quot;centos:7:cesa-2024:1249&quot;,
            ///                 &quot;vulAliasName&quot;: &quot;CESA-2024:1249&quot;,
            ///                 &quot;vulTag&quot;: &quot;oval&quot;,
            ///                 &quot;vulUuid&quot;: &quot;3c5eb76a-df89-</b></b>-85ef-67562cdc2344&quot;,
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
            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            /// <summary>
            /// <para>The process information of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;edges&quot;: [
            ///         {
            ///             &quot;level&quot;: 0,
            ///             &quot;removeFlag&quot;: 0,
            ///             &quot;source&quot;: 1,
            ///             &quot;target&quot;: 8
            ///         }
            ///     ],
            ///     &quot;nodes&quot;: [
            ///         {
            ///             &quot;actionId&quot;: &quot;Action_014s73k&quot;,
            ///             &quot;iconUrl&quot;: &quot;<a href="https://img.alicdn.com/tfs/TB1T*****jSZLeXXb9kVXa-12-14.svg">https://img.alicdn.com/tfs/TB1T*****jSZLeXXb9kVXa-12-14.svg</a>&quot;,
            ///             &quot;id&quot;: 1,
            ///             &quot;label&quot;: &quot;describeDisks&quot;,
            ///             &quot;nodeName&quot;: &quot;DescribeDisks&quot;,
            ///             &quot;status&quot;: 0,
            ///             &quot;type&quot;: &quot;openAPI&quot;
            ///         }
            ///     ]
            /// }</para>
            /// </summary>
            [NameInMap("ProcessInfo")]
            [Validation(Required=false)]
            public string ProcessInfo { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-1</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

    }

}
