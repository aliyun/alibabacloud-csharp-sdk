// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadMessageContentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReadMessageContentResponseBodyData Data { get; set; }
        public class ReadMessageContentResponseBodyData : TeaModel {
            [NameInMap("Datas")]
            [Validation(Required=false)]
            public ReadMessageContentResponseBodyDataDatas Datas { get; set; }
            public class ReadMessageContentResponseBodyDataDatas : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<ReadMessageContentResponseBodyDataDatasItem> Item { get; set; }
                public class ReadMessageContentResponseBodyDataDatasItem : TeaModel {
                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    [NameInMap("ClassId")]
                    [Validation(Required=false)]
                    public long? ClassId { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public int? Deleted { get; set; }

                    [NameInMap("GmtCreated")]
                    [Validation(Required=false)]
                    public long? GmtCreated { get; set; }

                    [NameInMap("GmtUpdate")]
                    [Validation(Required=false)]
                    public long? GmtUpdate { get; set; }

                    [NameInMap("MassId")]
                    [Validation(Required=false)]
                    public long? MassId { get; set; }

                    [NameInMap("Memo")]
                    [Validation(Required=false)]
                    public string Memo { get; set; }

                    [NameInMap("MsgId")]
                    [Validation(Required=false)]
                    public long? MsgId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("LastItem")]
                [Validation(Required=false)]
                public List<ReadMessageContentResponseBodyDataDatasLastItem> LastItem { get; set; }
                public class ReadMessageContentResponseBodyDataDatasLastItem : TeaModel {
                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    [NameInMap("ClassId")]
                    [Validation(Required=false)]
                    public long? ClassId { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public int? Deleted { get; set; }

                    [NameInMap("GmtCreated")]
                    [Validation(Required=false)]
                    public long? GmtCreated { get; set; }

                    [NameInMap("GmtUpdate")]
                    [Validation(Required=false)]
                    public long? GmtUpdate { get; set; }

                    [NameInMap("MassId")]
                    [Validation(Required=false)]
                    public long? MassId { get; set; }

                    [NameInMap("Memo")]
                    [Validation(Required=false)]
                    public string Memo { get; set; }

                    [NameInMap("MsgId")]
                    [Validation(Required=false)]
                    public long? MsgId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("NextItem")]
                [Validation(Required=false)]
                public List<ReadMessageContentResponseBodyDataDatasNextItem> NextItem { get; set; }
                public class ReadMessageContentResponseBodyDataDatasNextItem : TeaModel {
                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    [NameInMap("ClassId")]
                    [Validation(Required=false)]
                    public long? ClassId { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public int? Deleted { get; set; }

                    [NameInMap("GmtCreated")]
                    [Validation(Required=false)]
                    public long? GmtCreated { get; set; }

                    [NameInMap("GmtUpdate")]
                    [Validation(Required=false)]
                    public long? GmtUpdate { get; set; }

                    [NameInMap("MassId")]
                    [Validation(Required=false)]
                    public long? MassId { get; set; }

                    [NameInMap("Memo")]
                    [Validation(Required=false)]
                    public string Memo { get; set; }

                    [NameInMap("MsgId")]
                    [Validation(Required=false)]
                    public long? MsgId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

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
