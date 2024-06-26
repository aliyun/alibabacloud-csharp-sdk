// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateChaincodeRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        [NameInMap("EndorsePolicy")]
        [Validation(Required=false)]
        public string EndorsePolicy { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OssUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

    }

}
