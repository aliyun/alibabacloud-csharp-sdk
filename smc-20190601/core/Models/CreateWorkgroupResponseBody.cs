// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class CreateWorkgroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C8B26B44-0189-443E-9816-D951F59623A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The workgroup ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-***</para>
        /// </summary>
        [NameInMap("WorkgroupId")]
        [Validation(Required=false)]
        public string WorkgroupId { get; set; }

    }

}
