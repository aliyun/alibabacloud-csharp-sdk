// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohUserInfoRequest : TeaModel {
        /// <summary>
        /// The end time for the query. Format: YYYY-MM-DD
        /// 
        /// If you do not specify this parameter, the default value is the time when you perform the query.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The language in which you want the values of some response parameters to be returned. These response parameters support multiple languages.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The start time for the query. Format: YYYY-MM-DD
        /// 
        /// You can query the user information of the last 90 days only. `Set the parameter to a value no earlier than 90 days from the current time`.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
