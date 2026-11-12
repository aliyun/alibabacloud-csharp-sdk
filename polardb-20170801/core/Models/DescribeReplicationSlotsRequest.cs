// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeReplicationSlotsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB cluster to query. This operation is applicable only to PostgreSQL clusters. If you specify the ID of a cluster that uses another database engine, the InvalidDBType.Malformed error is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-test123456</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the child node of the distributed instance, which is used to filter replication slots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testGroup</para>
        /// </summary>
        [NameInMap("SubGroupName")]
        [Validation(Required=false)]
        public string SubGroupName { get; set; }

    }

}
