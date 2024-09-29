// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticTaskMonitorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// <list type="bullet">
        /// <item><description>1001: The request was successful.</description></item>
        /// <item><description>1002: The request failed.</description></item>
        /// <item><description>1003: Parameter errors occurred.</description></item>
        /// <item><description>1004: Authentication failed.</description></item>
        /// <item><description>1006: The task does not exist.</description></item>
        /// <item><description>1099: Internal errors occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the monitoring point.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSyntheticTaskMonitorsResponseBodyData> Data { get; set; }
        public class GetSyntheticTaskMonitorsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task status.</para>
            /// <list type="bullet">
            /// <item><description>0: active</description></item>
            /// <item><description>1: busy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Busy")]
            [Validation(Required=false)]
            public long? Busy { get; set; }

            /// <summary>
            /// <para>The name of the city to which the monitoring point belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The ID of the city to which the monitoring point belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1100101</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public long? CityCode { get; set; }

            /// <summary>
            /// <para>The client type:</para>
            /// <list type="bullet">
            /// <item><description>1: IDC</description></item>
            /// <item><description>2: Last mile</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public long? ClientType { get; set; }

            /// <summary>
            /// <para>The region to which the monitoring point belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("District")]
            [Validation(Required=false)]
            public string District { get; set; }

            /// <summary>
            /// <para>The ID of the carrier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("NetServiceId")]
            [Validation(Required=false)]
            public long? NetServiceId { get; set; }

            /// <summary>
            /// <para>The name of the carrier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX</para>
            /// </summary>
            [NameInMap("NetServiceName")]
            [Validation(Required=false)]
            public string NetServiceName { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned when the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21E85B16-75A6-429A-9F65-8AAC9A54****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
