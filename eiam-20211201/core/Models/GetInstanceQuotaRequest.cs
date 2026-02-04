// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceQuotaRequest : TeaModel {
        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>配额类型，QuotaEnum</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userMaxNumber</para>
        /// </summary>
        [NameInMap("QuotaKey")]
        [Validation(Required=false)]
        public string QuotaKey { get; set; }

    }

}
