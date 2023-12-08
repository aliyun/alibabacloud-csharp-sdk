// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetVbrFlowTopNShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of member accounts.
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        /// <summary>
        /// The CEN connection ID.
        /// </summary>
        [NameInMap("AttachmentId")]
        [Validation(Required=false)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. The maximum time range that you can query is 24 hours.
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// The CEN instance ID.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The local IP address.
        /// </summary>
        [NameInMap("CloudIp")]
        [Validation(Required=false)]
        public string CloudIp { get; set; }

        /// <summary>
        /// The local port.
        /// 
        /// >  This parameter is required only if you set GroupBy to CloudPort.
        /// </summary>
        [NameInMap("CloudPort")]
        [Validation(Required=false)]
        public string CloudPort { get; set; }

        /// <summary>
        /// The direction of the hybrid cloud traffic in the local regions or for the local IP addresses. Valid values:
        /// 
        /// *   in: traffic from a data center to Alibaba Cloud
        /// *   out: traffic from Alibaba Cloud to a data center
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The end of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. The maximum time range that you can query is 24 hours.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The dimension for ranking hybrid cloud traffic data. The value of this parameter is case-sensitive. Valid values:
        /// 
        /// *   1Tuple: queries the rankings of hybrid cloud traffic data for the Cloud Enterprise Network (CEN) instances, CEN connections, virtual border routers (VBRs), and IP addresses.
        /// *   2Tuple: queries the rankings of hybrid cloud traffic data for the local and remote IP addresses.
        /// *   5Tuple: queries the rankings of hybrid cloud traffic data for the local and remote IP addresses, local and remote ports, and protocols.
        /// *   CloudPort: queries the rankings of hybrid cloud traffic data for the local ports.
        /// *   OtherPort: queries the rankings of hybrid cloud traffic data for the remote ports.
        /// *   Protocol: queries the rankings of hybrid cloud traffic data for the protocols.
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// The metric for ranking hybrid cloud traffic data. Default value: Bytes. This value specifies that hybrid cloud traffic data is ranked by traffic volumes.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The remote IP address.
        /// </summary>
        [NameInMap("OtherIp")]
        [Validation(Required=false)]
        public string OtherIp { get; set; }

        /// <summary>
        /// The remote port.
        /// 
        /// >  This parameter is required only if you set GroupBy to OtherPort.
        /// </summary>
        [NameInMap("OtherPort")]
        [Validation(Required=false)]
        public string OtherPort { get; set; }

        /// <summary>
        /// The protocol number.
        /// 
        /// >  All protocols are supported. This parameter is required only if you set GroupBy to 5Tuple or Protocol.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The local region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The order for ranking hybrid cloud traffic data. Valid values:
        /// 
        /// *   desc: descending order
        /// *   asc: ascending order
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// Specifies top-N traffic data to display. Default value: **10**. This value specifies that top-10 traffic data is displayed by default. Maximum value: **100**.
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        /// <summary>
        /// Specifies whether to enable the multi-account management feature. Default value: **false**. This value specifies that the multi-account management feature is disabled.
        /// 
        /// >  By default, the multi-account management feature is not available. If you want to use this feature, contact your account manager to apply for permissions.
        /// </summary>
        [NameInMap("UseMultiAccount")]
        [Validation(Required=false)]
        public bool? UseMultiAccount { get; set; }

        /// <summary>
        /// The ID of the VBR that is associated with the Express Connect circuit.
        /// </summary>
        [NameInMap("VirtualBorderRouterId")]
        [Validation(Required=false)]
        public string VirtualBorderRouterId { get; set; }

    }

}
