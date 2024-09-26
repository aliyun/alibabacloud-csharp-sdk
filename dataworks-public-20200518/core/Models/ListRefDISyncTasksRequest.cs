// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRefDISyncTasksRequest : TeaModel {
        /// <summary>
        /// <para>The name of the data source. You can call the <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> operation to query the name of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_datasource</para>
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The condition used to filter synchronization tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>from: queries the synchronization tasks that use the data source as the source.</description></item>
        /// <item><description>to: queries the synchronization tasks that use the data source as the destination.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>from</para>
        /// </summary>
        [NameInMap("RefType")]
        [Validation(Required=false)]
        public string RefType { get; set; }

        /// <summary>
        /// <para>The type of the synchronization task that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DI_OFFLINE: batch synchronization task</description></item>
        /// <item><description>DI_REALTIME: real-time synchronization task</description></item>
        /// </list>
        /// <para>You can call the ListRefDISyncTasks operation to query only one type of the task.</para>
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
