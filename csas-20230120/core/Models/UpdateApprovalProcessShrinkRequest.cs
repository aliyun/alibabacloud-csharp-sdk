// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateApprovalProcessShrinkRequest : TeaModel {
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public int? ApprovalType { get; set; }

        /// <summary>
        /// <para>The description of the approval flow. The description must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces. Chinese characters are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EventLabel")]
        [Validation(Required=false)]
        public string EventLabel { get; set; }

        [NameInMap("ExternalConfig")]
        [Validation(Required=false)]
        public string ExternalConfig { get; set; }

        [NameInMap("MatchSchemaConfigs")]
        [Validation(Required=false)]
        public string MatchSchemaConfigsShrink { get; set; }

        /// <summary>
        /// <para>The matched approval templates.</para>
        /// </summary>
        [NameInMap("MatchSchemas")]
        [Validation(Required=false)]
        public string MatchSchemasShrink { get; set; }

        /// <summary>
        /// <para>The ID of the approval flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-process-f16bf74b2b29****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>The name of the approval flow. The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). Chinese characters are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The list of approval nodes. You can define up to 5 approval nodes.</para>
        /// </summary>
        [NameInMap("ProcessNodes")]
        [Validation(Required=false)]
        public List<List<string>> ProcessNodes { get; set; }

    }

}
