// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarFsAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can find cluster IDs by calling the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1q76364ird*****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the PolarFS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the FUSE mount information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Queries the FUSE mount information.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Does not query the FUSE mount information. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("QueryFuseMountInfo")]
        [Validation(Required=false)]
        public bool? QueryFuseMountInfo { get; set; }

    }

}
