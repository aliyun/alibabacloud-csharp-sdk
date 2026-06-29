// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class SimpleTask : TeaModel {
        /// <summary>
        /// <para>Indicates whether the job is archived. Possible values:  </para>
        /// <list type="bullet">
        /// <item><description>false: Not archived.  </description></item>
        /// <item><description>true: Archived.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Archived")]
        [Validation(Required=false)]
        public bool? Archived { get; set; }

        /// <summary>
        /// <para>Data archiving information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ArchivedInfos")]
        [Validation(Required=false)]
        public string ArchivedInfos { get; set; }

        /// <summary>
        /// <para>Creator information.</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public SimpleUser Creator { get; set; }

        /// <summary>
        /// <para>UTC creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-07 16:09:20</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>UTC time of the last update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-07 16:09:20</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Label style.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMG</para>
        /// </summary>
        [NameInMap("LabelStyle")]
        [Validation(Required=false)]
        public string LabelStyle { get; set; }

        /// <summary>
        /// <para>Updated By information.</para>
        /// </summary>
        [NameInMap("Modifier")]
        [Validation(Required=false)]
        public SimpleUser Modifier { get; set; }

        /// <summary>
        /// <para>Auto triggered task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***5124</para>
        /// </summary>
        [NameInMap("RefTaskId")]
        [Validation(Required=false)]
        public string RefTaskId { get; set; }

        /// <summary>
        /// <para>Remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Current streaming node. Possible values:  </para>
        /// <list type="bullet">
        /// <item><description>MARK: Annotating.  </description></item>
        /// <item><description>CHECK: Checking.  </description></item>
        /// <item><description>FINISHED: Completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MARK</para>
        /// </summary>
        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        /// <summary>
        /// <para>Task Status. Possible values:  </para>
        /// <list type="bullet">
        /// <item><description>CREATED  </description></item>
        /// <item><description>SUCCESS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>List of job labels.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>Job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15438***8306500608</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>Task Type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>Template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1529***348342353920</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GA***W134</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paiworkspace-****</para>
        /// </summary>
        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

        /// <summary>
        /// <para>Pipeline nodes.</para>
        /// </summary>
        [NameInMap("WorkflowNodes")]
        [Validation(Required=false)]
        public List<string> WorkflowNodes { get; set; }

    }

}
