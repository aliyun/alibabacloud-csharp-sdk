// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainDetailDataByLayerRequest : TeaModel {
        /// <summary>
        /// The name of the Internet service provider (ISP) for your Alibaba Cloud CDN service. You can call the [DescribeCdnRegionAndIsp](https://help.aliyun.com/document_detail/91077.html) operation to query ISP names.
        /// 
        /// If you do not specify an ISP, data of all ISPs is queried.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The protocol by which you want to query data. Valid values: **http**, **https**, **quic**, and **all**.
        /// 
        /// The default value is **all**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// >  The end time must be later than the start time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// The amount of network traffic. Unit: bytes.
        /// </summary>
        [NameInMap("Layer")]
        [Validation(Required=false)]
        public string Layer { get; set; }

        /// <summary>
        /// The detailed data of the accelerated domain names.
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        /// <summary>
        /// The name of the region. You can call the [DescribeCdnRegionAndIsp](https://help.aliyun.com/document_detail/91077.html) operation to query regions.
        /// 
        /// If you do not specify a region, data in all regions is queried.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
