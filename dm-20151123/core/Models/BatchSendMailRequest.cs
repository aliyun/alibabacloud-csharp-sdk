// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class BatchSendMailRequest : TeaModel {
        /// <summary>
        /// <para>The sending address configured in the management console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.com">test@example.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>0: Random account</description></item>
        /// <item><description>1: Sending address</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public int? AddressType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>1: Enable data tracking function</description></item>
        /// <item><description>0 (default): Disable data tracking function</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ClickTrace")]
        [Validation(Required=false)]
        public string ClickTrace { get; set; }

        /// <summary>
        /// <para>Currently, the standard fields that can be added to the email header are Message-ID, List-Unsubscribe, and List-Unsubscribe-Post. Standard fields will overwrite the existing values in the email header, while non-standard fields need to start with X-User- and will be appended to the email header. Currently, up to 10 headers can be passed in JSON format, and both standard and non-standard fields must comply with the syntax requirements for headers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Message-ID&quot;: &quot;<a href="mailto:msg0001@example.com">msg0001@example.com</a>&quot;,
        ///   &quot;X-User-UID1&quot;: &quot;UID-1-000001&quot;,
        ///   &quot;X-User-UID2&quot;: &quot;UID-2-000001&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string Headers { get; set; }

        [NameInMap("IpPoolId")]
        [Validation(Required=false)]
        public string IpPoolId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the recipient list that has been created and uploaded. Note: The recipient list should not be deleted until at least 10 minutes after the task is triggered, otherwise it may cause sending failure.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2</para>
        /// </summary>
        [NameInMap("ReceiversName")]
        [Validation(Required=false)]
        public string ReceiversName { get; set; }

        /// <summary>
        /// <para>Reply address</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2***@example.net</para>
        /// </summary>
        [NameInMap("ReplyAddress")]
        [Validation(Required=false)]
        public string ReplyAddress { get; set; }

        /// <summary>
        /// <para>Alias for the reply address</para>
        /// 
        /// <b>Example:</b>
        /// <para>Lucy</para>
        /// </summary>
        [NameInMap("ReplyAddressAlias")]
        [Validation(Required=false)]
        public string ReplyAddressAlias { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Email tag name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test3</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The name of a pre-created and approved template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>Filter level. Refer to the <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe Function Link Generation and Filtering Mechanism</a> document.</para>
        /// <list type="bullet">
        /// <item><description>disabled: No filtering</description></item>
        /// <item><description>default: Use the default strategy, bulk addresses use sender address level filtering</description></item>
        /// <item><description>mailfrom: Sender address level filtering</description></item>
        /// <item><description>mailfrom_domain: Sender domain level filtering</description></item>
        /// <item><description>edm_id: Account level filtering</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mailfrom_domain</para>
        /// </summary>
        [NameInMap("UnSubscribeFilterLevel")]
        [Validation(Required=false)]
        public string UnSubscribeFilterLevel { get; set; }

        /// <summary>
        /// <para>Type of generated unsubscribe link. Refer to the <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe Function Link Generation and Filtering Mechanism</a> document.</para>
        /// <list type="bullet">
        /// <item><description>disabled: Not generated</description></item>
        /// <item><description>default: Use the default strategy: Generate an unsubscribe link when sending from a bulk email address to specific domains, such as those containing keywords like &quot;gmail&quot;, &quot;yahoo&quot;,
        /// &quot;google&quot;, &quot;aol.com&quot;, &quot;hotmail&quot;,
        /// &quot;outlook&quot;, &quot;ymail.com&quot;, etc.</description></item>
        /// <item><description>zh-cn: Generated, for future content preparation</description></item>
        /// <item><description>en-us: Generated, for future content preparation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("UnSubscribeLinkType")]
        [Validation(Required=false)]
        public string UnSubscribeLinkType { get; set; }

    }

}
