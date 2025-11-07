// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyPersonasOsStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123906BE-752B-51E3-A8FF-52F53B659CE6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Processing result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeVerifyPersonasOsStatisticsResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVerifyPersonasOsStatisticsResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Total number of authenticated devices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("AllDeviceCnt")]
            [Validation(Required=false)]
            public long? AllDeviceCnt { get; set; }

            /// <summary>
            /// <para>Number of authenticated Android devices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("DeviceAndroidCnt")]
            [Validation(Required=false)]
            public long? DeviceAndroidCnt { get; set; }

            /// <summary>
            /// <para>Proportion of Android devices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>58.33</para>
            /// </summary>
            [NameInMap("DeviceAndroidRate")]
            [Validation(Required=false)]
            public string DeviceAndroidRate { get; set; }

            /// <summary>
            /// <para>Number of authenticated iOS devices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DeviceIosCnt")]
            [Validation(Required=false)]
            public long? DeviceIosCnt { get; set; }

            /// <summary>
            /// <para>Proportion of iOS devices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>41.67</para>
            /// </summary>
            [NameInMap("DeviceIosRate")]
            [Validation(Required=false)]
            public string DeviceIosRate { get; set; }

        }

    }

}
