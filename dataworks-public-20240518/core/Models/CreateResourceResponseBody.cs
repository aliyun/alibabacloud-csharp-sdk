// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the file resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>631478864897630XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>A5B97987-66EA-5563-9599-A2752292XXXX</para>
        /// 
        /// <b>Example:</b>
        /// <para>The ID of the file resource.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
