// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class QueryAvatarListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAvatarListResponseBodyData Data { get; set; }
        public class QueryAvatarListResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryAvatarListResponseBodyDataList> List { get; set; }
            public class QueryAvatarListResponseBodyDataList : TeaModel {
                [NameInMap("AvatarType")]
                [Validation(Required=false)]
                public string AvatarType { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

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
                public QueryAvatarListResponseBodyDataListSupportedResolutions SupportedResolutions { get; set; }
                public class QueryAvatarListResponseBodyDataListSupportedResolutions : TeaModel {
                    [NameInMap("Offline")]
                    [Validation(Required=false)]
                    public List<QueryAvatarListResponseBodyDataListSupportedResolutionsOffline> Offline { get; set; }
                    public class QueryAvatarListResponseBodyDataListSupportedResolutionsOffline : TeaModel {
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
                    public List<QueryAvatarListResponseBodyDataListSupportedResolutionsOnline> Online { get; set; }
                    public class QueryAvatarListResponseBodyDataListSupportedResolutionsOnline : TeaModel {
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

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

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
