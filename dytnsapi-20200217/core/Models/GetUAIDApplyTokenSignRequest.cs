// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class GetUAIDApplyTokenSignRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Carrier")]
        [Validation(Required=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        [NameInMap("Format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ParamKey")]
        [Validation(Required=false)]
        public string ParamKey { get; set; }

        [NameInMap("ParamStr")]
        [Validation(Required=false)]
        public string ParamStr { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
