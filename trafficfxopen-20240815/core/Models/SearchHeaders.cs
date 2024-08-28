// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.TrafficFxOpen20240815.Models
{
    public class SearchHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// token
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("xAcsAirticketAccessToken")]
        [Validation(Required=false)]
        public string XAcsAirticketAccessToken { get; set; }

        [NameInMap("xAcsAirticketLanguage")]
        [Validation(Required=false)]
        public string XAcsAirticketLanguage { get; set; }

    }

}
