// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarFsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the PolarDB instance on which the application depends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze8u21s03******</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer greater than 0 and not exceeding the maximum value of Integer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The description of the PolarFS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-ins1********</para>
        /// </summary>
        [NameInMap("PolarFsInstanceDescription")]
        [Validation(Required=false)]
        public string PolarFsInstanceDescription { get; set; }

        /// <summary>
        /// <para>The list of PolarFS instance IDs, separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-ins1*******</para>
        /// </summary>
        [NameInMap("PolarFsInstanceIds")]
        [Validation(Required=false)]
        public string PolarFsInstanceIds { get; set; }

        /// <summary>
        /// <para>The PolarFS type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("PolarFsType")]
        [Validation(Required=false)]
        public string PolarFsType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the associated PolarDB cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2zejpr41d9xk*****</para>
        /// </summary>
        [NameInMap("RelativeDbClusterId")]
        [Validation(Required=false)]
        public string RelativeDbClusterId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribePolarFsRequestTag> Tag { get; set; }
        public class DescribePolarFsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
