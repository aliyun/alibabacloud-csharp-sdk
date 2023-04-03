// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainLogsRequest : TeaModel {
        /// <summary>
        /// The ID of the domain name group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The keyword for the query in "%KeyWord%" mode. The keyword is not case-sensitive.
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// The language in which you want the values of some response parameters to be returned. These response parameters support multiple languages.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The page number to return. The page number starts from **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return per page. Maximum value: **100**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The start time for the query. Format: **YYYY-MM-DD**
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The type of object of which you want to query operation logs. Valid values:
        /// 
        /// *   domain: domain name
        /// *   slavedns: secondary Domain Name System (DNS)
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The end time for the query. Format: **YYYY-MM-DD**
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

    }

}
