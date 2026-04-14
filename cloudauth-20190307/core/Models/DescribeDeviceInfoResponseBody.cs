// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeDeviceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number being queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DeviceInfoList")]
        [Validation(Required=false)]
        public DescribeDeviceInfoResponseBodyDeviceInfoList DeviceInfoList { get; set; }
        public class DescribeDeviceInfoResponseBodyDeviceInfoList : TeaModel {
            [NameInMap("DeviceInfo")]
            [Validation(Required=false)]
            public List<DescribeDeviceInfoResponseBodyDeviceInfoListDeviceInfo> DeviceInfo { get; set; }
            public class DescribeDeviceInfoResponseBodyDeviceInfoListDeviceInfo : TeaModel {
                [NameInMap("BeginDay")]
                [Validation(Required=false)]
                public string BeginDay { get; set; }

                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                [NameInMap("ExpiredDay")]
                [Validation(Required=false)]
                public string ExpiredDay { get; set; }

                [NameInMap("UserDeviceId")]
                [Validation(Required=false)]
                public string UserDeviceId { get; set; }

            }

        }

        /// <summary>
        /// <para>Number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
