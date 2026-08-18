// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateCrawlerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data source associated with the crawler. The data source must be bound to a DataWorks workspace, and the data source type must match the Type value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable AI metadata descriptions. This parameter is supported only when the SupportAiComment value returned by GetCrawlerTypeCapabilities is true.</para>
        /// </summary>
        [NameInMap("EnableAiComment")]
        [Validation(Required=false)]
        public bool? EnableAiComment { get; set; }

        /// <summary>
        /// <para>The name of the metadata crawler. The name can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example_crawler</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The extended configuration for the crawler type. The key names, value types, required fields, default values, and valid values are determined by the SupportedOptionKeys value returned by GetCrawlerTypeCapabilities.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// <para>The ID of the Serverless 2.0 resource group used to run the collection task. Whether this parameter is required depends on the RequireResourceGroup value returned by GetCrawlerTypeCapabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Serverless_res_group_1234567890123456_1234567890</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The scheduling configuration. If this parameter is not specified, manual scheduling is used.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public CreateCrawlerRequestScheduleConfig ScheduleConfig { get; set; }
        public class CreateCrawlerRequestScheduleConfig : TeaModel {
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
            /// <para>The scheduling type. MANUAL indicates manual execution, and NORMAL indicates periodic scheduling. Data sources in the development environment support only MANUAL. Whether NORMAL is available depends on the SupportSchedule value returned by GetCrawlerTypeCapabilities.</para>
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
        /// <para>The collection scope configuration. If this parameter is not specified, the DefaultScopeUnit value returned by GetCrawlerTypeCapabilities is used.</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public CreateCrawlerRequestScope Scope { get; set; }
        public class CreateCrawlerRequestScope : TeaModel {
            /// <summary>
            /// <para>The regular expression used to exclude objects from the collection scope. This parameter is supported only when the SupportExcludeRegex value returned by GetCrawlerTypeCapabilities is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>^tmp_.*</para>
            /// </summary>
            [NameInMap("ExcludeRegex")]
            [Validation(Required=false)]
            public string ExcludeRegex { get; set; }

            /// <summary>
            /// <para>The list of database names. This parameter is supported only when Unit is set to DATABASE. A maximum of 1000 entries are allowed. Names cannot be empty or duplicated.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<string> Items { get; set; }

            /// <summary>
            /// <para>The collection scope granularity. Valid values are determined by the SupportedScopeUnits value returned by GetCrawlerTypeCapabilities.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATABASE</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The crawler type. Call GetCrawlerTypeCapabilities to query the valid values supported in the current region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>starrocks</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
