// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class LibraryReview : TeaModel {
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public string Applicant { get; set; }

        [NameInMap("artificatId")]
        [Validation(Required=false)]
        public string ArtificatId { get; set; }

        [NameInMap("developerName")]
        [Validation(Required=false)]
        public string DeveloperName { get; set; }

        [NameInMap("feedbackLibraryInstruction")]
        [Validation(Required=false)]
        public string FeedbackLibraryInstruction { get; set; }

        [NameInMap("feedbackLibrarySchema")]
        [Validation(Required=false)]
        public string FeedbackLibrarySchema { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("libraryName")]
        [Validation(Required=false)]
        public string LibraryName { get; set; }

        [NameInMap("libraryUrl")]
        [Validation(Required=false)]
        public string LibraryUrl { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public string MarketId { get; set; }

        [NameInMap("marketName")]
        [Validation(Required=false)]
        public string MarketName { get; set; }

        [NameInMap("remainTime")]
        [Validation(Required=false)]
        public string RemainTime { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("reviewerId")]
        [Validation(Required=false)]
        public string ReviewerId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
