// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 0 indicates success.</para>
        /// <remarks>
        /// <para>If you call this API operation by using an SDK, the return type is Integer. If you call this API operation by using a common method or HTTP, the return type is String.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public CreateInstanceResponseBodyInstanceIds InstanceIds { get; set; }
        public class CreateInstanceResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A431388-2D4B-46F4-A96B-D4E6BD0688C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
