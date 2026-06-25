// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteConfigRequest : TeaModel {
        /// <summary>
        /// <para>The classification of the configuration item. The following classifications are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>DLCAutoRecycle: The DLC automatic release configuration.</para>
        /// </description></item>
        /// <item><description><para>DLCPriorityConfig: The DLC priority settings.</para>
        /// </description></item>
        /// <item><description><para>DSWPriorityConfig: The DSW priority settings.</para>
        /// </description></item>
        /// <item><description><para>QuotaMaximumDuration: The maximum runtime configuration of a DLC task for a quota.</para>
        /// </description></item>
        /// <item><description><para>CommonTagConfig: The tag settings.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonResourceConfig</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The filter conditions. Separate multiple conditions with commas. The conditions are combined with a logical AND.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value;key2=value2</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

    }

}
