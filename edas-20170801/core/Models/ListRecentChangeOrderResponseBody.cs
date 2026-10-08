// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListRecentChangeOrderResponseBody : TeaModel {
        [NameInMap("ChangeOrderList")]
        [Validation(Required=false)]
        public ListRecentChangeOrderResponseBodyChangeOrderList ChangeOrderList { get; set; }
        public class ListRecentChangeOrderResponseBodyChangeOrderList : TeaModel {
            [NameInMap("ChangeOrder")]
            [Validation(Required=false)]
            public List<ListRecentChangeOrderResponseBodyChangeOrderListChangeOrder> ChangeOrder { get; set; }
            public class ListRecentChangeOrderResponseBodyChangeOrderListChangeOrder : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("BatchCount")]
                [Validation(Required=false)]
                public int? BatchCount { get; set; }

                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                [NameInMap("ChangeOrderDescription")]
                [Validation(Required=false)]
                public string ChangeOrderDescription { get; set; }

                [NameInMap("ChangeOrderId")]
                [Validation(Required=false)]
                public string ChangeOrderId { get; set; }

                [NameInMap("CoType")]
                [Validation(Required=false)]
                public string CoType { get; set; }

                [NameInMap("CoTypeCode")]
                [Validation(Required=false)]
                public string CoTypeCode { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public string CreateUserId { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D16979DC-4D42-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
