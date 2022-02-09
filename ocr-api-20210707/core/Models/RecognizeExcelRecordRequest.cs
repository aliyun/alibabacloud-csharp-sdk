// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeExcelRecordRequest : TeaModel {
        /// <summary>
        /// 页码
        /// </summary>
        [NameInMap("CurrPage")]
        [Validation(Required=false)]
        public long? CurrPage { get; set; }

        /// <summary>
        /// 每页数据
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
