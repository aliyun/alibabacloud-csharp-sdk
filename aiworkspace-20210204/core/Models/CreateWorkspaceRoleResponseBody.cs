// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateWorkspaceRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The job ID for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateWorkspaceCustomRole-role-<em><b>abc</b></em>****</para>
        /// </summary>
        [NameInMap("InstanceJobId")]
        [Validation(Required=false)]
        public string InstanceJobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A519F77D-28A0-52F5-AB82-5********8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
