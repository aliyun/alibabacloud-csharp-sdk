// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCloudPermissionTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the permission template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpt_01l8dagf2iablhigj75l1n99xxxxx</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplateId")]
        [Validation(Required=false)]
        public string CloudPermissionTemplateId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
