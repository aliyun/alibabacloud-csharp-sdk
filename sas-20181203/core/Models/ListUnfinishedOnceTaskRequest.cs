// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnfinishedOnceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The target object value.</para>
        /// <list type="bullet">
        /// <item><description>If TaskType is set to IMAGE_SCAN, you must provide the image digest.</description></item>
        /// <item><description>If TaskType is set to ASSETS_COLLECTION, you must provide the machine UUID.</description></item>
        /// </list>
        /// <para>If this parameter is not provided in the preceding scenarios, the service returns HTTP 400 with error code -101.</para>
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
        /// <item><description><b>IMAGE_SCAN</b>: image scan task</description></item>
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
