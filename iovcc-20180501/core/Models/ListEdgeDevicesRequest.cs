// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListEdgeDevicesRequest : TeaModel {
        /// <summary>
        /// 项目ID
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 查询开始页
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("HostDeviceId")]
        [Validation(Required=false)]
        public string HostDeviceId { get; set; }

        [NameInMap("EdgeDeviceType")]
        [Validation(Required=false)]
        public long? EdgeDeviceType { get; set; }

        [NameInMap("EdgeDeviceName")]
        [Validation(Required=false)]
        public string EdgeDeviceName { get; set; }

    }

}
