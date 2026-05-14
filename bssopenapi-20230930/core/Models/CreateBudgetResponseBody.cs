// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateBudgetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Department_dev_budget</para>
        /// </summary>
        [NameInMap("BudgetName")]
        [Validation(Required=false)]
        public string BudgetName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39EDD65E-68C5-1B17-8440-C729C7591D74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
