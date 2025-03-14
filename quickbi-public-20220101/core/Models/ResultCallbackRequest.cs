// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ResultCallbackRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the approval process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5ea0db8-<b><b>-</b></b>-9081-04bc0df4c6a3</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The reason for the approval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not a Division A analyst.</para>
        /// </summary>
        [NameInMap("HandleReason")]
        [Validation(Required=false)]
        public string HandleReason { get; set; }

        /// <summary>
        /// <para>Approval result:</para>
        /// <list type="bullet">
        /// <item><description>1: passed</description></item>
        /// <item><description>2: rejected</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
