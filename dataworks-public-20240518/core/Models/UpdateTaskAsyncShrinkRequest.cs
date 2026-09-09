// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateTaskAsyncShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client unique code of the node, which uniquely identifies a node. This code is used for asynchronous operations and idempotence. If you do not specify this parameter during creation, the system automatically generates one. The code is uniquely bound to the resource ID. When updating or deleting a resource, if you specify this parameter, it must be the same as the client unique code specified during creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Workflow_0bc5213917368545132902xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientUniqueCode")]
        [Validation(Required=false)]
        public string ClientUniqueCode { get; set; }

        /// <summary>
        /// <para>The associated data source information.</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSourceShrink { get; set; }

        /// <summary>
        /// <para>The dependency information.</para>
        /// </summary>
        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public string DependenciesShrink { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The project environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: production</description></item>
        /// <item><description>Dev: development</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The input information.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string InputsShrink { get; set; }

        /// <summary>
        /// <para>The instance generation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T+1: Generates instances the next day.</description></item>
        /// <item><description>Immediately: Generates instances immediately. Note: Only periodic instances whose scheduled time is at least 10 minutes after the node publish time are generated. During the full instance generation period (22:00 to 24:00), real-time instance generation is not available. You can submit and publish nodes, but new nodes do not automatically generate instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T+1</para>
        /// </summary>
        [NameInMap("InstanceMode")]
        [Validation(Required=false)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output information.</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string OutputsShrink { get; set; }

        /// <summary>
        /// <para>The account ID of the node owner. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and hover over the profile picture in the upper-right corner of the top navigation bar to view the account ID. If this parameter is left empty, the Alibaba Cloud account ID of the caller is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The retry time interval, in milliseconds. The value cannot exceed 1800000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("RerunInterval")]
        [Validation(Required=false)]
        public int? RerunInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether the node can be rerun. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AllDenied: Cannot be rerun regardless of success or failure.</description></item>
        /// <item><description>FailureAllowed: Can be rerun only upon failure.</description></item>
        /// <item><description>AllAllowed: Can be rerun regardless of success or failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AllAllowed</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>The number of retries. This parameter takes effect when the node is configured to allow reruns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RerunTimes")]
        [Validation(Required=false)]
        public int? RerunTimes { get; set; }

        /// <summary>
        /// <para>The runtime environment configuration, such as schedule resource group information.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public string RuntimeResourceShrink { get; set; }

        /// <summary>
        /// <para>The script information.</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public string ScriptShrink { get; set; }

        /// <summary>
        /// <para>The list of data asset tags to bind.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The timeout setting for scheduling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The trigger method of the node.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}
