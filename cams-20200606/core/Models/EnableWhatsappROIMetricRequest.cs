// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class EnableWhatsappROIMetricRequest : TeaModel {
        /// <summary>
        /// The space ID of the user under the independent software vendor (ISV) account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The independent software vendor (ISV) verification code, which is used to verify whether the user is authorized by the ISV account.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

    }

}
