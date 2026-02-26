// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LimitRule : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1724947200000</para>
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("condcase")]
        [Validation(Required=false)]
        public string Condcase { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1724947200000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("limitNum")]
        [Validation(Required=false)]
        public int? LimitNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UpperNumberPerUser</para>
        /// </summary>
        [NameInMap("ruleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
