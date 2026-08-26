// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AddPolarOSSAuthorizedAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The updated list of RAM role ARNs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arn:sts::123456:assumed-role/myrole/*</para>
        /// </summary>
        [NameInMap("AuthorizedUserArnIds")]
        [Validation(Required=false)]
        public string AuthorizedUserArnIds { get; set; }

        /// <summary>
        /// <para>The updated list of UIDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890,9876543210</para>
        /// </summary>
        [NameInMap("AuthorizedUserIds")]
        [Validation(Required=false)]
        public string AuthorizedUserIds { get; set; }

        /// <summary>
        /// <para>The cold storage instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("PfsInstanceId")]
        [Validation(Required=false)]
        public string PfsInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F45FFACC-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
