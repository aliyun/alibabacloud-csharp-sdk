// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryPhoneNoAByTrackNoRequest : TeaModel {
        /// <summary>
        /// <para>The cabinet number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25689****</para>
        /// </summary>
        [NameInMap("CabinetNo")]
        [Validation(Required=false)]
        public string CabinetNo { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Phone number X returned by the API operation for creating a binding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710000****</para>
        /// </summary>
        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tracking number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22573****</para>
        /// </summary>
        [NameInMap("trackNo")]
        [Validation(Required=false)]
        public string TrackNo { get; set; }

    }

}
