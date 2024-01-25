// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class DescribeBindersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("EslItemBindInfos")]
        [Validation(Required=false)]
        public List<DescribeBindersResponseBodyEslItemBindInfos> EslItemBindInfos { get; set; }
        public class DescribeBindersResponseBodyEslItemBindInfos : TeaModel {
            [NameInMap("ActionPrice")]
            [Validation(Required=false)]
            public string ActionPrice { get; set; }

            [NameInMap("BePromotion")]
            [Validation(Required=false)]
            public bool? BePromotion { get; set; }

            [NameInMap("BindId")]
            [Validation(Required=false)]
            public string BindId { get; set; }

            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            [NameInMap("EslBarCode")]
            [Validation(Required=false)]
            public string EslBarCode { get; set; }

            [NameInMap("EslConnectAp")]
            [Validation(Required=false)]
            public string EslConnectAp { get; set; }

            [NameInMap("EslModel")]
            [Validation(Required=false)]
            public string EslModel { get; set; }

            [NameInMap("EslPic")]
            [Validation(Required=false)]
            public string EslPic { get; set; }

            [NameInMap("EslStatus")]
            [Validation(Required=false)]
            public string EslStatus { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("ItemBarCode")]
            [Validation(Required=false)]
            public string ItemBarCode { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("ItemShortTitle")]
            [Validation(Required=false)]
            public string ItemShortTitle { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public string OriginalPrice { get; set; }

            [NameInMap("PriceUnit")]
            [Validation(Required=false)]
            public string PriceUnit { get; set; }

            [NameInMap("PromotionEnd")]
            [Validation(Required=false)]
            public string PromotionEnd { get; set; }

            [NameInMap("PromotionStart")]
            [Validation(Required=false)]
            public string PromotionStart { get; set; }

            [NameInMap("PromotionText")]
            [Validation(Required=false)]
            public string PromotionText { get; set; }

            /// <summary>
            /// SkuID。
            /// </summary>
            [NameInMap("SkuId")]
            [Validation(Required=false)]
            public string SkuId { get; set; }

            [NameInMap("StoreId")]
            [Validation(Required=false)]
            public string StoreId { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateSceneId")]
            [Validation(Required=false)]
            public string TemplateSceneId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
