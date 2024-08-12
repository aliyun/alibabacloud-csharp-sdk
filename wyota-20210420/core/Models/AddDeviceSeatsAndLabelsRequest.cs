// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class AddDeviceSeatsAndLabelsRequest : TeaModel {
        [NameInMap("IsUnique")]
        [Validation(Required=false)]
        public bool? IsUnique { get; set; }

        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("LabelList")]
        [Validation(Required=false)]
        public List<string> LabelList { get; set; }

        [NameInMap("SeatName")]
        [Validation(Required=false)]
        public string SeatName { get; set; }

        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
