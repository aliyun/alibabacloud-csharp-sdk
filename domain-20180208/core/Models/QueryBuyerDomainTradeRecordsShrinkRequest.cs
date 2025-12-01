// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryBuyerDomainTradeRecordsShrinkRequest : TeaModel {
        [NameInMap("BizIdList")]
        [Validation(Required=false)]
        public string BizIdListShrink { get; set; }

        [NameInMap("DomainNameList")]
        [Validation(Required=false)]
        public string DomainNameListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-07-07 23:59:59</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EndPrice")]
        [Validation(Required=false)]
        public float? EndPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;payTime\&quot;:\&quot;desc\&quot;}</para>
        /// </summary>
        [NameInMap("Sorter")]
        [Validation(Required=false)]
        public string Sorter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-05-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartPrice")]
        [Validation(Required=false)]
        public float? StartPrice { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusListShrink { get; set; }

        [NameInMap("SuffixList")]
        [Validation(Required=false)]
        public string SuffixListShrink { get; set; }

        [NameInMap("TradeTypeList")]
        [Validation(Required=false)]
        public string TradeTypeListShrink { get; set; }

    }

}
