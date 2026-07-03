// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayQuotaRuleRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The page number of the consumer list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("consumerPageNumber")]
        [Validation(Required=false)]
        [Obsolete]
        public string ConsumerPageNumber { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The page size of the consumer list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("consumerPageSize")]
        [Validation(Required=false)]
        [Obsolete]
        public string ConsumerPageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the consumer list.</para>
        /// </summary>
        [NameInMap("withConsumers")]
        [Validation(Required=false)]
        public bool? WithConsumers { get; set; }

    }

}
