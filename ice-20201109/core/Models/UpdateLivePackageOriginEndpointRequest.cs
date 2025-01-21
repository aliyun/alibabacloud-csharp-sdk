// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLivePackageOriginEndpointRequest : TeaModel {
        /// <summary>
        /// <para>回源授权码，与IpWhitelist必选其一</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abc123Def456</para>
        /// </summary>
        [NameInMap("AuthorizationCode")]
        [Validation(Required=false)]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// <para>频道名称。
        /// 1 ~ 200个字符。
        /// 正则匹配输入：[A-Za-z0-9_-]+</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel-1</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>端点描述，最大1000个字符</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>端点名称，要求在单个频道中唯一。
        /// 1 ~ 200个字符。
        /// 正则匹配输入：[A-Za-z0-9_-]+</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>endpoint-1</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>频道组名称。
        /// 1 ~ 200个字符。
        /// 正则匹配输入：[A-Za-z0-9_-]+</para>
        /// <para>This parameter is required.</para>
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
        /// <para>103.0.0.0/8</para>
        /// </summary>
        [NameInMap("IpBlacklist")]
        [Validation(Required=false)]
        public string IpBlacklist { get; set; }

        /// <summary>
        /// <para>IP白名单，支持无类别域间路由（CIDR），逗号分隔，与AuthorizationCode必选其一</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.0/24,10.0.0.1</para>
        /// </summary>
        [NameInMap("IpWhitelist")]
        [Validation(Required=false)]
        public string IpWhitelist { get; set; }

        /// <summary>
        /// <para>播放列表名，缺省为manifest。
        /// 1 ~ 100个字符。
        /// 正则匹配输入：[A-Za-z0-9_]+</para>
        /// 
        /// <b>Example:</b>
        /// <para>manifest</para>
        /// </summary>
        [NameInMap("ManifestName")]
        [Validation(Required=false)]
        public string ManifestName { get; set; }

        /// <summary>
        /// <para>端点分发协议，暂只支持HLS</para>
        /// <para>This parameter is required.</para>
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
        /// <para>5</para>
        /// </summary>
        [NameInMap("TimeshiftVision")]
        [Validation(Required=false)]
        public int? TimeshiftVision { get; set; }

    }

}
