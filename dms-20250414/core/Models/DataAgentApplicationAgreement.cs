// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DataAgentApplicationAgreement : TeaModel {
        /// <summary>
        /// <para>The expiration time of the agreement in ISO 8601 UTC string format. This field is omitted if the agreement is unsigned. The agreement expires when this time is reached. The default validity period is 10 calendar years from the signing date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2036-11-23T08:00:00Z</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// <para>The region of the workspace to which the agreement belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The signing time in ISO 8601 UTC string format. This field is omitted if the agreement is unsigned. Repeated signing within the validity period retains the original time, and re-signing after expiration updates the time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-23T08:00:00Z</para>
        /// </summary>
        [NameInMap("SignedAt")]
        [Validation(Required=false)]
        public string SignedAt { get; set; }

        /// <summary>
        /// <para>The agreement status. Valid values: NOT_SIGNED (unsigned), EXPIRED (expired), and SIGNED (signed and valid). Both NOT_SIGNED and EXPIRED are business statuses returned upon a successful query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIGNED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The stable identifier of the workspace to which the agreement belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62q1xxxxxxxxxxxxxxxxxxx0</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
