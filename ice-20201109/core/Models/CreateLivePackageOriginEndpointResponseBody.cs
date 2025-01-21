// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLivePackageOriginEndpointResponseBody : TeaModel {
        [NameInMap("LivePackageOriginEndpoint")]
        [Validation(Required=false)]
        public CreateLivePackageOriginEndpointResponseBodyLivePackageOriginEndpoint LivePackageOriginEndpoint { get; set; }
        public class CreateLivePackageOriginEndpointResponseBodyLivePackageOriginEndpoint : TeaModel {
            /// <summary>
            /// <para>回源授权码，与IpWhitelist必选其一</para>
            /// 
            /// <b>Example:</b>
            /// <para>Abcded123</para>
            /// </summary>
            [NameInMap("AuthorizationCode")]
            [Validation(Required=false)]
            public string AuthorizationCode { get; set; }

            /// <summary>
            /// <para>频道名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>channel-1</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>端点描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>端点名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>endpoint-1</para>
            /// </summary>
            [NameInMap("EndpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// <para>源站端点回源播放地址</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.packagepull-abcxxx.ap-southeast-1.aliyuncsiceintl.com/v1/group01/1/ch01/manifest">https://xxx.packagepull-abcxxx.ap-southeast-1.aliyuncsiceintl.com/v1/group01/1/ch01/manifest</a></para>
            /// </summary>
            [NameInMap("EndpointUrl")]
            [Validation(Required=false)]
            public string EndpointUrl { get; set; }

            /// <summary>
            /// <para>频道组名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>channel-group-1</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>IP黑名单，支持无类别域间路由（CIDR），逗号分隔</para>
            /// 
            /// <b>Example:</b>
            /// <para>103.21.222.1/32,192.168.100.0/24</para>
            /// </summary>
            [NameInMap("IpBlacklist")]
            [Validation(Required=false)]
            public string IpBlacklist { get; set; }

            /// <summary>
            /// <para>IP白名单，支持无类别域间路由（CIDR），逗号分隔，与AuthorizationCode必选其一</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.0/24,10.0.0.1/24</para>
            /// </summary>
            [NameInMap("IpWhitelist")]
            [Validation(Required=false)]
            public string IpWhitelist { get; set; }

            /// <summary>
            /// <para>最后修改时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>播放列表名</para>
            /// 
            /// <b>Example:</b>
            /// <para>manifest</para>
            /// </summary>
            [NameInMap("ManifestName")]
            [Validation(Required=false)]
            public string ManifestName { get; set; }

            /// <summary>
            /// <para>端点分发协议，暂只支持HLS</para>
            /// 
            /// <b>Example:</b>
            /// <para>HLS</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>时移天数，最大30天，0表示不支持时移</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TimeshiftVision")]
            [Validation(Required=false)]
            public int? TimeshiftVision { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
