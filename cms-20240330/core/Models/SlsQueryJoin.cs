// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SlsQueryJoin : TeaModel {
        /// <summary>
        /// <para>The list of join conditions.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<SlsJoinCondition> Conditions { get; set; }

        /// <summary>
        /// <para>The set operation type. Valid values: InnerJoin, LeftJoin, RightJoin, FullJoin, LeftExclude, RightExclude, CrossJoin, NoJoin, and Concat.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
