// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateAsyncTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The details of the asynchronous export task. The value is a JSON string. The field in the value varies with <b>TaskType</b>.</para>
        /// <para>If <b>TaskType</b> is set to <b>1</b>, <b>3</b>, <b>4</b>, <b>5</b>, or <b>6</b>, the following filed is returned:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: the ID of the instance. This field is required and must be of the STRING type.</description></item>
        /// </list>
        /// <para>If <b>TaskType</b> is set to <b>2</b>, the following field is returned:</para>
        /// <list type="bullet">
        /// <item><description><b>domain</b>: the domain name of the website, which must be of the STRING type. If you do not specify this field, the forwarding rules of all websites are exported.</description></item>
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
        /// <para>The type of the asynchronous export task that you want to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: the task to export the port forwarding rules of an instance</description></item>
        /// <item><description><b>2</b>: the task to export the forwarding rules of a website protected by an instance</description></item>
        /// <item><description><b>3</b>: the task to export the session persistence and health check settings of an instance</description></item>
        /// <item><description><b>4</b>: the task to export the anti-DDoS mitigation policies of an instance</description></item>
        /// <item><description><b>5</b>: the task to download the blacklist for destination IP addresses of an instance</description></item>
        /// <item><description><b>6</b>: the task to download the whitelist for destination IP addresses of an instance</description></item>
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
