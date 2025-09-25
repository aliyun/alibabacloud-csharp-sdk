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

        /// <summary>
        /// <para>Array of device information.</para>
        /// </summary>
        [NameInMap("DeviceInfoList")]
        [Validation(Required=false)]
        public DescribeDeviceInfoResponseBodyDeviceInfoList DeviceInfoList { get; set; }
        public class DescribeDeviceInfoResponseBodyDeviceInfoList : TeaModel {
            [NameInMap("DeviceInfo")]
            [Validation(Required=false)]
            public List<DescribeDeviceInfoResponseBodyDeviceInfoListDeviceInfo> DeviceInfo { get; set; }
            public class DescribeDeviceInfoResponseBodyDeviceInfoListDeviceInfo : TeaModel {
                /// <summary>
                /// <para>Authorization start date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20180101</para>
                /// </summary>
                [NameInMap("BeginDay")]
                [Validation(Required=false)]
                public string BeginDay { get; set; }

                /// <summary>
                /// <para>Corresponds to the BizType in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FACE_TEST</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>Corresponds to the DeviceId in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wd.6ziUffspAeW5FVYbaqmexR-1qwNjM</para>
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <para>Authorization expiration date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20180101</para>
                /// </summary>
                [NameInMap("ExpiredDay")]
                [Validation(Required=false)]
                public string ExpiredDay { get; set; }

                /// <summary>
                /// <para>Corresponds to the UserDeviceId in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3iJ1AY$oHcu7mC69</para>
                /// </summary>
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
