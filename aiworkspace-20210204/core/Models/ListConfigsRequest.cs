// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The category of the configuration item. Supported categories:</para>
        /// <list type="bullet">
        /// <item><description>CommonResourceConfig</description></item>
        /// <item><description>DLCAutoRecycle</description></item>
        /// <item><description>DLCPriorityConfig</description></item>
        /// <item><description>DSWPriorityConfig</description></item>
        /// <item><description>QuotaMaximumDuration</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonResourceConfig</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The key of the configuration item. Supported keys:</para>
        /// <list type="bullet">
        /// <item><description>tempStoragePath: Temporary storage path. This key can be used only when CategoryName is set to CommonResourceConfig.</description></item>
        /// <item><description>isAutoRecycle: Automatic recycle configuration. This key can be used only when CategoryName is set to DLCAutoRecycle.</description></item>
        /// <item><description>priorityConfig: Priority configuration. This key can be used only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</description></item>
        /// <item><description>quotaMaximumDuration Maximum run time of DLC jobs for a quota. This key can be used only when CategoryName is set to QuotaMaximumDuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tempStoragePath</para>
        /// </summary>
        [NameInMap("ConfigKeys")]
        [Validation(Required=false)]
        public string ConfigKeys { get; set; }

        /// <summary>
        /// <para>The tags used as filter conditions. Separate multiple tags with commas (,). These conditions are in an AND relationship.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value1,key2=value2</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>Specifies whether to show the tag information.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public string Verbose { get; set; }

    }

}
