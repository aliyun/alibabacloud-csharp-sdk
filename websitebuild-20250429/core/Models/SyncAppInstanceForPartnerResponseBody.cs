// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SyncAppInstanceForPartnerResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SyncAppInstanceForPartnerResponseBodyData Data { get; set; }
        public class SyncAppInstanceForPartnerResponseBodyData : TeaModel {
            [NameInMap("AppInstance")]
            [Validation(Required=false)]
            public SyncAppInstanceForPartnerResponseBodyDataAppInstance AppInstance { get; set; }
            public class SyncAppInstanceForPartnerResponseBodyDataAppInstance : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>WD20250626114752000001</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
