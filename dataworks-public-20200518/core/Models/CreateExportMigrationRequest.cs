// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateExportMigrationRequest : TeaModel {
        /// <summary>
        /// <para>The description of the export task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The export mode of the export task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FULL: The export task is used to export all data objects.</description></item>
        /// <item><description>INCREMENTAL: The export task is used to export data objects that were modified since the specified point in time. If you set this parameter to INCREMENTAL, you must configure the IncrementalSince parameter.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FULL</para>
        /// </summary>
        [NameInMap("ExportMode")]
        [Validation(Required=false)]
        public string ExportMode { get; set; }

        /// <summary>
        /// <para>The status of the data objects that you want to export in the export task. The system exports data objects in the state that is specified by this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SAVED</description></item>
        /// <item><description>SUBMITTED</description></item>
        /// <item><description>DEPLOYED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SAVED</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ExportObjectStatus")]
        [Validation(Required=false)]
        public string ExportObjectStatus { get; set; }

        /// <summary>
        /// <para>The start time of the incremental export task.</para>
        /// <para>The IncrementalSince parameter takes effect only when the ExportMode parameter is set to INCREMENTAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1589904000000</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("IncrementalSince")]
        [Validation(Required=false)]
        public long? IncrementalSince { get; set; }

        /// <summary>
        /// <para>The name of the export task.</para>
        /// <para>The name of each export task must be unique. You must ensure that no duplicate export task exists in the current workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_export_01</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
