// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class AddRecognizeRuleRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("ColExclude")]
        [Validation(Required=false)]
        public string ColExclude { get; set; }

        [NameInMap("ColScan")]
        [Validation(Required=false)]
        public string ColScan { get; set; }

        [NameInMap("CommentScan")]
        [Validation(Required=false)]
        public string CommentScan { get; set; }

        [NameInMap("ContentScan")]
        [Validation(Required=false)]
        public string ContentScan { get; set; }

        [NameInMap("HitThreshold")]
        [Validation(Required=false)]
        public int? HitThreshold { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("LevelName")]
        [Validation(Required=false)]
        public string LevelName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeParent")]
        [Validation(Required=false)]
        public string NodeParent { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public int? OperationType { get; set; }

        [NameInMap("RecognizeRules")]
        [Validation(Required=false)]
        public string RecognizeRules { get; set; }

        [NameInMap("RecognizeRulesType")]
        [Validation(Required=false)]
        public string RecognizeRulesType { get; set; }

        [NameInMap("SensitiveDescription")]
        [Validation(Required=false)]
        public string SensitiveDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
