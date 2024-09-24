// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetRegistryScanDayNumRequest : TeaModel {
        /// <summary>
        /// <para>The cycle at which you want to scan your images. Unit: days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanDayNum")]
        [Validation(Required=false)]
        public int? ScanDayNum { get; set; }

    }

}
