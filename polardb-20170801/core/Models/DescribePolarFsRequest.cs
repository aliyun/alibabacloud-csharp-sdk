// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarFsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-2ze8u21s03******</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-ins1********</para>
        /// </summary>
        [NameInMap("PolarFsInstanceDescription")]
        [Validation(Required=false)]
        public string PolarFsInstanceDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-ins1*******</para>
        /// </summary>
        [NameInMap("PolarFsInstanceIds")]
        [Validation(Required=false)]
        public string PolarFsInstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("PolarFsType")]
        [Validation(Required=false)]
        public string PolarFsType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-2zejpr41d9xk*****</para>
        /// </summary>
        [NameInMap("RelativeDbClusterId")]
        [Validation(Required=false)]
        public string RelativeDbClusterId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribePolarFsRequestTag> Tag { get; set; }
        public class DescribePolarFsRequestTag : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
