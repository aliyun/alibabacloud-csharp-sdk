// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateApprovalProcessShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the approval process. The description must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces. Chinese characters are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个审批流程</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The matched approval templates.</para>
        /// </summary>
        [NameInMap("MatchSchemas")]
        [Validation(Required=false)]
        public string MatchSchemasShrink { get; set; }

        /// <summary>
        /// <para>The process name. The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). Chinese characters are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_process</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The list of approval nodes. You can define up to 5 approval nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProcessNodes")]
        [Validation(Required=false)]
        public List<List<string>> ProcessNodes { get; set; }

    }

}
