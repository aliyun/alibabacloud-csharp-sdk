// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class PublishStandardRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The publish command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PublishCommand")]
        [Validation(Required=false)]
        public PublishStandardRequestPublishCommand PublishCommand { get; set; }
        public class PublishStandardRequestPublishCommand : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically publish after approval. Default value: true.</para>
            /// </summary>
            [NameInMap("AutoPublishAfterApproval")]
            [Validation(Required=false)]
            public bool? AutoPublishAfterApproval { get; set; }

            /// <summary>
            /// <para>The review comment. Maximum length: 128 characters.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The standard ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The specified reviewers.</para>
            /// </summary>
            [NameInMap("ReviewerIdList")]
            [Validation(Required=false)]
            public List<string> ReviewerIdList { get; set; }

            /// <summary>
            /// <para>The stage of the standard. Valid values: DEV and PROD. Default value: DEV.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("StandardStage")]
            [Validation(Required=false)]
            public string StandardStage { get; set; }

            /// <summary>
            /// <para>The version number. Default value: -1 (latest version).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
