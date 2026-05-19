// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetLlmProxyConfigForAdminRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>WD20250814102215000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>understand</para>
        /// </summary>
        [NameInMap("Capability")]
        [Validation(Required=false)]
        public string Capability { get; set; }

    }

}
