// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDISyncTaskRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. This parameter can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The script content of the data synchronization task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;job&quot;,&quot;version&quot;:&quot;2.0&quot;,&quot;steps&quot;:[{&quot;stepType&quot;:&quot;mysql&quot;,&quot;parameter&quot;:{&quot;envType&quot;:1,&quot;datasource&quot;:&quot;mysql_pub&quot;,&quot;column&quot;:[&quot;id&quot;,&quot;name&quot;,&quot;create_time&quot;,&quot;age&quot;,&quot;score&quot;,&quot;t_01&quot;],&quot;connection&quot;:[{&quot;datasource&quot;:&quot;mysql_pub&quot;,&quot;table&quot;:[&quot;u_pk&quot;]}],&quot;where&quot;:&quot;&quot;,&quot;splitPk&quot;:&quot;id&quot;,&quot;encoding&quot;:&quot;UTF-8&quot;},&quot;name&quot;:&quot;Reader&quot;,&quot;category&quot;:&quot;reader&quot;},{&quot;stepType&quot;:&quot;odps&quot;,&quot;parameter&quot;:{&quot;partition&quot;:&quot;pt=${bizdate}&quot;,&quot;truncate&quot;:true,&quot;datasource&quot;:&quot;odps_source&quot;,&quot;envType&quot;:1,&quot;column&quot;:[&quot;id&quot;,&quot;name&quot;,&quot;create_time&quot;,&quot;age&quot;,&quot;score&quot;,&quot;t_01&quot;],&quot;emptyAsNull&quot;:false,&quot;tableComment&quot;:&quot;null&quot;,&quot;table&quot;:&quot;u_pk&quot;},&quot;name&quot;:&quot;Writer&quot;,&quot;category&quot;:&quot;writer&quot;}],&quot;setting&quot;:{&quot;executeMode&quot;:null,&quot;errorLimit&quot;:{&quot;record&quot;:&quot;&quot;},&quot;speed&quot;:{&quot;concurrent&quot;:2,&quot;throttle&quot;:false}},&quot;order&quot;:{&quot;hops&quot;:[{&quot;from&quot;:&quot;Reader&quot;,&quot;to&quot;:&quot;Writer&quot;}]}}</para>
        /// </summary>
        [NameInMap("TaskContent")]
        [Validation(Required=false)]
        public string TaskContent { get; set; }

        /// <summary>
        /// <para>The name of the data synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_di_task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The configuration parameters of the data synchronization task. The following parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description>FileFolderPath: the storage path of the data synchronization task.</description></item>
        /// <item><description>ResourceGroup: the identifier of the resource group for Data Integration that is used by the data synchronization task. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to query the identifier of the resource group.</description></item>
        /// <item><description>Cu: the specifications occupied by the data synchronization task in the serverless resource group. The value of this parameter must be a multiple of 0.5.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FileFolderPath&quot;:&quot;Business Flow/XXX/Data Integration&quot;,&quot;ResourceGroup&quot;:&quot;S_res_group_XXX_XXXX&quot;}</para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// <para>The type of the data synchronization task. Valid values: DI_OFFLINE, DI_REALTIME, and DI_SOLUTION.</para>
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
