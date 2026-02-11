// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ListCouponUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>接口状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>返回数据</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCouponUsageResponseBodyData> Data { get; set; }
        public class ListCouponUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>阿里云账号</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:oqevfbveuadcrduzmf@ttirv.net">oqevfbveuadcrduzmf@ttirv.net</a></para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>优惠券面额</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public double? Amount { get; set; }

            /// <summary>
            /// <para>余额</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("Balance")]
            [Validation(Required=false)]
            public double? Balance { get; set; }

            /// <summary>
            /// <para>优惠券id</para>
            /// 
            /// <b>Example:</b>
            /// <para>59226280</para>
            /// </summary>
            [NameInMap("CouponId")]
            [Validation(Required=false)]
            public string CouponId { get; set; }

            /// <summary>
            /// <para>优惠券模版id</para>
            /// 
            /// <b>Example:</b>
            /// <para>503802</para>
            /// </summary>
            [NameInMap("CouponTemplateId")]
            [Validation(Required=false)]
            public long? CouponTemplateId { get; set; }

            /// <summary>
            /// <para>优惠券有效期</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-06 00:00:00 ~ 2023-04-07 00:00:00</para>
            /// </summary>
            [NameInMap("EffDate")]
            [Validation(Required=false)]
            public string EffDate { get; set; }

            /// <summary>
            /// <para>优惠券发放时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-06 19:32:10</para>
            /// </summary>
            [NameInMap("PublishDate")]
            [Validation(Required=false)]
            public string PublishDate { get; set; }

            /// <summary>
            /// <para>优惠券状态 </br>
            /// AVAILABLE 正常 </br>
            /// EXHAUSTED 已用完 </br>
            /// EXPIRED 已过期 </br>
            /// ABANDONED 已作废 </br></para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>二级分销商Uid</para>
            /// 
            /// <b>Example:</b>
            /// <para>5248516956402795</para>
            /// </summary>
            [NameInMap("T2PartnerUid")]
            [Validation(Required=false)]
            public string T2PartnerUid { get; set; }

            /// <summary>
            /// <para>阿里云uid</para>
            /// 
            /// <b>Example:</b>
            /// <para>1647668856741998</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

        }

        /// <summary>
        /// <para>接口返回提示信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>分页信息</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCouponUsageResponseBodyPageInfo PageInfo { get; set; }
        public class ListCouponUsageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>分页，当前页</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>分页，每页数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>分页，总量</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>接口请求id返回问题提供查询使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
