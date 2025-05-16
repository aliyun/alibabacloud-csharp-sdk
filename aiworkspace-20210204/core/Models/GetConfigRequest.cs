// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetConfigRequest : TeaModel {
        /// <summary>
        /// <para>The category of the configuration item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CommonResourceConfig</description></item>
        /// <item><description>DLCAutoRecycle</description></item>
        /// <item><description>DLCPriorityConfig</description></item>
        /// <item><description>DSWPriorityConfig</description></item>
        /// <item><description>QuotaMaximumDuration</description></item>
        /// <item><description>CommonTagConfig</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonResourceConfig</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The key of the configuration item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tempStoragePath: Temporary storage path. This key can be used only when CategoryName is set to CommonResourceConfig.</description></item>
        /// <item><description>isAutoRecycle: Automatic recycle configuration. This key can be used only when CategoryName is set to DLCAutoRecycle.</description></item>
        /// <item><description>priorityConfig: Priority configuration. This key can be used only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</description></item>
        /// <item><description>quotaMaximumDuration: Maximum run time of DLC jobs for a quota. This key can be used only when CategoryName is set to QuotaMaximumDuration.</description></item>
        /// <item><description>predefinedTags: Predefined tags of the workspace. Created resources must include tags.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tempStoragePath</para>
        /// </summary>
        [NameInMap("ConfigKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// <para>The value of the configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://***</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public string Verbose { get; set; }

    }

}
