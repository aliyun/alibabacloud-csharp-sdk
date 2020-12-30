/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class DoIotChgBindOrUnBindRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("Imei")]
        [Validation(Required=false)]
        public string Imei { get; set; }

        [NameInMap("NewImei")]
        [Validation(Required=false)]
        public string NewImei { get; set; }

        [NameInMap("OpionType")]
        [Validation(Required=false)]
        public string OpionType { get; set; }

        [NameInMap("MidChannelId")]
        [Validation(Required=false)]
        public string MidChannelId { get; set; }

    }

}
