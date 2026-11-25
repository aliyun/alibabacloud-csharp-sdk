// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class PublishAppInstanceRequest : TeaModel {
        [NameInMap("ArtifactDigest")]
        [Validation(Required=false)]
        public string ArtifactDigest { get; set; }

        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250821161210000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("CandidateId")]
        [Validation(Required=false)]
        public string CandidateId { get; set; }

        /// <summary>
        /// <para>The deployment channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("DeployChannel")]
        [Validation(Required=false)]
        public string DeployChannel { get; set; }

        /// <summary>
        /// <para>The publish description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_BY_NLB.nlb-jcvs5sm9l8um84zbfa</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        [NameInMap("IdempotencyKey")]
        [Validation(Required=false)]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// <para>The logical version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("LogicalNumber")]
        [Validation(Required=false)]
        public int? LogicalNumber { get; set; }

        [NameInMap("PlatformAppid")]
        [Validation(Required=false)]
        public string PlatformAppid { get; set; }

        [NameInMap("PluginDeclarationHash")]
        [Validation(Required=false)]
        public string PluginDeclarationHash { get; set; }

        [NameInMap("PrivacyDraftId")]
        [Validation(Required=false)]
        public string PrivacyDraftId { get; set; }

        [NameInMap("PrivacyRevision")]
        [Validation(Required=false)]
        public string PrivacyRevision { get; set; }

        /// <summary>
        /// <para>The publish number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PublishNumber")]
        [Validation(Required=false)]
        public string PublishNumber { get; set; }

        [NameInMap("PublishOrderId")]
        [Validation(Required=false)]
        public long? PublishOrderId { get; set; }

        [NameInMap("UploadSequence")]
        [Validation(Required=false)]
        public long? UploadSequence { get; set; }

        /// <summary>
        /// <para>The action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUILD</para>
        /// </summary>
        [NameInMap("WeappAction")]
        [Validation(Required=false)]
        public string WeappAction { get; set; }

    }

}
