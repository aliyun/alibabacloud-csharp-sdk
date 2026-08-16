// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListWuyingServerRequest : TeaModel {
        /// <summary>
        /// <para>The list of statuses for joining a virtual node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("AddVirtualNodePoolStatusList")]
        [Validation(Required=false)]
        public List<string> AddVirtualNodePoolStatusList { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The billing type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The end time of the creation time range, in ISO 8601 format. This time point is exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the creation time range, in ISO 8601 format. This time point is inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>The end time of the expiration time range, in ISO 8601 format. This time point is exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpiredTimeEnd")]
        [Validation(Required=false)]
        public string ExpiredTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the expiration time range, in ISO 8601 format. This time point is inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpiredTimeStart")]
        [Validation(Required=false)]
        public string ExpiredTimeStart { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-bp13mu****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The internal IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.31.1.1</para>
        /// </summary>
        [NameInMap("NetworkInterfaceIp")]
        [Validation(Required=false)]
        public string NetworkInterfaceIp { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-172301****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wuying_server</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The workstation instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.proworkstation_flagship_elite.32c64g.48g1x</para>
        /// </summary>
        [NameInMap("ServerInstanceType")]
        [Validation(Required=false)]
        public string ServerInstanceType { get; set; }

        /// <summary>
        /// <para>The workstation status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of authorized users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

        /// <summary>
        /// <para>The virtual node pool ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vnp-bp1234567890abcde</para>
        /// </summary>
        [NameInMap("VirtualNodePoolId")]
        [Validation(Required=false)]
        public string VirtualNodePoolId { get; set; }

        /// <summary>
        /// <para>The list of workstation IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WuyingServerIdList")]
        [Validation(Required=false)]
        public List<string> WuyingServerIdList { get; set; }

        /// <summary>
        /// <para>The workstation name or workstation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleServerName</para>
        /// </summary>
        [NameInMap("WuyingServerNameOrId")]
        [Validation(Required=false)]
        public string WuyingServerNameOrId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
