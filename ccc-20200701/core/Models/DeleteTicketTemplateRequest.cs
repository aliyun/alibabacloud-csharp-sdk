// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class DeleteTicketTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ef1e71e9-ae9d-487c-96ad-9181d85cf802</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b>43c2671b-8939-4223-</b>*-6bd187905cc8_1717664210492</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
