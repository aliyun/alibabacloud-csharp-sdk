// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class MarkOssV2ResultRequest : TeaModel {
        /// <summary>
        /// <para>The end time. Specify the time in the YYYY-MM-DD HH:mm:ss format.</para>
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
        /// <item><description>ACL: Modifies file permissions.</description></item>
        /// <item><description>COPY: Moves the file directory. Destination directory rules: 1. The file directory selected during task creation takes precedence. 2. If automatic freezing is not enabled during creation, or if ACL freezing is configured, the directory selected in the console during freezing is used. 3. The default directory is alicip_riskfile_backup/.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACL</para>
        /// </summary>
        [NameInMap("FreezeType")]
        [Validation(Required=false)]
        public string FreezeType { get; set; }

        /// <summary>
        /// <para>The handling operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>freeze: Freezes the object.</description></item>
        /// <item><description>unfreeze: Unfreezes the object.</description></item>
        /// <item><description>misreport: Reports a false positive.</description></item>
        /// <item><description>missOut: Reports a missed violation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>freeze</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The request IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestIds")]
        [Validation(Required=false)]
        public string RequestIds { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the YYYY-MM-DD HH:mm:ss format.</para>
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
        /// <para>Image inventory task 20240914100517757</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
