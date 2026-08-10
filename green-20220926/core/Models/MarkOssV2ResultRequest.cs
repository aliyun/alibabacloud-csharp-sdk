// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class MarkOssV2ResultRequest : TeaModel {
        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-21 16:08:38 +0800</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The freeze type. This parameter is required when Operation is set to freeze. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACL: Modify file permissions.</description></item>
        /// <item><description>COPY: Move the file to a directory. The destination directory is determined as follows: 1. The directory selected when the task was created takes priority. 2. If automatic freezing was not enabled during creation, or ACL freezing was configured, the directory selected during freezing in the console is used. 3. The default directory is alicip_riskfile_backup/.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACL</para>
        /// </summary>
        [NameInMap("FreezeType")]
        [Validation(Required=false)]
        public string FreezeType { get; set; }

        /// <summary>
        /// <para>The processing operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>freeze: freeze.</description></item>
        /// <item><description>unfreeze: unfreeze.</description></item>
        /// <item><description>misreport: false positive (not in violation).</description></item>
        /// <item><description>missOut: missed violation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>freeze</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestIds")]
        [Validation(Required=false)]
        public string RequestIds { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-21 16:08:38 +0800</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Image stock task 20240914100517757</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
