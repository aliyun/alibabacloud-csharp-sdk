/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class AddShortUrlRequest : TeaModel {
        /// <summary>
        /// The validity period of the short URL. Unit: days. The maximum validity period is 90 days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EffectiveDays")]
        [Validation(Required=false)]
        public string EffectiveDays { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The service name of the short URL. The name cannot exceed 13 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ShortUrlName")]
        [Validation(Required=false)]
        public string ShortUrlName { get; set; }

        /// <summary>
        /// The source URL. The URL cannot exceed 1,000 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

    }

}
