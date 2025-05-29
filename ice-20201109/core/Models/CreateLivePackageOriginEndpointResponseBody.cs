// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLivePackageOriginEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the origin endpoint.</para>
        /// </summary>
        [NameInMap("LivePackageOriginEndpoint")]
        [Validation(Required=false)]
        public CreateLivePackageOriginEndpointResponseBodyLivePackageOriginEndpoint LivePackageOriginEndpoint { get; set; }
        public class CreateLivePackageOriginEndpointResponseBodyLivePackageOriginEndpoint : TeaModel {
            /// <summary>
            /// <para>The authorization code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Abcded123</para>
            /// </summary>
            [NameInMap("AuthorizationCode")]
            [Validation(Required=false)]
            public string AuthorizationCode { get; set; }

            /// <summary>
            /// <para>The channel name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>channel-1</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <para>The time when the endpoint was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The endpoint description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The endpoint name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>endpoint-1</para>
            /// </summary>
            [NameInMap("EndpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// <para>The endpoint URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.packagepull-abcxxx.ap-southeast-1.aliyuncsiceintl.com/v1/group01/1/ch01/manifest">https://xxx.packagepull-abcxxx.ap-southeast-1.aliyuncsiceintl.com/v1/group01/1/ch01/manifest</a></para>
            /// </summary>
            [NameInMap("EndpointUrl")]
            [Validation(Required=false)]
            public string EndpointUrl { get; set; }

            /// <summary>
            /// <para>The channel group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>channel-group-1</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The IP address blacklist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>103.21.222.1/32,192.168.100.0/24</para>
            /// </summary>
            [NameInMap("IpBlacklist")]
            [Validation(Required=false)]
            public string IpBlacklist { get; set; }

            /// <summary>
            /// <para>The IP address whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.0/24,10.0.0.1/24</para>
            /// </summary>
            [NameInMap("IpWhitelist")]
            [Validation(Required=false)]
            public string IpWhitelist { get; set; }

            /// <summary>
            /// <para>The time when the endpoint was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            [NameInMap("LivePackagingConfig")]
            [Validation(Required=false)]
            public LivePackagingConfig LivePackagingConfig { get; set; }

            /// <summary>
            /// <para>The playlist name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>manifest</para>
            /// </summary>
            [NameInMap("ManifestName")]
            [Validation(Required=false)]
            public string ManifestName { get; set; }

            /// <summary>
            /// <para>The protocol. Only HLS is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HLS</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The number of days that time-shifted content is available. Maximum value: 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TimeshiftVision")]
            [Validation(Required=false)]
            public int? TimeshiftVision { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
