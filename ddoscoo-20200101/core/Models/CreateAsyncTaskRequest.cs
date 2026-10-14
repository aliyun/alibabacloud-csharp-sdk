// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateAsyncTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Pro or Anti-DDoS Premium instance belongs in Resource Management. If this parameter is empty, the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The task parameter information. The value is a JSON-formatted string. The required task parameters vary based on the value of <b>TaskType</b>.</para>
        /// <para>If <b>TaskType</b> is set to <b>1</b>, <b>3</b>, <b>4</b>, <b>5</b>, or <b>6</b>, the task parameters use the following structure:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: String type. Required. The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
        /// </list>
        /// <para>If <b>TaskType</b> is set to <b>2</b>, the task parameters use the following structure:</para>
        /// <list type="bullet">
        /// <item><description><b>domain</b>: String type. Optional. The domain name of the website. If this parameter is not specified, the forwarding rules of all websites are exported.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;instanceId&quot;: &quot;ddoscoo-cn-mp91j1ao****&quot;}</para>
        /// </summary>
        [NameInMap("TaskParams")]
        [Validation(Required=false)]
        public string TaskParams { get; set; }

        /// <summary>
        /// <para>The type of the export task to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Layer 4 export task. Exports port forwarding rules of the Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
        /// <item><description><b>2</b>: Layer 7 export task. Exports website forwarding rules.</description></item>
        /// <item><description><b>3</b>: Session persistence and health check export task. Exports session persistence and health check configurations of the Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
        /// <item><description><b>4</b>: DDoS mitigation policy export task. Exports DDoS mitigation policy configurations of the Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
        /// <item><description><b>5</b>: Blacklist (destination IP address-based) download task. Exports blacklisted IP addresses for the Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
        /// <item><description><b>6</b>: Whitelist (destination IP address-based) download task. Exports whitelisted IP addresses for the Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

    }

}
