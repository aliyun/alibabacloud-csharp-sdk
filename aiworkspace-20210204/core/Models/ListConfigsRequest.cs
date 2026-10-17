// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The categorization of the configuration item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CommonResourceConfig: general resource configuration</description></item>
        /// <item><description>DLCAutoRecycle: automatic DLC revoke</description></item>
        /// <item><description>DLCPriorityConfig: DLC priority settings</description></item>
        /// <item><description>DSWPriorityConfig: DSW priority settings</description></item>
        /// <item><description>QuotaMaximumDuration: maximum runtime configuration of DLC nodes for a quota</description></item>
        /// <item><description>CommonTagConfig: label settings</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonResourceConfig</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The keys of the configuration items. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tempStoragePath: Temporary storage path. This key is allowed only when CategoryName is set to CommonResourceConfig.</description></item>
        /// <item><description>isAutoRecycle: Automatic revoke configuration. This key is allowed only when CategoryName is set to DLCAutoRecycle.</description></item>
        /// <item><description>priorityConfig: Priority configuration. This key is allowed only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</description></item>
        /// <item><description>quotaMaximumDuration: Maximum runtime configuration of DLC nodes for a quota. This key is allowed only when CategoryName is set to QuotaMaximumDuration.</description></item>
        /// <item><description>predefinedTags: Preset labels for the workspace. Resources created must have these labels.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tempStoragePath</para>
        /// </summary>
        [NameInMap("ConfigKeys")]
        [Validation(Required=false)]
        public string ConfigKeys { get; set; }

        /// <summary>
        /// <para>The labels used as filter conditions. Separate multiple conditions with commas. These conditions are combined by using the AND operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value1,key2=value2</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The additional options. Currently, only ThrowExceptionOnError is supported, which indicates that an error is thrown when an exception occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ThrowExceptionOnError</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>Specifies whether to display label information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Displays label information.</description></item>
        /// <item><description>false: Does not display label information.</description></item>
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
