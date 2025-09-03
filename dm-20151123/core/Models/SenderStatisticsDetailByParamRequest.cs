// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsDetailByParamRequest : TeaModel {
        /// <summary>
        /// <para>Sending address. If not filled, it represents all addresses.</para>
        /// <remarks>
        /// <para><b>AccountName</b>, <b>TagName</b>, and <b>ToAddress</b> can all be left unfilled. If any are filled, only one of these parameters can be passed; you cannot pass a combination of two or more.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s***@example.net</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ConfigSetId")]
        [Validation(Required=false)]
        public string ConfigSetId { get; set; }

        /// <summary>
        /// <para>End time. The span between start and end times cannot exceed 30 days, format: yyyy-MM-dd HH:mm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-29 00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("IpPoolId")]
        [Validation(Required=false)]
        public string IpPoolId { get; set; }

        /// <summary>
        /// <para>Specifies the number of results to return in this request. Range is 1~100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>Used for pagination. Specifies the offset for this request. If there are more results, set this returned value to the NextStart in the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90f0243616#203#a***@example.net-1658817837#a***@example.net.247475288187</para>
        /// </summary>
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Start time. The span between start and end times cannot exceed 30 days, format: yyyy-MM-dd HH:mm</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-28 00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Delivery result. If not filled, it represents all statuses. Values:</para>
        /// <list type="bullet">
        /// <item><description>0: Success</description></item>
        /// <item><description>2: Invalid Address</description></item>
        /// <item><description>3: Spam</description></item>
        /// <item><description>4: Failure</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Email tag. If not filled, it represents all tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EmailQuestionnaireHelioscam</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>Recipient address. If not filled, it represents all recipient addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b***@example.net</para>
        /// </summary>
        [NameInMap("ToAddress")]
        [Validation(Required=false)]
        public string ToAddress { get; set; }

    }

}
