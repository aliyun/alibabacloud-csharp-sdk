// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMeasureDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001001</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The user is not in tenant.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The measurement results.</para>
        /// </summary>
        [NameInMap("MeasureDatas")]
        [Validation(Required=false)]
        public List<ListMeasureDataResponseBodyMeasureDatas> MeasureDatas { get; set; }
        public class ListMeasureDataResponseBodyMeasureDatas : TeaModel {
            /// <summary>
            /// <para>The measurement component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Count</para>
            /// </summary>
            [NameInMap("ComponentCode")]
            [Validation(Required=false)]
            public string ComponentCode { get; set; }

            /// <summary>
            /// <para>The item that is measured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DideAlarmPhone</para>
            /// </summary>
            [NameInMap("DomainCode")]
            [Validation(Required=false)]
            public string DomainCode { get; set; }

            /// <summary>
            /// <para>The end timestamp of the measurement period, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717430400000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The start timestamp of the measurement period, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717344000000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The total quantity used within the measurement period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public long? Usage { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
