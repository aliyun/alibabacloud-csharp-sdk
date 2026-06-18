// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class EnableRightsSeparationRequest : TeaModel {
        /// <summary>
        /// <para>The description of the audit account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("AuditAccountDescription")]
        [Validation(Required=false)]
        public string AuditAccountDescription { get; set; }

        /// <summary>
        /// <para>The name of the audit account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account_audit</para>
        /// </summary>
        [NameInMap("AuditAccountName")]
        [Validation(Required=false)]
        public string AuditAccountName { get; set; }

        /// <summary>
        /// <para>The password of the audit account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AuditAccountPassword")]
        [Validation(Required=false)]
        public string AuditAccountPassword { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-htri0ori2r4k9p</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The description of the security administrator account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("SecurityAccountDescription")]
        [Validation(Required=false)]
        public string SecurityAccountDescription { get; set; }

        /// <summary>
        /// <para>The name of the security administrator account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account_sec</para>
        /// </summary>
        [NameInMap("SecurityAccountName")]
        [Validation(Required=false)]
        public string SecurityAccountName { get; set; }

        /// <summary>
        /// <para>The password of the security administrator account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SecurityAccountPassword")]
        [Validation(Required=false)]
        public string SecurityAccountPassword { get; set; }

    }

}
