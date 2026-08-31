// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ExecuteMetaQueryRequest : TeaModel {
        /// <summary>
        /// <para>The primary instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxsp-*********</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The maximum number of rows to return. Default value: 100. Valid values: 1 to 1000. The actual number of returned rows is the minimum value among the code hard limit, the Biz DB limit, and the outermost LIMIT clause in the SQL statement. To retrieve data continuously, implement pagination in the SQL statement.</para>
        /// </summary>
        [NameInMap("MaxResultRows")]
        [Validation(Required=false)]
        public long? MaxResultRows { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The SQL statement to execute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>show databases;</para>
        /// </summary>
        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        /// <summary>
        /// <para>The data node (DN) instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-xdb-s-*</para>
        /// </summary>
        [NameInMap("StorageInstId")]
        [Validation(Required=false)]
        public string StorageInstId { get; set; }

    }

}
