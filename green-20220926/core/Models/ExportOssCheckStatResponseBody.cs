// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ExportOssCheckStatResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oss-cip-shanghai.oss-cn-shanghai.aliyuncs.com/console_data/production/scanResult/osscheck/ossCheckStat_aliUf5B3lJfOkLpqozLIn94Uy-1XxKyX.xlsx">https://oss-cip-shanghai.oss-cn-shanghai.aliyuncs.com/console_data/production/scanResult/osscheck/ossCheckStat_aliUf5B3lJfOkLpqozLIn94Uy-1XxKyX.xlsx</a></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
