// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DeleteDatabaseAccountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the database account that you want to delete.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2758839.html">ListDatabaseAccounts</a> operation to query the database account ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("DatabaseAccountId")]
        [Validation(Required=false)]
        public string DatabaseAccountId { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host from which you want to delete the database account.</para>
        /// <remarks>
        /// <para>You can call the DescribeInstances operation to query the ID of the bastion host.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host from which you want to delete the database account.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, <a href="https://help.aliyun.com/document_detail/40654.html">see Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
