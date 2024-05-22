// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class UpdateEslDeviceLightRequest : TeaModel {
        [NameInMap("EslBarCode")]
        [Validation(Required=false)]
        public string EslBarCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        [NameInMap("ItemBarCode")]
        [Validation(Required=false)]
        public string ItemBarCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LedColor")]
        [Validation(Required=false)]
        public string LedColor { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LightUpTime")]
        [Validation(Required=false)]
        public int? LightUpTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

    }

}
