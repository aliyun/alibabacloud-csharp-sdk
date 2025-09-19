// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCycleTaskListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task configuration.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~CreateCycleTask~~">CreateCycleTask</a> operation to query the IDs of task configurations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>f93b6ee24cfd0aad44b897ad5051****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_VUL_SCHEDULE_SCAN</b>: virus scan task</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: image scan task</description></item>
        /// <item><description><b>EMG_VUL_SCHEDULE_SCAN</b>: urgent vulnerability scan task</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_SCAN</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_VUL_SCHEDULE_SCAN</b>: virus scan task</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: image scan task</description></item>
        /// <item><description><b>EMG_VUL_SCHEDULE_SCAN</b>: urgent vulnerability scan task</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_SCAN</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
