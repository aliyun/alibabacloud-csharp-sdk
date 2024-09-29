// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AddPrometheusInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The struct returned. { &quot;RequestId&quot;: the request ID, &quot;Data&quot;: &quot;{ &quot;clusterType&quot;: the cluster type, &quot;remoteWriteUrl&quot;: the public URL for remote write, &quot;internetGrafanaUrl&quot;: the internal URL for Grafana, &quot;authToken&quot;: indicates whether authentication is enabled, &quot;internetPushGatewayUrl&quot;: the internal URL for Pushgateway, &quot;clusterId&quot;: the cluster ID, &quot;internetRemoteReadUrl&quot;: the internal URL for remote read, &quot;remoteReadUrl&quot;: the public URL for remote read, &quot;grafanaUrl&quot;: the public URL for Grafana, &quot;pushGatewayUrl&quot;: the public URL for Pushgateway, &quot;internetRemoteWriteUrl&quot;: the internal URL for remote write}&quot; }</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;RequestId&quot;: &quot;1293091C-54AD-50FE-B787-E314B94B35AB&quot;,
        ///   &quot;Data&quot;: &quot;{
        ///   &quot;clusterType&quot;:&quot;remote-write-prometheus&quot;,
        ///   &quot;remoteWriteUrl&quot;:&quot;<a href="http://cn-hu/api/v3/write">http://cn-hu/api/v3/write</a>&quot;,
        ///   &quot;internetGrafanaUrl&quot;:&quot;<a href="https://cn-hanga/cn-hangzhou">https://cn-hanga/cn-hangzhou</a>&quot;,
        ///   &quot;authToken&quot;:false,
        ///   &quot;internetPushGatewayUrl&quot;:&quot;<a href="https://cangzhou/api/v2">https://cangzhou/api/v2</a>&quot;,
        ///   &quot;clusterId&quot;:&quot;vrju1lj3sa|123456&quot;,
        ///   &quot;internetRemoteReadUrl&quot;:&quot;<a href="https://cn-hangzh67cn-hangzhou/api/v1/read">https://cn-hangzh67cn-hangzhou/api/v1/read</a>&quot;,
        ///   &quot;remoteReadUrl&quot;:&quot;<a href="http://cn-hanou/api/v1/read">http://cn-hanou/api/v1/read</a>&quot;,
        ///   &quot;grafanaUrl&quot;:&quot;<a href="http://cn-angzhou">http://cn-angzhou</a>&quot;,
        ///   &quot;pushGatewayUrl&quot;:&quot;htt1lj3sa/cn-hangzhou/api/v2&quot;,
        ///   &quot;internetRemoteWriteUrl&quot;:&quot;httpsngzhou/api/v3/write&quot;}&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9319A57D-2D9E-472A-B69B-CF3CD16D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
