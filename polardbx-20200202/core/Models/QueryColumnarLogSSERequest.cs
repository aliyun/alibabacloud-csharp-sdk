// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class QueryColumnarLogSSERequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB-X instance whose column store audit logs you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-********</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The maximum number of result rows to return for this request. Valid values: 1 to 10000. If this parameter is not specified, no additional row limit is imposed on the SQL submitted by the caller. The server-side SSE upper limit of 10000 rows and the top-level LIMIT clause in the SQL statement still apply.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxResultRows")]
        [Validation(Required=false)]
        public long? MaxResultRows { get; set; }

        /// <summary>
        /// <para>The region ID of the request. The value must match the region where the SQLQuery service is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The read-only query statement to execute. Only a single MySQL SELECT statement is supported, and it must access the fully qualified polardbx_sls table. Multi-statement queries, write operations, locks, user variables, dynamic placeholders, and reserved hints are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from device where name = \&quot;108001022203365239\&quot;</para>
        /// </summary>
        [NameInMap("SQL")]
        [Validation(Required=false)]
        public string SQL { get; set; }

    }

}
