// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnfinishedOnceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The target object value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the task type is <b>IMAGE_SCAN</b>, the target object value is the <b>Digest</b> of the image.</description></item>
        /// <item><description>If the task type is <b>ASSETS_COLLECTION</b>, the target object value is the <b>Uuid</b> of the server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4fe8e1cd-3c37-4851-b9de-124da32c****</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASSETS_COLLECTION</b>: asset information collection task</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: image scan task.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_SCAN</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
