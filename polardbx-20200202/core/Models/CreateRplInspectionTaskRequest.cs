// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateRplInspectionTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraDB RDS instance to which the migration object belongs in the target instance. &gt; You can invoke the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of all ApsaraDB RDS instances in the specified region, including instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transfer_test3</para>
        /// </summary>
        [NameInMap("DstDb")]
        [Validation(Required=false)]
        public string DstDb { get; set; }

        /// <summary>
        /// <para>The password of the privileged account for the destination ApsaraDB RDS instance. &gt; * The password must be 8 to 32 characters in length. * The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. * Special characters include ! @ # $ &amp; % ^ * ( ) _ + - =.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DstPassword")]
        [Validation(Required=false)]
        public string DstPassword { get; set; }

        /// <summary>
        /// <para>The destination task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-zkrc1****l54rc</para>
        /// </summary>
        [NameInMap("DstResId")]
        [Validation(Required=false)]
        public string DstResId { get; set; }

        /// <summary>
        /// <para>The username used to connect to the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bbt_item</para>
        /// </summary>
        [NameInMap("DstUserName")]
        [Validation(Required=false)]
        public string DstUserName { get; set; }

        /// <summary>
        /// <para>The region ID. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196841.html">DescribeRegions</a> operation to query the regions supported by PolarDB-X, including region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The switchover task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>etx-szr2rr6i*****</para>
        /// </summary>
        [NameInMap("SlinkTaskId")]
        [Validation(Required=false)]
        public string SlinkTaskId { get; set; }

        /// <summary>
        /// <para>The password of the source ApsaraDB RDS instance. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of all instances in the specified region, including the password.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcPassword")]
        [Validation(Required=false)]
        public string SrcPassword { get; set; }

        /// <summary>
        /// <para>The username used to connect to the source instance (source database).</para>
        /// 
        /// <b>Example:</b>
        /// <para>bbt_ump</para>
        /// </summary>
        [NameInMap("SrcUserName")]
        [Validation(Required=false)]
        public string SrcUserName { get; set; }

    }

}
