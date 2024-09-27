// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RenewElasticityAssurancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the renewal order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>182372800****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The IDs of the elasticity assurances.</para>
        /// </summary>
        [NameInMap("PrivatePoolOptionsIdSet")]
        [Validation(Required=false)]
        public RenewElasticityAssurancesResponseBodyPrivatePoolOptionsIdSet PrivatePoolOptionsIdSet { get; set; }
        public class RenewElasticityAssurancesResponseBodyPrivatePoolOptionsIdSet : TeaModel {
            [NameInMap("PrivatePoolOptionsId")]
            [Validation(Required=false)]
            public List<string> PrivatePoolOptionsId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
