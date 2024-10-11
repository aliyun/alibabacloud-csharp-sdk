// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListFlowControlTaskItemReportsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yesterDay</para>
        /// </summary>
        [NameInMap("selectTimeType")]
        [Validation(Required=false)]
        public string SelectTimeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>invalidItem</para>
        /// </summary>
        [NameInMap("selectType")]
        [Validation(Required=false)]
        public string SelectType { get; set; }

    }

}
