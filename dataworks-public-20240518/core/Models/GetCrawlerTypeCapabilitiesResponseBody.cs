// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCrawlerTypeCapabilitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of crawler types and capabilities supported in the current region.</para>
        /// </summary>
        [NameInMap("CrawlerTypes")]
        [Validation(Required=false)]
        public List<GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypes> CrawlerTypes { get; set; }
        public class GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypes : TeaModel {
            /// <summary>
            /// <para>The default collection scope granularity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATABASE</para>
            /// </summary>
            [NameInMap("DefaultScopeUnit")]
            [Validation(Required=false)]
            public string DefaultScopeUnit { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hologres</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Indicates whether a resource group must be specified when creating this type of crawler.</para>
            /// </summary>
            [NameInMap("RequireResourceGroup")]
            [Validation(Required=false)]
            public bool? RequireResourceGroup { get; set; }

            /// <summary>
            /// <para>Indicates whether AI metadata description is supported.</para>
            /// </summary>
            [NameInMap("SupportAiComment")]
            [Validation(Required=false)]
            public bool? SupportAiComment { get; set; }

            /// <summary>
            /// <para>Indicates whether schema or table exclusion regular expressions are supported.</para>
            /// </summary>
            [NameInMap("SupportExcludeRegex")]
            [Validation(Required=false)]
            public bool? SupportExcludeRegex { get; set; }

            /// <summary>
            /// <para>Indicates whether periodic scheduling is supported.</para>
            /// </summary>
            [NameInMap("SupportSchedule")]
            [Validation(Required=false)]
            public bool? SupportSchedule { get; set; }

            /// <summary>
            /// <para>The list of supported data source types.</para>
            /// </summary>
            [NameInMap("SupportedDatasourceTypes")]
            [Validation(Required=false)]
            public List<string> SupportedDatasourceTypes { get; set; }

            /// <summary>
            /// <para>The metadata entity levels that the crawler type supports for collection.</para>
            /// </summary>
            [NameInMap("SupportedEntityTypes")]
            [Validation(Required=false)]
            public List<GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypesSupportedEntityTypes> SupportedEntityTypes { get; set; }
            public class GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypesSupportedEntityTypes : TeaModel {
                /// <summary>
                /// <para>Indicates whether the metadata entity level is optional.</para>
                /// </summary>
                [NameInMap("Optional")]
                [Validation(Required=false)]
                public bool? Optional { get; set; }

                /// <summary>
                /// <para>The parent-level metadata entity subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
                [NameInMap("ParentSubType")]
                [Validation(Required=false)]
                public string ParentSubType { get; set; }

                /// <summary>
                /// <para>The metadata entity subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>database</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// <para>The metadata entity type identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>holo</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The supported crawler extension configuration items.</para>
            /// </summary>
            [NameInMap("SupportedOptionKeys")]
            [Validation(Required=false)]
            public List<GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypesSupportedOptionKeys> SupportedOptionKeys { get; set; }
            public class GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypesSupportedOptionKeys : TeaModel {
                /// <summary>
                /// <para>The list of allowed values for the extension configuration item.</para>
                /// </summary>
                [NameInMap("AllowedValues")]
                [Validation(Required=false)]
                public List<string> AllowedValues { get; set; }

                /// <summary>
                /// <para>The default value of the extension configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The name of the extension configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CollectRecyclebin</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Indicates whether the extension configuration item is required.</para>
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <para>The value type of the extension configuration item, such as BOOLEAN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BOOLEAN</para>
                /// </summary>
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

            /// <summary>
            /// <para>The list of supported collection scope granularities.</para>
            /// </summary>
            [NameInMap("SupportedScopeUnits")]
            [Validation(Required=false)]
            public List<string> SupportedScopeUnits { get; set; }

            /// <summary>
            /// <para>The crawler type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>holo</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used for locating logs and troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9252F32F-D855-549E-8898-61CF5A733050</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
