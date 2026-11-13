// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDISyncTaskRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token. This parameter can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The script content of the Data Integration synchronization task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;job&quot;,&quot;version&quot;:&quot;2.0&quot;,&quot;steps&quot;:[{&quot;stepType&quot;:&quot;mysql&quot;,&quot;parameter&quot;:{&quot;envType&quot;:1,&quot;datasource&quot;:&quot;mysql_pub&quot;,&quot;column&quot;:[&quot;id&quot;,&quot;name&quot;,&quot;create_time&quot;,&quot;age&quot;,&quot;score&quot;,&quot;t_01&quot;],&quot;connection&quot;:[{&quot;datasource&quot;:&quot;mysql_pub&quot;,&quot;table&quot;:[&quot;u_pk&quot;]}],&quot;where&quot;:&quot;&quot;,&quot;splitPk&quot;:&quot;id&quot;,&quot;encoding&quot;:&quot;UTF-8&quot;},&quot;name&quot;:&quot;Reader&quot;,&quot;category&quot;:&quot;reader&quot;},{&quot;stepType&quot;:&quot;odps&quot;,&quot;parameter&quot;:{&quot;partition&quot;:&quot;pt=${bizdate}&quot;,&quot;truncate&quot;:true,&quot;datasource&quot;:&quot;odps_first&quot;,&quot;envType&quot;:1,&quot;column&quot;:[&quot;id&quot;,&quot;name&quot;,&quot;create_time&quot;,&quot;age&quot;,&quot;score&quot;,&quot;t_01&quot;],&quot;emptyAsNull&quot;:false,&quot;tableComment&quot;:&quot;null&quot;,&quot;table&quot;:&quot;u_pk&quot;},&quot;name&quot;:&quot;Writer&quot;,&quot;category&quot;:&quot;writer&quot;}],&quot;setting&quot;:{&quot;executeMode&quot;:null,&quot;errorLimit&quot;:{&quot;record&quot;:&quot;&quot;},&quot;speed&quot;:{&quot;concurrent&quot;:2,&quot;throttle&quot;:false}},&quot;order&quot;:{&quot;hops&quot;:[{&quot;from&quot;:&quot;Reader&quot;,&quot;to&quot;:&quot;Writer&quot;}]}}</para>
        /// </summary>
        [NameInMap("TaskContent")]
        [Validation(Required=false)]
        public string TaskContent { get; set; }

        /// <summary>
        /// <para>The name of the Data Integration synchronization task to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_di_task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The configuration parameters of the Data Integration synchronization task. The following parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description>FileFolderPath: the storage path of the Data Integration synchronization task.</description></item>
        /// <item><description>ResourceGroup: the identifier of the Data Integration resource group used by the task. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to obtain the resource group identifier.</description></item>
        /// <item><description>Cu: the specifications occupied by the task on the serverless resource group. The value must be a multiple of 0.5.</description></item>
        /// </list>
        /// <para>When you create an offline synchronization task (TaskType=DI_OFFLINE), this parameter is required and must contain at least FileFolderPath.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FileFolderPath&quot;:&quot;Workflow/XXX/Data Integration&quot;,&quot;ResourceGroup&quot;:&quot;Serverless_res_group_XXX_XXXX&quot;, &quot;Cu&quot;:1.5}</para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// <para>The task type of the Data Integration synchronization task to create. The CreateDISyncTask operation supports creating offline synchronization tasks (DI_OFFLINE), real-time synchronization tasks (DI_REALTIME), and solutions (DI_SOLUTION).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DI_OFFLINE</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
