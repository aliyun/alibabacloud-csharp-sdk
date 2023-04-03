// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainRecordsRequest : TeaModel {
        /// <summary>
        /// The order in which the returned DNS records are sorted. Valid values: DESC and ASC. Default value: DESC.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The domain name for which you want to query DNS records.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The ID of the domain name group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The keyword based on which the system queries DNS records.
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// The language of the domain name.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The line based on which the system queries DNS records. Default value: **default**.
        /// 
        /// For more information, see the following topic:
        /// 
        /// [DNS lines](https://www.alibabacloud.com/help/zh/doc-detail/29807.htm)
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// The method that is used to sort the returned DNS records. By default, the DNS records are sorted in reverse chronological order based on the time when they were added.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **500**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The resource record (RR) keyword based on which the system queries DNS records. The system queries DNS records based on the value of this parameter in fuzzy match mode. The value is not case-sensitive.
        /// </summary>
        [NameInMap("RRKeyWord")]
        [Validation(Required=false)]
        public string RRKeyWord { get; set; }

        /// <summary>
        /// The search mode. Valid values: **LIKE, EXACT, and ADVANCED**.
        /// 
        /// *   If you set this parameter to LIKE or EXACT, specify the KeyWord parameter.In this case, the RRKeyWord, TypeKeyWord, ValueKeyWord, Type, Line, and Status parameters are ignored.
        /// 
        /// *   If you set this parameter to ADVANCED, specify the RRKeyWord, TypeKeyWord, ValueKeyWord, Type, Line, and Status parameters.
        /// 
        /// *   If you do not specify this parameter, the system determines the search mode based on the following rules:
        /// 
        ///     *   If the KeyWord parameter is specified, the system uses the LIKE mode.
        ///     *   If the KeyWord parameter is not specified, the system queries DNS records based on values of the RRKeyWord and ValueKeyWord parameters in fuzzy match mode, and based on the values of the TypeKeyWord, Type, Line, and Status parameters in exact match mode.
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// The status of the DNS records to query. Valid values: **Enable and Disable**.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The type of the DNS records to query. For more information, see the following topic:
        /// 
        /// [DNS record types](https://www.alibabacloud.com/help/zh/doc-detail/29805.htm)
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The type keyword based on which the system queries DNS records. The system queries DNS records based on the value of this parameter in exact match mode. The value is not case-sensitive.
        /// </summary>
        [NameInMap("TypeKeyWord")]
        [Validation(Required=false)]
        public string TypeKeyWord { get; set; }

        /// <summary>
        /// The record value keyword based on which the system queries DNS records. The system queries DNS records based on the value of this parameter in fuzzy match mode. The value is not case-sensitive.
        /// </summary>
        [NameInMap("ValueKeyWord")]
        [Validation(Required=false)]
        public string ValueKeyWord { get; set; }

    }

}
