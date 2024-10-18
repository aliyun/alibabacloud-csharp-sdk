// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateDeliveryPlanRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1699265024987</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1028</para>
        /// </summary>
        [NameInMap("ResId")]
        [Validation(Required=false)]
        public string ResId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1699265024987</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateDeliveryPlanRequestTenantContext TenantContext { get; set; }
        public class CreateDeliveryPlanRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("UserIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
