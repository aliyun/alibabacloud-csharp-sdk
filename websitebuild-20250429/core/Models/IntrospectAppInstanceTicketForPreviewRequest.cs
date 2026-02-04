// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class IntrospectAppInstanceTicketForPreviewRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>WS12345678</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ogxMqT04nnZOqdIqJZldbm-ZNsAVDz5mcqdCSudfX0SL61jjyWfV-ZnAO-OVpCt_aDl8xaaIO1OVkuvEcMn-HR_QddvaxMqIdsMY1cHdD4SDiRfOBGNdnpSdX9gG_Hi_.ab9c10816d913b51d87520ce0a72b2970668144c552689e9d9e211eb4529f0ea</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
