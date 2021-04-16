// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class UpdateCdrsMonitorRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("DeviceOperateType")]
        [Validation(Required=false)]
        public string DeviceOperateType { get; set; }

        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public string DeviceList { get; set; }

        [NameInMap("PicOperateType")]
        [Validation(Required=false)]
        public string PicOperateType { get; set; }

        [NameInMap("PicList")]
        [Validation(Required=false)]
        public string PicList { get; set; }

        [NameInMap("AttributeOperateType")]
        [Validation(Required=false)]
        public string AttributeOperateType { get; set; }

        [NameInMap("AttributeName")]
        [Validation(Required=false)]
        public string AttributeName { get; set; }

        [NameInMap("AttributeValueList")]
        [Validation(Required=false)]
        public string AttributeValueList { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RuleExpression")]
        [Validation(Required=false)]
        public string RuleExpression { get; set; }

        [NameInMap("AlgorithmVendor")]
        [Validation(Required=false)]
        public string AlgorithmVendor { get; set; }

        [NameInMap("NotifierType")]
        [Validation(Required=false)]
        public string NotifierType { get; set; }

        [NameInMap("NotifierUrl")]
        [Validation(Required=false)]
        public string NotifierUrl { get; set; }

        [NameInMap("NotifierAppSecret")]
        [Validation(Required=false)]
        public string NotifierAppSecret { get; set; }

        [NameInMap("NotifierTimeOut")]
        [Validation(Required=false)]
        public int? NotifierTimeOut { get; set; }

        [NameInMap("NotifierExtendValues")]
        [Validation(Required=false)]
        public string NotifierExtendValues { get; set; }

    }

}
