// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class OperateAppServiceForPartnerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>WS00001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;user_device_id\&quot;:\&quot;6bef45cb0c76de284d24de074c088b73\&quot;}\n</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SERVICE_FINISH</para>
        /// </summary>
        [NameInMap("OperateEvent")]
        [Validation(Required=false)]
        public string OperateEvent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WEBSITE_DESIGN</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
