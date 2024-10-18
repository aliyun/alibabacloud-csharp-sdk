// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetAuthorizationUrlRequest : TeaModel {
        /// <summary>
        /// <para>The authorization end date, which is in the yyyy-MM-dd format. This parameter is required for services of contract type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020–12–28</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("PhoneNo")]
        [Validation(Required=false)]
        public string PhoneNo { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the authorization scenario. You can view the ID of the authorization scenario on the <b>Authorization Scenario Management</b> page in the <b>Phone Number Verification Service console</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234****</para>
        /// </summary>
        [NameInMap("SchemeId")]
        [Validation(Required=false)]
        public long? SchemeId { get; set; }

    }

}
