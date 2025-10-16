// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateAckClusterConnectorRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb0f5640b1b2d404cad6ba21509d7847b</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-cluster-connector-name</para>
        /// </summary>
        [NameInMap("ConnectorName")]
        [Validation(Required=false)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>135809047715****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zerfbbje7dvnbii2****</para>
        /// </summary>
        [NameInMap("PrimaryVswitchId")]
        [Validation(Required=false)]
        public string PrimaryVswitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.100.1.1</para>
        /// </summary>
        [NameInMap("PrimaryVswitchIp")]
        [Validation(Required=false)]
        public string PrimaryVswitchIp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-2ze2gtlfozrab01cfo****</para>
        /// </summary>
        [NameInMap("StandbyVswitchId")]
        [Validation(Required=false)]
        public string StandbyVswitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.100.2.1</para>
        /// </summary>
        [NameInMap("StandbyVswitchIp")]
        [Validation(Required=false)]
        public string StandbyVswitchIp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public string Ttl { get; set; }

    }

}
