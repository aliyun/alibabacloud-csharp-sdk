// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class QueryAvatarResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAvatarResponseBodyData Data { get; set; }
        public class QueryAvatarResponseBodyData : TeaModel {
            [NameInMap("AvatarType")]
            [Validation(Required=false)]
            public string AvatarType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("MakeFailReason")]
            [Validation(Required=false)]
            public string MakeFailReason { get; set; }

            [NameInMap("MakeStatus")]
            [Validation(Required=false)]
            public string MakeStatus { get; set; }

            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Portrait")]
            [Validation(Required=false)]
            public string Portrait { get; set; }

            [NameInMap("SupportedResolutions")]
            [Validation(Required=false)]
            public QueryAvatarResponseBodyDataSupportedResolutions SupportedResolutions { get; set; }
            public class QueryAvatarResponseBodyDataSupportedResolutions : TeaModel {
                [NameInMap("Offline")]
                [Validation(Required=false)]
                public List<QueryAvatarResponseBodyDataSupportedResolutionsOffline> Offline { get; set; }
                public class QueryAvatarResponseBodyDataSupportedResolutionsOffline : TeaModel {
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                [NameInMap("Online")]
                [Validation(Required=false)]
                public List<QueryAvatarResponseBodyDataSupportedResolutionsOnline> Online { get; set; }
                public class QueryAvatarResponseBodyDataSupportedResolutionsOnline : TeaModel {
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
