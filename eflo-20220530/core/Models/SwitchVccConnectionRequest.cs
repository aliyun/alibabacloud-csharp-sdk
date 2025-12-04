// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class SwitchVccConnectionRequest : TeaModel {
        /// <summary>
        /// <para>CEN</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-bkiw0x1347roek****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>Connection type, CENTR/VPC</para>
        /// 
        /// <b>Example:</b>
        /// <para>CENTR</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>Region ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>vSwitch ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-t4nahb0pxckgktxfv****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>Cloud Connect Network (CCN) ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-zvp2w22****</para>
        /// </summary>
        [NameInMap("VccId")]
        [Validation(Required=false)]
        public string VccId { get; set; }

        /// <summary>
        /// <para>VPC ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6aa4ddo97frj22t****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
