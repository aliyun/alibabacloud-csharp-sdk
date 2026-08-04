// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class ModifyCustomerInfoRequest : TeaModel {
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        [NameInMap("CustomerCategory")]
        [Validation(Required=false)]
        public string CustomerCategory { get; set; }

        [NameInMap("CustomerSubCategory")]
        [Validation(Required=false)]
        public string CustomerSubCategory { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        [NameInMap("Website")]
        [Validation(Required=false)]
        public string Website { get; set; }

    }

}
