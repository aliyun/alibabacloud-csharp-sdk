// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddMockRuleResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddMockRuleResponseBodyData Data { get; set; }
        public class AddMockRuleResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The ID of the consumer application.
            /// </summary>
            [NameInMap("ConsumerAppId")]
            [Validation(Required=false)]
            public string ConsumerAppId { get; set; }

            /// <summary>
            /// The name of the consumer application.
            /// </summary>
            [NameInMap("ConsumerAppName")]
            [Validation(Required=false)]
            public string ConsumerAppName { get; set; }

            /// <summary>
            /// Indicates whether the mock rule is enabled.
            /// 
            /// *   `true`: enabled
            /// *   `false`: disabled
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("ExtraJson")]
            [Validation(Required=false)]
            public string ExtraJson { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The mock type. Valid values:
            /// 
            /// *   \\- `[unk]0[unk]`: desktop client
            /// *   \\- `[unk]1[unk]`: mobile client
            /// </summary>
            [NameInMap("MockType")]
            [Validation(Required=false)]
            public long? MockType { get; set; }

            /// <summary>
            /// The name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the namespace.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

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
            /// The region ID.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The HTTP mock rule.
            /// </summary>
            [NameInMap("ScMockItemJson")]
            [Validation(Required=false)]
            public string ScMockItemJson { get; set; }

            /// <summary>
            /// The service source.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
