// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLastOnceTaskInfoRequest : TeaModel {
        /// <summary>
        /// <para>The source of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>console_batch</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The name of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: client diagnosis task</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: O\&amp;M task of Cloud Assistant</description></item>
        /// <item><description><b>ASSETS_COLLECTION</b>: asset collection task</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSETS_COLLECTION</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: client diagnosis task</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: O\&amp;M task of Cloud Assistant</description></item>
        /// <item><description><b>ASSETS_COLLECTION</b>: asset collection task</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSETS_COLLECTION</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
