// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeLinktSearchworkitemRequest : TeaModel {
        [NameInMap("AssignedToId")]
        [Validation(Required=false)]
        public string AssignedToId { get; set; }

        [NameInMap("Begin")]
        [Validation(Required=false)]
        public long? Begin { get; set; }

        [NameInMap("CcsOption")]
        [Validation(Required=false)]
        public string CcsOption { get; set; }

        [NameInMap("CreatedAtAfter")]
        [Validation(Required=false)]
        public long? CreatedAtAfter { get; set; }

        [NameInMap("CreatedAtBefore")]
        [Validation(Required=false)]
        public long? CreatedAtBefore { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("CustomFieldsSearchFormMap")]
        [Validation(Required=false)]
        public string CustomFieldsSearchFormMap { get; set; }

        [NameInMap("ExpectedAtAfter")]
        [Validation(Required=false)]
        public long? ExpectedAtAfter { get; set; }

        [NameInMap("ExpectedAtBefore")]
        [Validation(Required=false)]
        public long? ExpectedAtBefore { get; set; }

        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        [NameInMap("IterationSign")]
        [Validation(Required=false)]
        public string IterationSign { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("Length")]
        [Validation(Required=false)]
        public long? Length { get; set; }

        [NameInMap("ModuleIdsOption")]
        [Validation(Required=false)]
        public string ModuleIdsOption { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ParentProjectSign")]
        [Validation(Required=false)]
        public string ParentProjectSign { get; set; }

        [NameInMap("ParentSign")]
        [Validation(Required=false)]
        public string ParentSign { get; set; }

        [NameInMap("ProjectSign")]
        [Validation(Required=false)]
        public string ProjectSign { get; set; }

        [NameInMap("RelatedProjectSign")]
        [Validation(Required=false)]
        public string RelatedProjectSign { get; set; }

        [NameInMap("RelevantProjectSign")]
        [Validation(Required=false)]
        public string RelevantProjectSign { get; set; }

        [NameInMap("RelevantUid")]
        [Validation(Required=false)]
        public string RelevantUid { get; set; }

        [NameInMap("RootBegin")]
        [Validation(Required=false)]
        public long? RootBegin { get; set; }

        [NameInMap("RootLength")]
        [Validation(Required=false)]
        public long? RootLength { get; set; }

        [NameInMap("ShowMode")]
        [Validation(Required=false)]
        public string ShowMode { get; set; }

        [NameInMap("SignPathNotLike")]
        [Validation(Required=false)]
        public string SignPathNotLike { get; set; }

        [NameInMap("Stamp")]
        [Validation(Required=false)]
        public string Stamp { get; set; }

        [NameInMap("StatusId")]
        [Validation(Required=false)]
        public long? StatusId { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("TagsOption")]
        [Validation(Required=false)]
        public string TagsOption { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("TemplateLabel")]
        [Validation(Required=false)]
        public string TemplateLabel { get; set; }

        [NameInMap("UpdatedAtAfter")]
        [Validation(Required=false)]
        public long? UpdatedAtAfter { get; set; }

        [NameInMap("UpdatedAtBefore")]
        [Validation(Required=false)]
        public long? UpdatedAtBefore { get; set; }

        [NameInMap("AssignedToIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AssignedToIdsRepeatList { get; set; }

        [NameInMap("CcsRepeatList")]
        [Validation(Required=false)]
        public List<string> CcsRepeatList { get; set; }

        [NameInMap("CreatorsRepeatList")]
        [Validation(Required=false)]
        public List<string> CreatorsRepeatList { get; set; }

        [NameInMap("ModuleIdsRepeatList")]
        [Validation(Required=false)]
        public List<int?> ModuleIdsRepeatList { get; set; }

        [NameInMap("PriorityIdsRepeatList")]
        [Validation(Required=false)]
        public List<int?> PriorityIdsRepeatList { get; set; }

        [NameInMap("ProjectSignsRepeatList")]
        [Validation(Required=false)]
        public List<string> ProjectSignsRepeatList { get; set; }

        [NameInMap("SignListRepeatList")]
        [Validation(Required=false)]
        public List<string> SignListRepeatList { get; set; }

        [NameInMap("SignNotInRepeatList")]
        [Validation(Required=false)]
        public List<string> SignNotInRepeatList { get; set; }

        [NameInMap("StageListRepeatList")]
        [Validation(Required=false)]
        public List<int?> StageListRepeatList { get; set; }

        [NameInMap("StampsRepeatList")]
        [Validation(Required=false)]
        public List<string> StampsRepeatList { get; set; }

        [NameInMap("StatusIdsRepeatList")]
        [Validation(Required=false)]
        public List<int?> StatusIdsRepeatList { get; set; }

        [NameInMap("TagsRepeatList")]
        [Validation(Required=false)]
        public List<int?> TagsRepeatList { get; set; }

        [NameInMap("TemplateIdsRepeatList")]
        [Validation(Required=false)]
        public List<int?> TemplateIdsRepeatList { get; set; }

        [NameInMap("TemplateLabelsRepeatList")]
        [Validation(Required=false)]
        public List<string> TemplateLabelsRepeatList { get; set; }

    }

}
