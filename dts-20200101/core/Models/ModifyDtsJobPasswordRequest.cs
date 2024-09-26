// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobPasswordRequest : TeaModel {
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l3m1213ye7l****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>Specifies the database to which the password belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>src</b>: source database</description></item>
        /// <item><description><b>dest</b>: destination database</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter must be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>src</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The new password of the account.</para>
        /// <remarks>
        /// <para> This parameter must be specified and cannot be the same as the current password.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ID of the region where the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>The account of the source or destination database.</para>
        /// <remarks>
        /// <para> This parameter must be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
