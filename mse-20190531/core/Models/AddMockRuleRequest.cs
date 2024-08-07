// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddMockRuleRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the custom application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsumerAppIds")]
        [Validation(Required=false)]
        public string ConsumerAppIds { get; set; }

        /// <summary>
        /// The items in the recycle bin.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DubboMockItems")]
        [Validation(Required=false)]
        public string DubboMockItems { get; set; }

        /// <summary>
        /// Specifies whether to enable the alert rule. Valid values:
        /// 
        /// *   `true`: enables the alert rule.
        /// *   `false`: disables the alert rule.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The description.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExtraJson")]
        [Validation(Required=false)]
        public string ExtraJson { get; set; }

        /// <summary>
        /// The response time (RT) threshold of slow calls. Valid values:
        /// 
        /// *   \\- 15: 15 ms
        /// *   \\- 30: 30 ms
        /// *   \\- 60: 60 ms
        /// *   \\- 120: 120 ms
        /// </summary>
        [NameInMap("MockType")]
        [Validation(Required=false)]
        public long? MockType { get; set; }

        /// <summary>
        /// The name of the rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the service provider application.
        /// </summary>
        [NameInMap("ProviderAppId")]
        [Validation(Required=false)]
        public string ProviderAppId { get; set; }

        /// <summary>
        /// The name of the service provider application.
        /// </summary>
        [NameInMap("ProviderAppName")]
        [Validation(Required=false)]
        public string ProviderAppName { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The input parameters. The JSON format is supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScMockItems")]
        [Validation(Required=false)]
        public string ScMockItems { get; set; }

        /// <summary>
        /// The rule source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
