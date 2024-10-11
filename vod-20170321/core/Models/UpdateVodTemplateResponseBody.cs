// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVodTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8c75a02e339b*****0b0d2c48171a22</para>
        /// </summary>
        [NameInMap("VodTemplateId")]
        [Validation(Required=false)]
        public string VodTemplateId { get; set; }

    }

}
