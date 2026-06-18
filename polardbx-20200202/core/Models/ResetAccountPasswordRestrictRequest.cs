// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ResetAccountPasswordRestrictRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account whose password you want to reset. &gt; Only passwords of standard accounts can be reset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testaccount</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The account information for which you want to reset the password. Separate multiple account entries with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The instance ID. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of all instances in the specified region, including instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-********</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID. &gt; You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the account whose password you want to reset. &gt; <em>Only passwords of standard accounts can be reset.</em> You can invoke the <a href="https://help.aliyun.com/document_detail/196844.html">DescribeAccountList</a> operation to query the account information of the target instance, including account names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account_sec</para>
        /// </summary>
        [NameInMap("SecurityAccountName")]
        [Validation(Required=false)]
        public string SecurityAccountName { get; set; }

        /// <summary>
        /// <para>The password of the security administrator account. &gt; If three-role mode is enabled, this parameter is required. For more information about three-role mode, see <a href="https://help.aliyun.com/document_detail/213824.html">Three-role mode</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SecurityAccountPassword")]
        [Validation(Required=false)]
        public string SecurityAccountPassword { get; set; }

    }

}
