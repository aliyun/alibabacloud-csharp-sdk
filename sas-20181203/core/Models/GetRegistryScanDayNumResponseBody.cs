// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetRegistryScanDayNumResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configuration of the scan period.</para>
        /// </summary>
        [NameInMap("ScanDayNumConfig")]
        [Validation(Required=false)]
        public GetRegistryScanDayNumResponseBodyScanDayNumConfig ScanDayNumConfig { get; set; }
        public class GetRegistryScanDayNumResponseBodyScanDayNumConfig : TeaModel {
            /// <summary>
            /// <para>The selectable day options.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,3,7,15,30,90,180,365</para>
            /// </summary>
            [NameInMap("DayNumList")]
            [Validation(Required=false)]
            public string DayNumList { get; set; }

            /// <summary>
            /// <para>The scan period. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("ScanDayNum")]
            [Validation(Required=false)]
            public int? ScanDayNum { get; set; }

        }

    }

}
