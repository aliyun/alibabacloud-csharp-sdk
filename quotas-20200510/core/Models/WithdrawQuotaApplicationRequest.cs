// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class WithdrawQuotaApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the quota application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d314d6ae-867d-484c-9009-3d42****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The reason for withdrawing the quota increase request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DesireValue is wrong</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
