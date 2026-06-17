// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeletePolarFsQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to view the details of all clusters under your account, including the cluster ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the Polarlakebase instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The details of the quota rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<DeletePolarFsQuotaRequestQuotas> Quotas { get; set; }
        public class DeletePolarFsQuotaRequestQuotas : TeaModel {
            /// <summary>
            /// <para>The ID of the quota.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the quota.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sftest</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
