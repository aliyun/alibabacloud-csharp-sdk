// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetImageScanNumInPeriodRequest : TeaModel {
        /// <summary>
        /// <para>The number of days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PastDay")]
        [Validation(Required=false)]
        public string PastDay { get; set; }

    }

}
