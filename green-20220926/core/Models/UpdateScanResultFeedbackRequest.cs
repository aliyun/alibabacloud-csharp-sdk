// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class UpdateScanResultFeedbackRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>missOut</para>
        /// </summary>
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>46232656-984E-****-A648-B1D0667B6C3E</para>
        /// </summary>
        [NameInMap("QueryRequestId")]
        [Validation(Required=false)]
        public string QueryRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

    }

}
