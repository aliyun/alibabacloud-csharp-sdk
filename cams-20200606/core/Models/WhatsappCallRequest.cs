// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class WhatsappCallRequest : TeaModel {
        /// <summary>
        /// <para>The business number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86138***</para>
        /// </summary>
        [NameInMap("BusinessNumber")]
        [Validation(Required=false)]
        public string BusinessNumber { get; set; }

        /// <summary>
        /// <para>The action to perform on the call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connect</para>
        /// </summary>
        [NameInMap("CallAction")]
        [Validation(Required=false)]
        public string CallAction { get; set; }

        /// <summary>
        /// <para>The call ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wamid-xx**</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>The Space ID of the ISV sub-customer, or the instance ID of the direct customer. View the Space ID on the</para>
        /// <para>&lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList">Channel Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-xx**</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The call negotiation information.</para>
        /// </summary>
        [NameInMap("Session")]
        [Validation(Required=false)]
        public WhatsappCallRequestSession Session { get; set; }
        public class WhatsappCallRequestSession : TeaModel {
            /// <summary>
            /// <para>The Session Description Protocol (SDP) payload used for call negotiation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v=0\r\no=- 3978582128 3978582128 IN IP4 0.0.0.0\r\ns=Kurento Media Server\r\nc=IN IP4 0.0.0.0\r\nt=0 0\r\na=group:BUNDLE audio0\r\nm=audio 61903 RTP/SAVPF 96 0 8\r\na=setup:actpass\r\na=extmap:3 <a href="http://www.webrtc.org/experiments/rtp-hdrext/abs-send-time%5C%5Cr%5C%5Cna=rtpmap:96">http://www.webrtc.org/experiments/rtp-hdrext/abs-send-time\\r\\na=rtpmap:96</a> opus/48000/2\r\na=rtcp:9 IN IP4 0.0.0.0\r\na=rtcp-mux\r\na=sendrecv\r\na=mid:audio0\r\na=ssrc:1935711036 cname:user3617531270@host-126a650\r\na=ice-ufrag:/TW8\r\na=ice-pwd:GRKrVHYTLGT69PYlqqWQHO\r\na=fingerprint:sha-256 41:5C:01:6E:C0:1B:21:F1:0D:28:95:2E:4E:42:F6:64:F3:DB:DD:E3:18:54:32:28:3D:2F:9C:80:38:FA:E0:2Ca=candidate:candidate:1 1 UDP 2015363327 47.243.79.43 46008 typ host\r\na=candidate:candidate:1 1 UDP 2015363327 47.243.79.43 46008 typ host\r\na=candidate:candidate:2 1 TCP 1015021823 47.243.79.43 9 typ host tcptype active\r\na=candidate:candidate:3 1 TCP 1010827519 47.243.79.43 32450 typ host tcptype passive\r\na=candidate:candidate:3 1 TCP 1010827519 47.243.79.43 32450 typ host tcptype passive\r\na=candidate:candidate:2 1 TCP 1015021823 47.243.79.43 9 typ host tcptype active\r\na=candidate:candidate:4 1 UDP 2015363583 fe80::216:3eff:fe22:644f 12231 typ host\r\na=candidate:candidate:4 1 UDP 2015363583 fe80::216:3eff:fe22:644f 12231 typ host\r\na=candidate:candidate:5 1 TCP 1015022079 fe80::216:3eff:fe22:644f 9 typ host tcptype active\r\na=candidate:candidate:5 1 TCP 1015022079 fe80::216:3eff:fe22:644f 9 typ host tcptype active\r\na=candidate:candidate:6 1 TCP 1010827775 fe80::216:3eff:fe22:644f 6988 typ host tcptype passive\r\na=candidate:candidate:6 1 TCP 1010827775 fe80::216:3eff:fe22:644f 6988 typ host tcptype passive\r\na=candidate:candidate:1 2 UDP 2015363326 47.243.79.43 40782 typ host\r\na=candidate:candidate:1 2 UDP 2015363326 47.243.79.43 40782 typ host\r\na=candidate:candidate:2 2 TCP 1015021822 47.243.79.43 9 typ host tcptype active\r\na=candidate:candidate:2 2 TCP 1015021822 47.243.79.43 9 typ host tcptype active\r\na=candidate:candidate:3 2 TCP 1010827518 47.243.79.43 64559 typ host tcptype passive\r\na=candidate:candidate:3 2 TCP 1010827518 47.243.79.43 64559 typ host tcptype passive\r\na=candidate:candidate:4 2 UDP 2015363582 fe80::216:3eff:fe22:644f 39166 typ host\r\na=candidate:candidate:5 2 TCP 1015022078 fe80::216:3eff:fe22:644f 9 typ host tcptype active\r\na=candidate:candidate:4 2 UDP 2015363582 fe80::216:3eff:fe22:644f 39166 typ host\r\na=candidate:candidate:5 2 TCP 1015022078 fe80::216:3eff:fe22:644f 9 typ host tcptype active\r\na=candidate:candidate:6 2 TCP 1010827774 fe80::216:3eff:fe22:644f 16286 typ host tcptype passive\r\na=candidate:candidate:6 2 TCP 1010827774 fe80::216:3eff:fe22:644f 16286 typ host tcptype passive\r\na=candidate:candidate:7 1 UDP 1679819007 47.243.79.43 46008 typ srflx raddr 172.22.181.115 rport 46008\r\na=candidate:candidate:7 1 UDP 1679819007 47.243.79.43 46008 typ srflx raddr 172.22.181.115 rport 46008\r\na=candidate:candidate:8 1 TCP 847249663 47.243.79.43 9 typ srflx raddr 172.22.181.115 rport 9 tcptype active\r\na=candidate:candidate:8 1 TCP 847249663 47.243.79.43 9 typ srflx raddr 172.22.181.115 rport 9 tcptype active\r\na=candidate:candidate:9 1 TCP 843055359 47.243.79.43 32450 typ srflx raddr 172.22.181.115 rport 32450 tcptype passive\r\na=candidate:candidate:9 1 TCP 843055359 47.243.79.43 32450 typ srflx raddr 172.22.181.115 rport 32450 tcptype passive\r\na=candidate:candidate:10 1 UDP 505413887 47.243.79.43 61903 typ relay raddr 172.22.181.115 rport 46008\r\na=candidate:candidate:10 1 UDP 505413887 47.243.79.43 61903 typ relay raddr 172.22.181.115 rport 46008\r\na=candidate:candidate:7 2 UDP 1679819006 47.243.79.43 40782 typ srflx raddr 172.22.181.115 rport 40782\r\na=candidate:candidate:7 2 UDP 1679819006 47.243.79.43 40782 typ srflx raddr 172.22.181.115 rport 40782\r\na=candidate:candidate:8 2 TCP 847249662 47.243.79.43 9 typ srflx raddr 172.22.181.115 rport 9 tcptype active\r\na=candidate:candidate:8 2 TCP 847249662 47.243.79.43 9 typ srflx raddr 172.22.181.115 rport 9 tcptype active\r\na=candidate:candidate:9 2 TCP 843055358 47.243.79.43 64559 typ srflx raddr 172.22.181.115 rport 64559 tcptype passive\r\na=candidate:candidate:9 2 TCP 843055358 47.243.79.43 64559 typ srflx raddr 172.22.181.115 rport 64559 tcptype passive\r\na=candidate:candidate:10 2 UDP 505413886 47.243.79.43 63580 typ relay raddr 172.22.181.115 rport 40782\r\na=candidate:candidate:10 2 UDP 505413886 47.243.79.43 63580 typ relay raddr 172.22.181.115 rport 40782\r\n</para>
            /// </summary>
            [NameInMap("Sdp")]
            [Validation(Required=false)]
            public string Sdp { get; set; }

            /// <summary>
            /// <para>The type of the SDP payload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>offer</para>
            /// </summary>
            [NameInMap("SdpType")]
            [Validation(Required=false)]
            public string SdpType { get; set; }

        }

        /// <summary>
        /// <para>The user\&quot;s number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86131***</para>
        /// </summary>
        [NameInMap("UserNumber")]
        [Validation(Required=false)]
        public string UserNumber { get; set; }

    }

}
