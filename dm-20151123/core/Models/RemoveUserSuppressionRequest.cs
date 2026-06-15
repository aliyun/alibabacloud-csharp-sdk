// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class RemoveUserSuppressionRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the suppressed address. To specify multiple IDs, separate them with commas (,). Call the ListUserSuppression operation to obtain the suppression ID.</para>
        /// <para>You can enter multiple values, separated by a comma &quot;,&quot;.</para>
        /// <para>You can call ListUserSuppression to obtain the SuppressionId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59511</para>
        /// </summary>
        [NameInMap("SuppressionIds")]
        [Validation(Required=false)]
        public string SuppressionIds { get; set; }

    }

}
