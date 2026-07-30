// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The category of the configuration item. The following categories are supported:</para>
        /// <list type="bullet">
        /// <item><description>CommonResourceConfig: common resource configuration</description></item>
        /// <item><description>DLCAutoRecycle: DLC automatic reclamation</description></item>
        /// <item><description>DLCPriorityConfig: DLC priority settings</description></item>
        /// <item><description>DSWPriorityConfig: DSW priority settings</description></item>
        /// <item><description>QuotaMaximumDuration: maximum runtime duration configuration for DLC jobs in a quota</description></item>
        /// <item><description>CommonTagConfig: tag settings</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonResourceConfig</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The key of the configuration item. The following keys are supported:</para>
        /// <list type="bullet">
        /// <item><description>tempStoragePath: the temporary storage path. This key is valid only when CategoryName is set to CommonResourceConfig.</description></item>
        /// <item><description>isAutoRecycle: the automatic reclamation configuration. This key is valid only when CategoryName is set to DLCAutoRecycle.</description></item>
        /// <item><description>priorityConfig: the priority configuration. This key is valid only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</description></item>
        /// <item><description>quotaMaximumDuration: the maximum runtime duration configuration for DLC jobs in a quota. This key is valid only when CategoryName is set to QuotaMaximumDuration.</description></item>
        /// <item><description>predefinedTags: the preset tags for the workspace. Resources created in the workspace must include these tags.</description></item>
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
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The time when the configuration item was created, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-17T06:53:04.000Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the configuration item was last modified, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-17T06:55:04.000Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The list of labels for the configuration item.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<GetConfigResponseBodyLabels> Labels { get; set; }
        public class GetConfigResponseBodyLabels : TeaModel {
            /// <summary>
            /// <para>The key of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A******C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234******2</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
