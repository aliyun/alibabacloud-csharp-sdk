// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribeAlarmsRequest : TeaModel {
        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public string AlarmId { get; set; }

        [NameInMap("AlarmStatus")]
        [Validation(Required=false)]
        public string AlarmStatus { get; set; }

        [NameInMap("AlarmType")]
        [Validation(Required=false)]
        public string AlarmType { get; set; }

        [NameInMap("ErrorType")]
        [Validation(Required=false)]
        public string ErrorType { get; set; }

        [NameInMap("FromAlarmTime")]
        [Validation(Required=false)]
        public string FromAlarmTime { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("ToAlarmTime")]
        [Validation(Required=false)]
        public string ToAlarmTime { get; set; }

    }

}
