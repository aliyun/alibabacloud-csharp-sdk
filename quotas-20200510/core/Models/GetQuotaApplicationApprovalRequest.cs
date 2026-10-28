// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaApplicationApprovalRequest : Darabonba.Model {
        /// <summary>
        /// <para>The ID of the quota application.</para>
        /// <para>For information about how to obtain the ID of a quota application, see <a href="https://help.aliyun.com/document_detail/440568.html">ListQuotaApplications</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d314d6ae-867d-484c-9009-3d42****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

    }

}

