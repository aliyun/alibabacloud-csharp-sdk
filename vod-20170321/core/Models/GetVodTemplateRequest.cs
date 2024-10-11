// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVodTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the snapshot template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c49f2f4c0969*****fcd446690</para>
        /// </summary>
        [NameInMap("VodTemplateId")]
        [Validation(Required=false)]
        public string VodTemplateId { get; set; }

    }

}
