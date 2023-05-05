// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyListQueryRequest : TeaModel {
        [NameInMap("all_apply")]
        [Validation(Required=false)]
        public bool? AllApply { get; set; }

        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public string DepartId { get; set; }

        [NameInMap("end_time")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("gmt_modified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("only_shang_lv_apply")]
        [Validation(Required=false)]
        public bool? OnlyShangLvApply { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("start_time")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 子企业Id
        /// </summary>
        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("union_no")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
