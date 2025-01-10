// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsDetailByParamRequest : TeaModel {
        /// <summary>
        /// <para>Sending address. Not filled in represents all addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s***@example.net</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The end time. The difference between the start time and the end time cannot exceed 30 days. Format: yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-29 00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of entries to return in the request. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>The start position of the next page. The offset for the request. If you want to obtain more records, specify the return value of the NextStart parameter for this parameter.</para>
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
        /// <para>The start time. The start time can be up to 30 days earlier than the current time. Format: yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-28 00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The delivery status. If you leave this parameter empty, all states are included. Valid values: 0: successful, 2 invalid email address, 3: spam, and 4: failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The email tag. If you leave this parameter empty, all email tags are included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EmailQuestionnaireHelioscam</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The recipient address. If you leave this parameter empty, all recipient addresses are included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b***@example.net</para>
        /// </summary>
        [NameInMap("ToAddress")]
        [Validation(Required=false)]
        public string ToAddress { get; set; }

    }

}
