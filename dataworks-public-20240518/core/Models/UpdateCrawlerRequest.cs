// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateCrawlerRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable AI metadata description. This parameter is supported only when SupportAiComment returned by GetCrawlerTypeCapabilities is set to true. If this parameter is not specified, the existing value remains unchanged.</para>
        /// </summary>
        [NameInMap("EnableAiComment")]
        [Validation(Required=false)]
        public bool? EnableAiComment { get; set; }

        /// <summary>
        /// <para>The ID of the metadata crawler. You can call ListCrawlers to query crawler IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The extension configurations for the crawler type. Only the specified configuration items are updated. Unspecified configuration items remain unchanged. The supported keys and values are determined by the SupportedOptionKeys returned by GetCrawlerTypeCapabilities.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// <para>The ID of the Serverless 2.0 resource group used to run the collection task. Whether this parameter is supported and whether it is required depend on the capabilities returned by GetCrawlerTypeCapabilities. If this parameter is not specified, the existing value remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Serverless_res_group_1234567890123456_1234567890</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The scheduling configuration. If this parameter is specified, the scheduling method is updated. If this parameter is not specified, the existing value remains unchanged.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public UpdateCrawlerRequestScheduleConfig ScheduleConfig { get; set; }
        public class UpdateCrawlerRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The six-field cron expression for periodic scheduling. This parameter is required when Type is set to NORMAL. The seconds field must be 0, and the scheduling frequency cannot exceed once per hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 2 ? * *</para>
            /// </summary>
            [NameInMap("CronExpress")]
            [Validation(Required=false)]
            public string CronExpress { get; set; }

            /// <summary>
            /// <para>The scheduling type. MANUAL indicates manual execution. NORMAL indicates periodic scheduling. Data sources in the development environment support only MANUAL. Whether NORMAL is available depends on the SupportSchedule value returned by GetCrawlerTypeCapabilities.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The collection scope configuration. If this parameter is specified, the collection scope is updated. If this parameter is not specified, the existing value remains unchanged.</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public UpdateCrawlerRequestScope Scope { get; set; }
        public class UpdateCrawlerRequestScope : TeaModel {
            /// <summary>
            /// <para>The regular expression used to exclude objects from the collection scope. This parameter is supported only when SupportExcludeRegex returned by GetCrawlerTypeCapabilities is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>^tmp_.*</para>
            /// </summary>
            [NameInMap("ExcludeRegex")]
            [Validation(Required=false)]
            public string ExcludeRegex { get; set; }

            /// <summary>
            /// <para>The list of database names. This parameter is supported only when Unit is set to DATABASE. A maximum of 1,000 entries are allowed. Names cannot be empty or duplicate.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<string> Items { get; set; }

            /// <summary>
            /// <para>The collection scope granularity. Valid values are determined by the SupportedScopeUnits returned by GetCrawlerTypeCapabilities.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATABASE</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

    }

}
