// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class DescribeScreenTitlesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-XXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SasScreenSettingList")]
        [Validation(Required=false)]
        public List<DescribeScreenTitlesResponseBodySasScreenSettingList> SasScreenSettingList { get; set; }
        public class DescribeScreenTitlesResponseBodySasScreenSettingList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3267</para>
            /// </summary>
            [NameInMap("ScreenID")]
            [Validation(Required=false)]
            public long? ScreenID { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>titlexxx</para>
            /// </summary>
            [NameInMap("ScreenTitle")]
            [Validation(Required=false)]
            public string ScreenTitle { get; set; }

        }

    }

}
