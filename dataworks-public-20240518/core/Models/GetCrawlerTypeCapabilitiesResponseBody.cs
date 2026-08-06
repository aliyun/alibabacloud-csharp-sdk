// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCrawlerTypeCapabilitiesResponseBody : TeaModel {
        [NameInMap("CrawlerTypes")]
        [Validation(Required=false)]
        public List<GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypes> CrawlerTypes { get; set; }
        public class GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>DATABASE</para>
            /// </summary>
            [NameInMap("DefaultScopeUnit")]
            [Validation(Required=false)]
            public string DefaultScopeUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Hologres</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("RequireResourceGroup")]
            [Validation(Required=false)]
            public bool? RequireResourceGroup { get; set; }

            [NameInMap("SupportAiComment")]
            [Validation(Required=false)]
            public bool? SupportAiComment { get; set; }

            [NameInMap("SupportExcludeRegex")]
            [Validation(Required=false)]
            public bool? SupportExcludeRegex { get; set; }

            [NameInMap("SupportSchedule")]
            [Validation(Required=false)]
            public bool? SupportSchedule { get; set; }

            [NameInMap("SupportedDatasourceTypes")]
            [Validation(Required=false)]
            public List<string> SupportedDatasourceTypes { get; set; }

            [NameInMap("SupportedEntityTypes")]
            [Validation(Required=false)]
            public List<GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypesSupportedEntityTypes> SupportedEntityTypes { get; set; }
            public class GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypesSupportedEntityTypes : TeaModel {
                [NameInMap("Optional")]
                [Validation(Required=false)]
                public bool? Optional { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
                [NameInMap("ParentSubType")]
                [Validation(Required=false)]
                public string ParentSubType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>database</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>holo</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("SupportedOptionKeys")]
            [Validation(Required=false)]
            public List<GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypesSupportedOptionKeys> SupportedOptionKeys { get; set; }
            public class GetCrawlerTypeCapabilitiesResponseBodyCrawlerTypesSupportedOptionKeys : TeaModel {
                [NameInMap("AllowedValues")]
                [Validation(Required=false)]
                public List<string> AllowedValues { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CollectRecyclebin</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BOOLEAN</para>
                /// </summary>
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

            [NameInMap("SupportedScopeUnits")]
            [Validation(Required=false)]
            public List<string> SupportedScopeUnits { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>holo</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9252F32F-D855-549E-8898-61CF5A733050</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
