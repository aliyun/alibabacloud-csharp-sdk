// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class RemoveSourcesFromTrafficMirrorSessionRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>The client generates the value. The value must be unique among different requests and cannot exceed 64 ASCII characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without removing the traffic mirror sources. The system checks the required parameters, request format, and limits. If the request fails the check, an error message is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends the request. After the request passes the check, the traffic mirror sources are removed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the traffic mirror session. You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the most recent region list. For more information about the regions that support traffic mirroring, see <a href="https://help.aliyun.com/document_detail/207513.html">Traffic mirroring overview</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The instance ID of the traffic mirror session from which you want to delete traffic mirror sources.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tms-j6cla50buc44ap8tu****</para>
        /// </summary>
        [NameInMap("TrafficMirrorSessionId")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionId { get; set; }

        /// <summary>
        /// <para>The instance ID of the traffic mirror source that you want to delete. The maximum value of <b>N</b> is <b>10</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-j6c8znm5l1yt4sox****</para>
        /// </summary>
        [NameInMap("TrafficMirrorSourceIds")]
        [Validation(Required=false)]
        public List<string> TrafficMirrorSourceIds { get; set; }

    }

}
