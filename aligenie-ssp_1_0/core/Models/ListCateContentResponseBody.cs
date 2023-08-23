// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListCateContentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListCateContentResponseBodyResult Result { get; set; }
        public class ListCateContentResponseBodyResult : TeaModel {
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            [NameInMap("OpenDataItemList")]
            [Validation(Required=false)]
            public List<ListCateContentResponseBodyResultOpenDataItemList> OpenDataItemList { get; set; }
            public class ListCateContentResponseBodyResultOpenDataItemList : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public List<string> Alias { get; set; }

                [NameInMap("Audition")]
                [Validation(Required=false)]
                public bool? Audition { get; set; }

                [NameInMap("Authors")]
                [Validation(Required=false)]
                public List<ListCateContentResponseBodyResultOpenDataItemListAuthors> Authors { get; set; }
                public class ListCateContentResponseBodyResultOpenDataItemListAuthors : TeaModel {
                    [NameInMap("AuthorTypes")]
                    [Validation(Required=false)]
                    public List<string> AuthorTypes { get; set; }

                    [NameInMap("Cover")]
                    [Validation(Required=false)]
                    public ListCateContentResponseBodyResultOpenDataItemListAuthorsCover Cover { get; set; }
                    public class ListCateContentResponseBodyResultOpenDataItemListAuthorsCover : TeaModel {
                        [NameInMap("CanResize")]
                        [Validation(Required=false)]
                        public bool? CanResize { get; set; }

                        [NameInMap("Img")]
                        [Validation(Required=false)]
                        public string Img { get; set; }

                        [NameInMap("Large")]
                        [Validation(Required=false)]
                        public string Large { get; set; }

                        [NameInMap("Mediam")]
                        [Validation(Required=false)]
                        public string Mediam { get; set; }

                        [NameInMap("Medium")]
                        [Validation(Required=false)]
                        public string Medium { get; set; }

                        [NameInMap("Small")]
                        [Validation(Required=false)]
                        public string Small { get; set; }

                    }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Gender")]
                    [Validation(Required=false)]
                    public string Gender { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public bool? Online { get; set; }

                    [NameInMap("RawId")]
                    [Validation(Required=false)]
                    public string RawId { get; set; }

                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Charge")]
                [Validation(Required=false)]
                public bool? Charge { get; set; }

                [NameInMap("CommCateId")]
                [Validation(Required=false)]
                public string CommCateId { get; set; }

                [NameInMap("Cover")]
                [Validation(Required=false)]
                public ListCateContentResponseBodyResultOpenDataItemListCover Cover { get; set; }
                public class ListCateContentResponseBodyResultOpenDataItemListCover : TeaModel {
                    [NameInMap("Img")]
                    [Validation(Required=false)]
                    public string Img { get; set; }

                    [NameInMap("Large")]
                    [Validation(Required=false)]
                    public string Large { get; set; }

                    [NameInMap("Mediam")]
                    [Validation(Required=false)]
                    public string Mediam { get; set; }

                    [NameInMap("Medium")]
                    [Validation(Required=false)]
                    public string Medium { get; set; }

                    [NameInMap("Small")]
                    [Validation(Required=false)]
                    public string Small { get; set; }

                    [NameInMap("canResize")]
                    [Validation(Required=false)]
                    public bool? CanResize { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HotScore")]
                [Validation(Required=false)]
                public double? HotScore { get; set; }

                [NameInMap("ItemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                [NameInMap("RawId")]
                [Validation(Required=false)]
                public string RawId { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Valid")]
                [Validation(Required=false)]
                public string Valid { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

    }

}
