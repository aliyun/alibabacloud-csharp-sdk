// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeSqlAuditInfoRequest : TeaModel {
        /// <summary>
        /// <para>The name of the audit administrator account. &gt; This parameter is required if the three-role mode is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/213824.html">Three-role mode</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_daa</para>
        /// </summary>
        [NameInMap("AuditAccountName")]
        [Validation(Required=false)]
        public string AuditAccountName { get; set; }

        /// <summary>
        /// <para>The password of the audit administrator account. &gt; This parameter is required if the three-role mode is enabled. For more information about the three-role mode, see <a href="https://help.aliyun.com/document_detail/213824.html">Three-role mode</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AuditAccountPassword")]
        [Validation(Required=false)]
        public string AuditAccountPassword { get; set; }

        /// <summary>
        /// <para>The instance ID. &gt; You can call <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> to query the details of all instances in the specified region, including instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-****************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides. &gt; You can call <a href="https://help.aliyun.com/document_detail/196841.html">DescribeRegions</a> to query the regions supported by PolarDB-X, including region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
