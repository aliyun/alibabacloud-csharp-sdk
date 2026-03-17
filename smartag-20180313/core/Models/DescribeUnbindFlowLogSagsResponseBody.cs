// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeUnbindFlowLogSagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of the SAG instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C850C10E-9856-45FF-8640-80288BA467DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Sags")]
        [Validation(Required=false)]
        public DescribeUnbindFlowLogSagsResponseBodySags Sags { get; set; }
        public class DescribeUnbindFlowLogSagsResponseBodySags : TeaModel {
            [NameInMap("Sag")]
            [Validation(Required=false)]
            public List<DescribeUnbindFlowLogSagsResponseBodySagsSag> Sag { get; set; }
            public class DescribeUnbindFlowLogSagsResponseBodySagsSag : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SmartAGId")]
                [Validation(Required=false)]
                public string SmartAGId { get; set; }

            }

        }

    }

}
