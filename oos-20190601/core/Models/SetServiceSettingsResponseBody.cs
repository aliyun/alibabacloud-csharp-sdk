// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class SetServiceSettingsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of service settings.
        /// </summary>
        [NameInMap("ServiceSettings")]
        [Validation(Required=false)]
        public List<SetServiceSettingsResponseBodyServiceSettings> ServiceSettings { get; set; }
        public class SetServiceSettingsResponseBodyServiceSettings : TeaModel {
            /// <summary>
            /// The name of OSS bucket to deliver.
            /// </summary>
            [NameInMap("DeliveryOssBucketName")]
            [Validation(Required=false)]
            public string DeliveryOssBucketName { get; set; }

            /// <summary>
            /// Whether to enable OSS delivery.
            /// </summary>
            [NameInMap("DeliveryOssEnabled")]
            [Validation(Required=false)]
            public bool? DeliveryOssEnabled { get; set; }

            /// <summary>
            /// The key prefix of OSS to deliver.
            /// </summary>
            [NameInMap("DeliveryOssKeyPrefix")]
            [Validation(Required=false)]
            public string DeliveryOssKeyPrefix { get; set; }

            /// <summary>
            /// Whether to enable SLS delivery.
            /// </summary>
            [NameInMap("DeliverySlsEnabled")]
            [Validation(Required=false)]
            public bool? DeliverySlsEnabled { get; set; }

            /// <summary>
            /// The name of SLS project to deliver.
            /// </summary>
            [NameInMap("DeliverySlsProjectName")]
            [Validation(Required=false)]
            public string DeliverySlsProjectName { get; set; }

            /// <summary>
            /// The id of RDC Enterprise.
            /// </summary>
            [NameInMap("RdcEnterpriseId")]
            [Validation(Required=false)]
            public string RdcEnterpriseId { get; set; }

        }

    }

}
