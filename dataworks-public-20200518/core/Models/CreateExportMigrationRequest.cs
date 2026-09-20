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
        /// <para>The export mode of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FULL: exports the target task in full.</description></item>
        /// <item><description>INCREMENTAL: incrementally exports the target task from a specified point in time. If you select this mode, you must also configure the IncrementalSince parameter.</description></item>
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
        /// <para>The status of the export task. The system exports tasks in the specified status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SAVED: saved. Tasks that have been saved are exported.</description></item>
        /// <item><description>SUBMITTED: submitted. Tasks that have been submitted are exported.</description></item>
        /// <item><description>DEPLOYED: deployed. Tasks that have been deployed are exported.</description></item>
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
        /// <para>The start time for incrementally exporting the target node.</para>
        /// <para>This parameter takes effect only when the ExportMode parameter settings is set to INCREMENTAL.</para>
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
        /// <para>The name must be unique. No duplicate export task names can exist in the current DataWorks workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_export_01</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
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
