// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class OperateAppInstanceForPartnerRequest : TeaModel {
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SERVICE_DELIVERY_PROCESS</para>
        /// </summary>
        [NameInMap("OperateEvent")]
        [Validation(Required=false)]
        public string OperateEvent { get; set; }

    }

}
