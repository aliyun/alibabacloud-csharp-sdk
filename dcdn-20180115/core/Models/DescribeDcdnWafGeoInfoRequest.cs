// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGeoInfoRequest : TeaModel {
        /// <summary>
        /// The language of the information to return. Valid values:
        /// 
        /// *   cn: Chinese
        /// *   en: English
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
