// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DeleteAccountRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testaccount</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-*********</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the security administrator account.</para>
        /// <remarks>
        /// <para>If three-role mode is enabled, this parameter is required. If three-role mode is not enabled, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>securityAccount</para>
        /// </summary>
        [NameInMap("SecurityAccountName")]
        [Validation(Required=false)]
        public string SecurityAccountName { get; set; }

        /// <summary>
        /// <para>The password of the security administrator account.</para>
        /// <remarks>
        /// <para>If three-role mode is enabled, this parameter is required. If three-role mode is not enabled, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>securityPassword</para>
        /// </summary>
        [NameInMap("SecurityAccountPassword")]
        [Validation(Required=false)]
        public string SecurityAccountPassword { get; set; }

    }

}
