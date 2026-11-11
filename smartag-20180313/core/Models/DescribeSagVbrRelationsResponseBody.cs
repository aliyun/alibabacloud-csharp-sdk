// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagVbrRelationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17D79124-104A-42DB-8FCA-CE2957CD1723</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The association information.</para>
        /// </summary>
        [NameInMap("SagVbrRelations")]
        [Validation(Required=false)]
        public List<DescribeSagVbrRelationsResponseBodySagVbrRelations> SagVbrRelations { get; set; }
        public class DescribeSagVbrRelationsResponseBodySagVbrRelations : TeaModel {
            /// <summary>
            /// <para>The instance ID of the Smart Access Gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-0nnteglltw6z4b****</para>
            /// </summary>
            [NameInMap("SagInstanceId")]
            [Validation(Required=false)]
            public string SagInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the Smart Access Gateway instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16884015121212****</para>
            /// </summary>
            [NameInMap("SagUid")]
            [Validation(Required=false)]
            public string SagUid { get; set; }

            /// <summary>
            /// <para>The instance ID of the virtual border router (VBR) used for routing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-bp15ihkk93ezxppk****</para>
            /// </summary>
            [NameInMap("VbrInstanceId")]
            [Validation(Required=false)]
            public string VbrInstanceId { get; set; }

        }

    }

}
