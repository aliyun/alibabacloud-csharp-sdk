// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryCorpDetailInfoRequest : TeaModel {
        [NameInMap("account_id")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>btripxxxxxx</para>
        /// </summary>
        [NameInMap("target_corp_id")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("target_third_corp_id")]
        [Validation(Required=false)]
        public string TargetThirdCorpId { get; set; }

    }

}
