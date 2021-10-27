// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class MyCatCustomImportPreCheckRequest : TeaModel {
        [NameInMap("DstDbNme")]
        [Validation(Required=false)]
        public string DstDbNme { get; set; }

        [NameInMap("DstDrdsInstanceId")]
        [Validation(Required=false)]
        public string DstDrdsInstanceId { get; set; }

        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public int? DstPort { get; set; }

        [NameInMap("DstPwd")]
        [Validation(Required=false)]
        public string DstPwd { get; set; }

        [NameInMap("DstUser")]
        [Validation(Required=false)]
        public string DstUser { get; set; }

        [NameInMap("ImportDb")]
        [Validation(Required=false)]
        public string ImportDb { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RuleUrl")]
        [Validation(Required=false)]
        public string RuleUrl { get; set; }

        [NameInMap("SchemaUrl")]
        [Validation(Required=false)]
        public string SchemaUrl { get; set; }

        [NameInMap("TableMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> TableMap { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
