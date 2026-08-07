// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeletePolarOSSAuthorizedAccountRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890,acs:ram::123456:role/myrole</para>
        /// </summary>
        [NameInMap("AuthorizedUserIds")]
        [Validation(Required=false)]
        public string AuthorizedUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-xxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("PfsInstanceId")]
        [Validation(Required=false)]
        public string PfsInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
