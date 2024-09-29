// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class UpdateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks items such as whether the member status can be modified and whether security information is configured for the member. If the request does not pass the dry run, an error code is returned.</description></item>
        /// <item><description>false (default): performs a dry run and performs the actual request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The new type of the member. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ResourceAccount: resource account</description></item>
        /// <item><description>CloudAccount: cloud account</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify either <c>NewDisplayName</c> or <c>NewAccountType</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceAccount</para>
        /// </summary>
        [NameInMap("NewAccountType")]
        [Validation(Required=false)]
        public string NewAccountType { get; set; }

        /// <summary>
        /// <para>The new display name of the member.</para>
        /// <remarks>
        /// <para>You can specify either <c>NewDisplayName</c> or <c>NewAccountType</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

    }

}
