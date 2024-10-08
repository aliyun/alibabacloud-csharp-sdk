// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CorpTokenRequest : TeaModel {
        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corp_id")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
