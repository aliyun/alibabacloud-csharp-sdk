// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyListQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("all_apply")]
        [Validation(Required=false)]
        public bool? AllApply { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dept1</para>
        /// </summary>
        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public string DepartId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2017-05-01 00:00:00</para>
        /// </summary>
        [NameInMap("end_time")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-05-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmt_modified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("only_shang_lv_apply")]
        [Validation(Required=false)]
        public bool? OnlyShangLvApply { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2017-05-01 00:00:00</para>
        /// </summary>
        [NameInMap("start_time")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>btrip123</para>
        /// </summary>
        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abs123</para>
        /// </summary>
        [NameInMap("union_no")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
