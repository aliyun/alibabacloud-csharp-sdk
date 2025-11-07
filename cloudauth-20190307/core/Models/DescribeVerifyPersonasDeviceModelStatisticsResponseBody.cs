// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyPersonasDeviceModelStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>026828A3-CC7E-5D85-85B6-08DF245C5A53</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Query result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeVerifyPersonasDeviceModelStatisticsResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVerifyPersonasDeviceModelStatisticsResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Total number of devices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31</para>
            /// </summary>
            [NameInMap("AllDeviceCnt")]
            [Validation(Required=false)]
            public long? AllDeviceCnt { get; set; }

            /// <summary>
            /// <para>List of data for different phone models.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeVerifyPersonasDeviceModelStatisticsResponseBodyResultObjectItems> Items { get; set; }
            public class DescribeVerifyPersonasDeviceModelStatisticsResponseBodyResultObjectItems : TeaModel {
                /// <summary>
                /// <para>Number of devices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("DeviceCnt")]
                [Validation(Required=false)]
                public long? DeviceCnt { get; set; }

                /// <summary>
                /// <para>Device model</para>
                /// 
                /// <b>Example:</b>
                /// <para>iPhone15,2</para>
                /// </summary>
                [NameInMap("DeviceModel")]
                [Validation(Required=false)]
                public string DeviceModel { get; set; }

                /// <summary>
                /// <para>The ratio of this device model to the total number of devices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16.13</para>
                /// </summary>
                [NameInMap("DeviceRate")]
                [Validation(Required=false)]
                public string DeviceRate { get; set; }

            }

        }

    }

}
