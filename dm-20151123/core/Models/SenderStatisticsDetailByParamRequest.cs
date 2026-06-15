// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsDetailByParamRequest : TeaModel {
        /// <summary>
        /// <para>The sender address. If you leave this parameter empty, emails from all sender addresses are queried.</para>
        /// <remarks>
        /// <para>You can leave <b>AccountName</b>, <b>TagName</b>, and <b>ToAddress</b> empty. You can specify a value for only one of these parameters at a time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s***@example.net</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The ID of the configuration set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95437e39-5433-4c6c-8b66-0c4eac2f4d97</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ConfigSetId")]
        [Validation(Required=false)]
        public string ConfigSetId { get; set; }

        /// <summary>
        /// <para>The end time. The time range between the start time and the end time cannot exceed 30 days. The format is yyyy-MM-dd HH:mm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-29 00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the independent IP address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e42a4d8e-66e0-4ea3-88aa-74c66c661cef</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("IpPoolId")]
        [Validation(Required=false)]
        public string IpPoolId { get; set; }

        /// <summary>
        /// <para>The number of results to return. The value can range from 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>The offset for this request, used for paging. If more results are available, set the \<c>NextStart\\</c> parameter in your next request to this return value.</para>
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
        /// <para>The start time. The time range between the start time and the end time cannot exceed 30 days. The format is yyyy-MM-dd HH:mm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-28 00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The delivery status. If you leave this parameter empty, emails in all delivery statuses are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: delivered successfully</para>
        /// </description></item>
        /// <item><description><para>2: invalid address</para>
        /// </description></item>
        /// <item><description><para>3: spam</para>
        /// </description></item>
        /// <item><description><para>4: failed</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The email tag. If you leave this parameter empty, emails with all tags are queried.
        /// When you send an email using SMTP, specify the \<c>TagName\\</c> and its value for the \<c>X-AliDM-Trace\\</c> field. For more information, see the examples for email tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EmailQuestionnaireHelioscam</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The recipient address. If you leave this parameter empty, emails sent to all recipient addresses are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b***@example.net</para>
        /// </summary>
        [NameInMap("ToAddress")]
        [Validation(Required=false)]
        public string ToAddress { get; set; }

    }

}
