// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCustomFieldRequest : TeaModel {
        /// <summary>
        /// <para>fieldId</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ufd_001</para>
        /// </summary>
        [NameInMap("FieldId")]
        [Validation(Required=false)]
        public string FieldId { get; set; }

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

    }

}
