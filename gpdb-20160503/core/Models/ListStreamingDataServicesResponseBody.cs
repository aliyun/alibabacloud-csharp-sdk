// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListStreamingDataServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns real-time data service items</para>
        /// </summary>
        [NameInMap("ServiceItems")]
        [Validation(Required=false)]
        public List<ListStreamingDataServicesResponseBodyServiceItems> ServiceItems { get; set; }
        public class ListStreamingDataServicesResponseBodyServiceItems : TeaModel {
            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Last modified time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-08T17:00:00Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>Service description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-adbpgss</para>
            /// </summary>
            [NameInMap("ServiceDescription")]
            [Validation(Required=false)]
            public string ServiceDescription { get; set; }

            /// <summary>
            /// <para>Service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Service IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1</para>
            /// </summary>
            [NameInMap("ServiceIp")]
            [Validation(Required=false)]
            public string ServiceIp { get; set; }

            /// <summary>
            /// <para>Whether it is a managed service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>Service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-adbpgss</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>Service owner ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ServiceOwnerId")]
            [Validation(Required=false)]
            public string ServiceOwnerId { get; set; }

            /// <summary>
            /// <para>Service port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5432</para>
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public string ServicePort { get; set; }

            /// <summary>
            /// <para>Service specification (in CU).</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ServiceSpec")]
            [Validation(Required=false)]
            public string ServiceSpec { get; set; }

            /// <summary>
            /// <para>Service type, with the following value:</para>
            /// <list type="bullet">
            /// <item><description><b>adbpgss</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>adbpgss</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>Service status, with the following values:</para>
            /// <list type="bullet">
            /// <item><description><para>Init: Initializing</para>
            /// </description></item>
            /// <item><description><para>Running: In operation</para>
            /// </description></item>
            /// <item><description><para>Exception: Abnormal</para>
            /// </description></item>
            /// <item><description><para>Paused: Suspended</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Total record count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
