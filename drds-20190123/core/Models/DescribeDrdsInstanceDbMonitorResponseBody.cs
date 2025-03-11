// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceDbMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of monitoring data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDrdsInstanceDbMonitorResponseBodyData> Data { get; set; }
        public class DescribeDrdsInstanceDbMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qps</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The unit of the monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qps</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <para>The details about the value of monitoring data.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstanceDbMonitorResponseBodyDataValues> Values { get; set; }
            public class DescribeDrdsInstanceDbMonitorResponseBodyDataValues : TeaModel {
                /// <summary>
                /// <para>The time point when the value of monitoring data was obtained. The value is in the UNIX timestamp format. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1603162805000</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public long? Date { get; set; }

                /// <summary>
                /// <para>The data value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F7F8080-9132-4279-85D0-B7E5C4******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
