// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliyunape20210908.Models
{
    public class ApeProvinceStationRefRequest : TeaModel {
        /// <summary>
        /// adcode
        /// </summary>
        [NameInMap("Adcode")]
        [Validation(Required=false)]
        public long? Adcode { get; set; }

        /// <summary>
        /// appName
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// city
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// cnty
        /// </summary>
        [NameInMap("Cnty")]
        [Validation(Required=false)]
        public string Cnty { get; set; }

        /// <summary>
        /// country
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// offset
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// provinceCode
        /// </summary>
        [NameInMap("ProvinceCode")]
        [Validation(Required=false)]
        public long? ProvinceCode { get; set; }

        /// <summary>
        /// provinceName
        /// </summary>
        [NameInMap("ProvinceName")]
        [Validation(Required=false)]
        public string ProvinceName { get; set; }

        /// <summary>
        /// stationName
        /// </summary>
        [NameInMap("StationName")]
        [Validation(Required=false)]
        public string StationName { get; set; }

    }

}
