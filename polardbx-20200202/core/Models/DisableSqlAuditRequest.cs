// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DisableSqlAuditRequest : TeaModel {
        /// <summary>
        /// <para>The name of the audit administrator account. &gt; If the three-role mode is enabled, this parameter is required. For more information about the three-role mode, see <a href="https://help.aliyun.com/document_detail/213824.html">Three-role mode</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_daa</para>
        /// </summary>
        [NameInMap("AuditAccountName")]
        [Validation(Required=false)]
        public string AuditAccountName { get; set; }

        /// <summary>
        /// <para>The password of the audit administrator account. &gt; If the three-role mode is enabled, this parameter is required. For more information about the three-role mode, see <a href="https://help.aliyun.com/document_detail/213824.html">Three-role mode</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pw@11111</para>
        /// </summary>
        [NameInMap("AuditAccountPassword")]
        [Validation(Required=false)]
        public string AuditAccountPassword { get; set; }

        /// <summary>
        /// <para>The instance ID. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of all instances in the specified region, including instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-****************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196841.html">DescribeRegions</a> operation to query the regions supported by PolarDB-X, including region IDs.</para>
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
