// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SubmitOperationAuditInfoRequest : TeaModel {
        /// <summary>
        /// <para>The information to be reviewed. The displayed information varies by business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>个人 {&quot;regType&quot;:1,&quot;registrantName&quot;:&quot;张三&quot;,&quot;registrantNo&quot;:&quot;2201919190**&quot;,&quot;telephone&quot;:&quot;1390123****&quot;,&quot;account&quot;:&quot;<a href="mailto:zhangsan@alimail.com">zhangsan@alimail.com</a>&quot;,&quot;reason&quot;:1,&quot;remark&quot;:&quot;账号丢失&quot;} 企业 {&quot;regType&quot;:2,&quot;registrantName&quot;:&quot;华大信通&quot;,&quot;operatorName&quot;:&quot;王武&quot;,&quot;operatorNo&quot;:&quot;2201811987101901**&quot;,      &quot;operatorPhone&quot;:&quot;1390123****&quot;,&quot;account&quot;:&quot;<a href="mailto:wangwu@alimail.com">wangwu@alimail.com</a>&quot;,&quot;companyNo&quot;:&quot;91361100MA35N6****&quot;,&quot;reason&quot;:2,&quot;remark&quot;:&quot;账号丢失&quot;}</para>
        /// </summary>
        [NameInMap("AuditInfo")]
        [Validation(Required=false)]
        public string AuditInfo { get; set; }

        /// <summary>
        /// <para>The business type. Valid values:</para>
        /// <para><b>1</b>: Transfer a domain name offline, that is, transfer the domain name from the current Alibaba Cloud account to another Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuditType")]
        [Validation(Required=false)]
        public int? AuditType { get; set; }

        /// <summary>
        /// <para>The domain name. You can specify one or more domain names, separated by commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx.com,yyyy.cn</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The review ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the error message returned by the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
