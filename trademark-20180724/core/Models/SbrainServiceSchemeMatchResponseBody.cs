// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class SbrainServiceSchemeMatchResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SbrainServiceSchemeMatchResponseBodyData Data { get; set; }
        public class SbrainServiceSchemeMatchResponseBodyData : TeaModel {
            [NameInMap("SceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            [NameInMap("SchemeContent")]
            [Validation(Required=false)]
            public SbrainServiceSchemeMatchResponseBodyDataSchemeContent SchemeContent { get; set; }
            public class SbrainServiceSchemeMatchResponseBodyDataSchemeContent : TeaModel {
                [NameInMap("ContentIndex")]
                [Validation(Required=false)]
                public int? ContentIndex { get; set; }

                [NameInMap("ContentModules")]
                [Validation(Required=false)]
                public List<SbrainServiceSchemeMatchResponseBodyDataSchemeContentContentModules> ContentModules { get; set; }
                public class SbrainServiceSchemeMatchResponseBodyDataSchemeContentContentModules : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    [NameInMap("action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    [NameInMap("moduleData")]
                    [Validation(Required=false)]
                    public string ModuleData { get; set; }

                    [NameInMap("moduleDataSource")]
                    [Validation(Required=false)]
                    public string ModuleDataSource { get; set; }

                    [NameInMap("moduleDataSourceType")]
                    [Validation(Required=false)]
                    public string ModuleDataSourceType { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                }

                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

            }

            [NameInMap("SchemeId")]
            [Validation(Required=false)]
            public long? SchemeId { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
