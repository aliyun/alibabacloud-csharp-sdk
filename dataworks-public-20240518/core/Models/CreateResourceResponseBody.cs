// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the resource file.</para>
        /// <remarks>
        /// <para>This field is of type Long in SDK versions prior to 8.0.0, and of type String in SDK version 8.0.0 and later. This change does not affect the normal use of the SDK; parameters are still returned according to the type defined in the SDK. Compilation failures due to the type change may occur only when upgrading the SDK across version 8.0.0, in which case users need to manually correct the data type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>631478864897630XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

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
