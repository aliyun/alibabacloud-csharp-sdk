// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetCommerceSettingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCommerceSettingResponseBodyData Data { get; set; }
        public class GetCommerceSettingResponseBodyData : TeaModel {
            [NameInMap("CartEnable")]
            [Validation(Required=false)]
            public bool? CartEnable { get; set; }

            [NameInMap("CatalogVisible")]
            [Validation(Required=false)]
            public bool? CatalogVisible { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
