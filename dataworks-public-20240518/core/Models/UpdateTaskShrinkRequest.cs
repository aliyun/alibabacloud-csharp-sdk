// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client unique code of the task, which uniquely identifies a task. It is used to implement asynchronous and idempotent functions. If it is not specified during creation, the system will automatically generate the code, which will be uniquely bound to the resource ID. If you specify this parameter when updating and deleting resources, it should be consistent with the client unique code when creating resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task_0bc5213917368545132902xxxxxxxx</para>
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
        /// <para>Dependency information.</para>
        /// </summary>
        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public string DependenciesShrink { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The project environment.</para>
        /// <list type="bullet">
        /// <item><description>Prod: Production</description></item>
        /// <item><description>Dev: Development</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Enter information.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string InputsShrink { get; set; }

        /// <summary>
        /// <para>The instance generation mode.</para>
        /// <list type="bullet">
        /// <item><description>T +1 (second born)</description></item>
        /// <item><description>Immediately (generate now)</description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL node</para>
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
        /// <para>The account ID of the owner of the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The retry interval, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RerunInterval")]
        [Validation(Required=false)]
        public int? RerunInterval { get; set; }

        /// <summary>
        /// <para>The configuration of whether the task is allowed to rerun.</para>
        /// <list type="bullet">
        /// <item><description>AllDenied: failure or success cannot be rerun.</description></item>
        /// <item><description>FailureAllowed: only failures can be rerun</description></item>
        /// <item><description>AllAllowed: you can run again if you fail or succeed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AllAllowed</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>The number of retries that take effect when the task is set to rerun.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RerunTimes")]
        [Validation(Required=false)]
        public int? RerunTimes { get; set; }

        /// <summary>
        /// <para>Configuration of the runtime environment, such as resource group information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public string RuntimeResourceShrink { get; set; }

        /// <summary>
        /// <para>Run the script information.</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public string ScriptShrink { get; set; }

        /// <summary>
        /// <para>The list of task tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The timeout period of the task execution, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The trigger method of the task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}
