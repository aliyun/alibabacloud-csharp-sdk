// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListVpcEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC47D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the endpoints.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListVpcEndpointsResponseBodyResult> Result { get; set; }
        public class ListVpcEndpointsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The status of the endpoint connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending</description></item>
            /// <item><description>Connecting</description></item>
            /// <item><description>Connected</description></item>
            /// <item><description>Disconnecting</description></item>
            /// <item><description>Disconnected</description></item>
            /// <item><description>Deleting</description></item>
            /// <item><description>ServiceDeleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disconnected</para>
            /// </summary>
            [NameInMap("connectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <para>The time when the endpoint was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-22T01:19:24Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The business status of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal</description></item>
            /// <item><description>FinancialLocked</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("endpointBusinessStatus")]
            [Validation(Required=false)]
            public string EndpointBusinessStatus { get; set; }

            /// <summary>
            /// <para>The domain name of the endpoint. The domain name is used for connection configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp18s6wy9420wdi4****.epsrv-bp1bz3efowa4kc0****.cn-hangzhou.privatelink.aliyuncs.com</para>
            /// </summary>
            [NameInMap("endpointDomain")]
            [Validation(Required=false)]
            public string EndpointDomain { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp1tah7zbrwmkjef****</para>
            /// </summary>
            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("endpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// <para>The status of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating</description></item>
            /// <item><description>Active</description></item>
            /// <item><description>Pending</description></item>
            /// <item><description>Deleting</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("endpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint service with which the endpoint is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-bp1w0p3jdirbfmt6****</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint service with which the endpoint is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aliyuncs.privatelink.cn-hangzhou.epsrv-bp1w0p3jdirbfmt6****</para>
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

    }

}
