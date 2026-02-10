// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAIStudioResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Valid values: 1 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StudioConfigs")]
        [Validation(Required=false)]
        public DescribeLiveAIStudioResponseBodyStudioConfigs StudioConfigs { get; set; }
        public class DescribeLiveAIStudioResponseBodyStudioConfigs : TeaModel {
            [NameInMap("SubtitleConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveAIStudioResponseBodyStudioConfigsSubtitleConfig> SubtitleConfig { get; set; }
            public class DescribeLiveAIStudioResponseBodyStudioConfigsSubtitleConfig : TeaModel {
                [NameInMap("BackgroundResourceId")]
                [Validation(Required=false)]
                public string BackgroundResourceId { get; set; }

                [NameInMap("BackgroundResourceUrl")]
                [Validation(Required=false)]
                public string BackgroundResourceUrl { get; set; }

                [NameInMap("BackgroundType")]
                [Validation(Required=false)]
                public string BackgroundType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("MattingLayout")]
                [Validation(Required=false)]
                public string MattingLayout { get; set; }

                [NameInMap("MattingType")]
                [Validation(Required=false)]
                public string MattingType { get; set; }

                [NameInMap("MediaLayout")]
                [Validation(Required=false)]
                public string MediaLayout { get; set; }

                [NameInMap("MediaResourceId")]
                [Validation(Required=false)]
                public string MediaResourceId { get; set; }

                [NameInMap("MediaResourceUrl")]
                [Validation(Required=false)]
                public string MediaResourceUrl { get; set; }

                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                [NameInMap("RuleIds")]
                [Validation(Required=false)]
                public DescribeLiveAIStudioResponseBodyStudioConfigsSubtitleConfigRuleIds RuleIds { get; set; }
                public class DescribeLiveAIStudioResponseBodyStudioConfigsSubtitleConfigRuleIds : TeaModel {
                    [NameInMap("ruleId")]
                    [Validation(Required=false)]
                    public List<string> RuleId { get; set; }

                }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
