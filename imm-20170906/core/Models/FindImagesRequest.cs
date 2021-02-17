// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class FindImagesRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("ImageSizeRange")]
        [Validation(Required=false)]
        public string ImageSizeRange { get; set; }

        [NameInMap("ImageTimeRange")]
        [Validation(Required=false)]
        public string ImageTimeRange { get; set; }

        [NameInMap("CreateTimeRange")]
        [Validation(Required=false)]
        public string CreateTimeRange { get; set; }

        [NameInMap("ModifyTimeRange")]
        [Validation(Required=false)]
        public string ModifyTimeRange { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("SourceUriPrefix")]
        [Validation(Required=false)]
        public string SourceUriPrefix { get; set; }

        [NameInMap("RemarksAPrefix")]
        [Validation(Required=false)]
        public string RemarksAPrefix { get; set; }

        [NameInMap("RemarksBPrefix")]
        [Validation(Required=false)]
        public string RemarksBPrefix { get; set; }

        [NameInMap("TagNames")]
        [Validation(Required=false)]
        public string TagNames { get; set; }

        [NameInMap("OCRContentsMatch")]
        [Validation(Required=false)]
        public string OCRContentsMatch { get; set; }

        [NameInMap("AgeRange")]
        [Validation(Required=false)]
        public string AgeRange { get; set; }

        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("Emotion")]
        [Validation(Required=false)]
        public string Emotion { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("LocationBoundary")]
        [Validation(Required=false)]
        public string LocationBoundary { get; set; }

        [NameInMap("RemarksCPrefix")]
        [Validation(Required=false)]
        public string RemarksCPrefix { get; set; }

        [NameInMap("RemarksDPrefix")]
        [Validation(Required=false)]
        public string RemarksDPrefix { get; set; }

        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("FacesModifyTimeRange")]
        [Validation(Required=false)]
        public string FacesModifyTimeRange { get; set; }

        [NameInMap("TagsModifyTimeRange")]
        [Validation(Required=false)]
        public string TagsModifyTimeRange { get; set; }

        [NameInMap("AddressLineContentsMatch")]
        [Validation(Required=false)]
        public string AddressLineContentsMatch { get; set; }

        [NameInMap("RemarksArrayAIn")]
        [Validation(Required=false)]
        public string RemarksArrayAIn { get; set; }

        [NameInMap("RemarksArrayBIn")]
        [Validation(Required=false)]
        public string RemarksArrayBIn { get; set; }

    }

}
