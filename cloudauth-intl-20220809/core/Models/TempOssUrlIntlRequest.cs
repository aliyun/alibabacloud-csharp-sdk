// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class TempOssUrlIntlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250512/pdf/579047.pdf</para>
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

    }

}
