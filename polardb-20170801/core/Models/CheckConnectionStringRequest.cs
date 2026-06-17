// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CheckConnectionStringRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the new connection string. The prefix must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It must consist of lowercase letters, digits, and periods (.).</para>
        /// </description></item>
        /// <item><description><para>It must start with a letter and end with a letter or a digit.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************.pg.polardb.pre.rds.aliyuncs.com:5432</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to view the details of all clusters in your account, including cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
