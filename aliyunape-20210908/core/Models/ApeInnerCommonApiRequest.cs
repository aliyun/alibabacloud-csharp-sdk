/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliyunape20210908.Models
{
    public class ApeInnerCommonApiRequest : TeaModel {
        /// <summary>
        /// appName
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// channel
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// endTime
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// lat
        /// </summary>
        [NameInMap("Lat")]
        [Validation(Required=false)]
        public string Lat { get; set; }

        /// <summary>
        /// lon
        /// </summary>
        [NameInMap("Lon")]
        [Validation(Required=false)]
        public string Lon { get; set; }

        /// <summary>
        /// pageNum
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// spCode
        /// </summary>
        [NameInMap("SpCode")]
        [Validation(Required=false)]
        public string SpCode { get; set; }

        /// <summary>
        /// startTime
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// station
        /// </summary>
        [NameInMap("Station")]
        [Validation(Required=false)]
        public string Station { get; set; }

    }

}
