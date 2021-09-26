// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateViewRequest : TeaModel {
        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

        [NameInMap("SelectColumn")]
        [Validation(Required=false)]
        public string SelectColumn { get; set; }

        [NameInMap("SelectTableName")]
        [Validation(Required=false)]
        public string SelectTableName { get; set; }

        [NameInMap("SelectWhere")]
        [Validation(Required=false)]
        public string SelectWhere { get; set; }

        [NameInMap("SelectSQL")]
        [Validation(Required=false)]
        public string SelectSQL { get; set; }

        [NameInMap("AppGuid")]
        [Validation(Required=false)]
        public string AppGuid { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ViewColumn")]
        [Validation(Required=false)]
        public List<CreateViewRequestViewColumn> ViewColumn { get; set; }
        public class CreateViewRequestViewColumn : TeaModel {
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

        }

    }

}
