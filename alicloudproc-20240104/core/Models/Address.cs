/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alicloudproc20240104.Models
{
    public class Address : TeaModel {
        [NameInMap("cityCode")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        [NameInMap("detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("districtCode")]
        [Validation(Required=false)]
        public string DistrictCode { get; set; }

        [NameInMap("provinceCode")]
        [Validation(Required=false)]
        public string ProvinceCode { get; set; }

    }

}
