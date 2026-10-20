// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateWorkflowDefinitionResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the DataStudio workflow.</para>
        /// <remarks>
        /// <para>Notice: This field is of the Long type before SDK 8.0.0 and of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK, and the parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation failures only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>463497880880954XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0EF298E5-0940-5AC7-9CB0-6502507****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
