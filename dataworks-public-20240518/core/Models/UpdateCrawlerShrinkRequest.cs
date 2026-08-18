// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateCrawlerShrinkRequest : TeaModel {
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
        public string OptionsShrink { get; set; }

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
        public string ScheduleConfigShrink { get; set; }

        /// <summary>
        /// <para>The collection scope configuration. If this parameter is specified, the collection scope is updated. If this parameter is not specified, the existing value remains unchanged.</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string ScopeShrink { get; set; }

    }

}
