// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class SearchProjectsByRegionResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SearchProjectsByRegionResponseBodyData> Data { get; set; }
        public class SearchProjectsByRegionResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("AoneType")]
            [Validation(Required=false)]
            public string AoneType { get; set; }

            [NameInMap("Stamp")]
            [Validation(Required=false)]
            public string Stamp { get; set; }

            [NameInMap("FullName")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            [NameInMap("Icons")]
            [Validation(Required=false)]
            public List<string> Icons { get; set; }

            [NameInMap("IdPath")]
            [Validation(Required=false)]
            public string IdPath { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("AoneId")]
            [Validation(Required=false)]
            public int? AoneId { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public int? ParentId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("CustomFieldMap")]
            [Validation(Required=false)]
            public List<string> CustomFieldMap { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
