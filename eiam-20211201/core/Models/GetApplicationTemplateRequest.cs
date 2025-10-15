// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationTemplateRequest : TeaModel {
        /// <summary>
        /// <para>应用模板id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apt_ramuser_xxxx</para>
        /// </summary>
        [NameInMap("ApplicationTemplateId")]
        [Validation(Required=false)]
        public string ApplicationTemplateId { get; set; }

    }

}
