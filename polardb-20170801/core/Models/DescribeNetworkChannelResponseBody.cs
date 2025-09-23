// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeNetworkChannelResponseBody : TeaModel {
        [NameInMap("ChannelInfos")]
        [Validation(Required=false)]
        public List<DescribeNetworkChannelResponseBodyChannelInfos> ChannelInfos { get; set; }
        public class DescribeNetworkChannelResponseBodyChannelInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ch4</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pc-*************</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test update</para>
            /// </summary>
            [NameInMap("Notes")]
            [Validation(Required=false)]
            public string Notes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pc-*************</para>
            /// </summary>
            [NameInMap("TargetDBClusterId")]
            [Validation(Required=false)]
            public string TargetDBClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33.<em>.</em>.240</para>
            /// </summary>
            [NameInMap("TargetIp")]
            [Validation(Required=false)]
            public string TargetIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3389</para>
            /// </summary>
            [NameInMap("TargetPort")]
            [Validation(Required=false)]
            public string TargetPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polardb_for_postgresql</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-2ze13g2c6j7j2jl*******</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>925B84D9-CA72-432C-95CF-738C22******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
