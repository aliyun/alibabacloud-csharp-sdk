// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteVodTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the snapshot template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f5b228fe6930e*****d6bf55bd87789</para>
        /// </summary>
        [NameInMap("VodTemplateId")]
        [Validation(Required=false)]
        public string VodTemplateId { get; set; }

    }

}
