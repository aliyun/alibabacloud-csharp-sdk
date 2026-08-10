// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLivePackageOriginEndpointShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code. You must specify at least one of AuthorizationCode and IpWhitelist. Maximum length: 200 characters. Format: [A-Za-z0-9-_.]+</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abc123Def456</para>
        /// </summary>
        [NameInMap("AuthorizationCode")]
        [Validation(Required=false)]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// <para>The name of an existing channel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel-1</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>The description of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an origin endpoint.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the origin endpoint. The name can contain uppercase and lowercase letters, digits, hyphens (-), and underscores (<em>). The name must be 1 to 200 characters in length. Format: [A-Za-z0-9</em>-]+</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>endpoint-1</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The name of an existing channel group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel-group-1</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The IP blacklist. Subnet masks are supported. Separate multiple IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>103.0.0.0/8</para>
        /// </summary>
        [NameInMap("IpBlacklist")]
        [Validation(Required=false)]
        public string IpBlacklist { get; set; }

        /// <summary>
        /// <para>The IP whitelist. Subnet masks are supported. The value 0.0.0.0/0 is not allowed. Separate multiple IP addresses with commas (,). You must specify at least one of IpWhitelist and AuthorizationCode. Maximum length: 1000 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.0/24,10.0.0.1</para>
        /// </summary>
        [NameInMap("IpWhitelist")]
        [Validation(Required=false)]
        public string IpWhitelist { get; set; }

        /// <summary>
        /// <para>The live packaging configuration.</para>
        /// </summary>
        [NameInMap("LivePackagingConfig")]
        [Validation(Required=false)]
        public string LivePackagingConfigShrink { get; set; }

        /// <summary>
        /// <para>The playlist name. Default value: manifest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manifest</para>
        /// </summary>
        [NameInMap("ManifestName")]
        [Validation(Required=false)]
        public string ManifestName { get; set; }

        /// <summary>
        /// <para>The protocol. Currently, only HLS is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HLS</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The number of time-shifting days. Maximum value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TimeshiftVision")]
        [Validation(Required=false)]
        public int? TimeshiftVision { get; set; }

    }

}
