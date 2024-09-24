// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomEventAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the call was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the custom event.</para>
        /// </summary>
        [NameInMap("CustomEvents")]
        [Validation(Required=false)]
        public DescribeCustomEventAttributeResponseBodyCustomEvents CustomEvents { get; set; }
        public class DescribeCustomEventAttributeResponseBodyCustomEvents : TeaModel {
            [NameInMap("CustomEvent")]
            [Validation(Required=false)]
            public List<DescribeCustomEventAttributeResponseBodyCustomEventsCustomEvent> CustomEvent { get; set; }
            public class DescribeCustomEventAttributeResponseBodyCustomEventsCustomEvent : TeaModel {
                /// <summary>
                /// <para>The content of the custom event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>requestId:4975A6F3-19AC-4C01-BAD2-034DA07FEBB5, info:{&quot;autoPay&quot;:false,&quot;autoUseCoupon&quot;:false,&quot;bid&quot;:&quot;26842&quot;,&quot;buyerId&quot;:118935342242****,&quot;commodities&quot;:[{&quot;aliyunProduceCode&quot;:&quot;cms&quot;,&quot;chargeType&quot;:&quot;PREPAY&quot;,&quot;commodityCode&quot;:&quot;cms_call_num&quot;,&quot;components&quot;:[{&quot;componentCode&quot;:&quot;phone_count&quot;,&quot;instanceProperty&quot;:[{&quot;code&quot;:&quot;phone_count&quot;,&quot;value&quot;:&quot;500&quot;}],&quot;moduleAttrStatus&quot;:1}],&quot;duration&quot;:6,&quot;free&quot;:false,&quot;orderParams&quot;:{&quot;aliyunProduceCode&quot;:&quot;cms&quot;},&quot;orderType&quot;:&quot;BUY&quot;,&quot;prePayPostCharge&quot;:false,&quot;pricingCycle&quot;:&quot;Month&quot;,&quot;quantity&quot;:1,&quot;refundSpecCode&quot;:&quot;&quot;,&quot;renewChange&quot;:false,&quot;specCode&quot;:&quot;cms_call_num&quot;,&quot;specUpdate&quot;:false,&quot;syncToSubscription&quot;:false,&quot;upgradeInquireFinancialValue&quot;:true}],&quot;fromApp&quot;:&quot;commonbuy&quot;,&quot;orderParams&quot;:{&quot;priceCheck&quot;:&quot;true&quot;},&quot;payerId&quot;:118935342242****,&quot;requestId&quot;:&quot;ade3ad32-f58b-45d7-add4-ac542be3d8ec&quot;,&quot;skipChannel&quot;:false,&quot;userId&quot;:118935342242****}</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The ID of the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The ID of the custom event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the custom event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BABEL_CHECK</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The time when the custom event occurred.</para>
                /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1552199984000</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userId:173651113438**** and name:&quot;BABEL_CHECK&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60912C8D-B340-4253-ADE7-61ACDFD25CFC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
