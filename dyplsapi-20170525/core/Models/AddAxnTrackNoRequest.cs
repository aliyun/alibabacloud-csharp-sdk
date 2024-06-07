/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class AddAxnTrackNoRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The private number in the AXN binding, that is, phone number X.
        /// 
        /// You can call the [BindAxn](https://help.aliyun.com/document_detail/110258.html) operation to obtain the value of PhoneNoX.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        /// <summary>
        /// The key of the phone number pool. Log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) and view the key of the phone number pool on the **Number Pool Management** page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The binding ID.
        /// 
        /// You can call the [BindAxn](https://help.aliyun.com/document_detail/110258.html) operation to obtain the value of SubsId.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubsId")]
        [Validation(Required=false)]
        public string SubsId { get; set; }

        /// <summary>
        /// The tracking number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("trackNo")]
        [Validation(Required=false)]
        public string TrackNo { get; set; }

    }

}
