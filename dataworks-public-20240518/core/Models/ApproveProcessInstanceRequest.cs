// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ApproveProcessInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agree</para>
        /// </summary>
        [NameInMap("ApprovalAction")]
        [Validation(Required=false)]
        public string ApprovalAction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApprovalComment")]
        [Validation(Required=false)]
        public string ApprovalComment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9*****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>332066440109224007</para>
        /// </summary>
        [NameInMap("ProcessInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}
