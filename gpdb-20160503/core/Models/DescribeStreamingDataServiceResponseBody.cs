// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeStreamingDataServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the service was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the service was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-08T17:00:00Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The description of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-adbpgss</para>
        /// </summary>
        [NameInMap("ServiceDescription")]
        [Validation(Required=false)]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The IP address of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1</para>
        /// </summary>
        [NameInMap("ServiceIp")]
        [Validation(Required=false)]
        public string ServiceIp { get; set; }

        /// <summary>
        /// <para>The service is managed by other aliyun product or not.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The name of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-adbpgss</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The service account uid of the aliyun product</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ServiceOwnerId")]
        [Validation(Required=false)]
        public string ServiceOwnerId { get; set; }

        /// <summary>
        /// <para>The port number of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5432</para>
        /// </summary>
        [NameInMap("ServicePort")]
        [Validation(Required=false)]
        public int? ServicePort { get; set; }

        /// <summary>
        /// <para>The specifications of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ServiceSpec")]
        [Validation(Required=false)]
        public string ServiceSpec { get; set; }

        /// <summary>
        /// <para>The status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Init</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Exception</description></item>
        /// <item><description>Paused</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
