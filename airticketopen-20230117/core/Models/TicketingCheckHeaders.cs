// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TicketingCheckHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// access_token
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("x-acs-airticket-access-token")]
        [Validation(Required=false)]
        public string XAcsAirticketAccessToken { get; set; }

        [NameInMap("x-acs-airticket-language")]
        [Validation(Required=false)]
        public string XAcsAirticketLanguage { get; set; }

    }

}
