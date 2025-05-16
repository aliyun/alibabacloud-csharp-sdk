// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteConfigRequest : TeaModel {
        /// <summary>
        /// <para>The category of the configuration item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CommonResourceConfig</description></item>
        /// <item><description>DLCAutoRecycle - DLCPriorityConfig</description></item>
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
        /// <para>The filter conditions. Separate multiple conditions with commas (,). The conditions have an AND relationship.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value;key2=value2</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

    }

}
