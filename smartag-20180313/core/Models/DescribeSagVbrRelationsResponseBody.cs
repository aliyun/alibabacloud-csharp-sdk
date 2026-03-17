// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagVbrRelationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17D79124-104A-42DB-8FCA-CE2957CD1723</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the specified VBR is associated with an SAG instance.</para>
        /// </summary>
        [NameInMap("SagVbrRelations")]
        [Validation(Required=false)]
        public List<DescribeSagVbrRelationsResponseBodySagVbrRelations> SagVbrRelations { get; set; }
        public class DescribeSagVbrRelationsResponseBodySagVbrRelations : TeaModel {
            /// <summary>
            /// <para>The ID of the SAG instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-0nnteglltw6z4b****</para>
            /// </summary>
            [NameInMap("SagInstanceId")]
            [Validation(Required=false)]
            public string SagInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the SAG instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16884015121212****</para>
            /// </summary>
            [NameInMap("SagUid")]
            [Validation(Required=false)]
            public string SagUid { get; set; }

            /// <summary>
            /// <para>The ID of the VBR.</para>
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
