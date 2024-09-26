// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class StartDISyncInstanceRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>If you set TaskType to DI_REALTIME, set this parameter to the ID of the real-time synchronization task that you want to start.</description></item>
        /// <item><description>If you set TaskType to DI_SOLUTION, set this parameter to the ID of the data synchronization solution that you want to start.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the workspace ID. You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If you set TaskType to DI_REALTIME, the StartParam parameter specifies the startup parameters for the real-time synchronization task. The startup parameters include failover-related parameters, the parameter that specifies the number of dirty data records allowed, and the parameters in the data definition language (DDL) statements.</description></item>
        /// <item><description>If you set TaskType to DI_SOLUTION, the StartParam parameter does not take effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failoverLimit&quot;:{&quot;count&quot;:10,&quot;interval&quot;:30},&quot;errorLimit&quot;:{&quot;record&quot;:0},&quot;ddlMarkMap&quot;:{&quot;RENAMECOLUMN&quot;:&quot;WARNING&quot;,&quot;DROPTABLE&quot;:&quot;WARNING&quot;,&quot;CREATETABLE&quot;:&quot;IGNORE&quot;,&quot;MODIFYCOLUMN&quot;:&quot;WARNING&quot;,&quot;TRUNCATETABLE&quot;:&quot;NORMAL&quot;,&quot;DROPCOLUMN&quot;:&quot;IGNORE&quot;,&quot;ADDCOLUMN&quot;:&quot;NORMAL&quot;,&quot;RENAMETABLE&quot;:&quot;CRITICAL&quot;}}</para>
        /// </summary>
        [NameInMap("StartParam")]
        [Validation(Required=false)]
        public string StartParam { get; set; }

        /// <summary>
        /// <para>The type of the object that you want to start. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DI_REALTIME: real-time synchronization task</description></item>
        /// <item><description>DI_SOLUTION: data synchronization solution</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DI_REALTIME</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
