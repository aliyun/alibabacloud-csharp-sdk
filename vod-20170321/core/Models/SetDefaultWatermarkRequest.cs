// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetDefaultWatermarkRequest : TeaModel {
        /// <summary>
        /// The ID of the watermark template. You can specify only one watermark template ID. You can obtain the ID by using one of the following methods:
        /// 
        /// *   Obtain the watermark template ID from the response to the [AddWatermark](~~AddWatermark~~) operation that you call to create a watermark template.
        /// *   Obtain the watermark template ID from the response to the [ListWatermark](~~ListWatermark~~) operation that you call to query all watermark templates within your account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WatermarkId")]
        [Validation(Required=false)]
        public string WatermarkId { get; set; }

    }

}
