// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyQueryRequest : TeaModel {
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public int? ApplyId { get; set; }

        [NameInMap("apply_show_id")]
        [Validation(Required=false)]
        public string ApplyShowId { get; set; }

        /// <summary>
        /// 子企业Id
        /// </summary>
        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
