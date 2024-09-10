// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateInstantSiteMonitorRequest : TeaModel {
        /// <summary>
        /// The URL or IP address that you want to test.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The detection points. If you leave this parameter empty, the system randomly selects three detection points.
        /// 
        /// The value is a `JSON array`. Example: {"city":"546","isp":"465"},{"city":"572","isp":"465"},{"city":"738","isp":"465"}. The values of the city field indicate Beijing, Hangzhou, and Qingdao.
        /// 
        /// For information about how to obtain detection points, see [DescribeSiteMonitorISPCityList](https://help.aliyun.com/document_detail/115045.html).
        /// 
        /// > You must specify one of the `IspCities` and `RandomIspCity` parameters.
        /// </summary>
        [NameInMap("IspCities")]
        [Validation(Required=false)]
        public string IspCities { get; set; }

        /// <summary>
        /// The extended options of the protocol that is used by the instant test task. The options vary based on the protocol.
        /// </summary>
        [NameInMap("OptionsJson")]
        [Validation(Required=false)]
        public string OptionsJson { get; set; }

        /// <summary>
        /// The number of detection points.
        /// 
        /// > 
        /// 
        /// *   You must specify one of the `IspCities` and `RandomIspCity` parameters. If you specify the `RandomIspCity` parameter, the `IspCities` parameter automatically becomes invalid.
        /// </summary>
        [NameInMap("RandomIspCity")]
        [Validation(Required=false)]
        public int? RandomIspCity { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the instant test task.
        /// 
        /// The name must be 4 to 100 characters in length, and can contain letters, digits, and underscores (_).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the instant test task. Valid values: HTTP, PING, TCP, UDP, and DNS.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
