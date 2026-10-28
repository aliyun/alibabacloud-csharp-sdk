// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ProcessApprovalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d54ca949-9b88-4514-add3-c6029c4027f4</para>
        /// </summary>
        [NameInMap("ApplicationSheetId")]
        [Validation(Required=false)]
        public string ApplicationSheetId { get; set; }

        /// <summary>
        /// <para>The approval action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Approve: approved.</description></item>
        /// <item><description>Reject: rejected.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Approve</para>
        /// </summary>
        [NameInMap("ApprovalAction")]
        [Validation(Required=false)]
        public string ApprovalAction { get; set; }

        /// <summary>
        /// <para>The approval comments.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>同意</para>
        /// </summary>
        [NameInMap("ApprovalComments")]
        [Validation(Required=false)]
        public string ApprovalComments { get; set; }

    }

}
