// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class ListRepositoryCodeRequest : TeaModel {
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public ListRepositoryCodeRequestFilePath FilePath { get; set; }
        public class ListRepositoryCodeRequestFilePath : TeaModel {
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("IsCodeBlock")]
        [Validation(Required=false)]
        public bool? IsCodeBlock { get; set; }

        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RepositoryPath")]
        [Validation(Required=false)]
        public ListRepositoryCodeRequestRepositoryPath RepositoryPath { get; set; }
        public class ListRepositoryCodeRequestRepositoryPath : TeaModel {
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
