// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class SharePrivacyRuleRequest : TeaModel {
        [NameInMap("MemberIdList")]
        [Validation(Required=false)]
        public string MemberIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PrivacyRuleId")]
        [Validation(Required=false)]
        public string PrivacyRuleId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
