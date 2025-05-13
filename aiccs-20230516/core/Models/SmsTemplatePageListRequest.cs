// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class SmsTemplatePageListRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>页码</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>每页条数</para>
        /// 
        /// <b>Example:</b>
        /// <para>97</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>短信签名</para>
        /// 
        /// <b>Example:</b>
        /// <para>114ah23m</para>
        /// </summary>
        [NameInMap("Sign")]
        [Validation(Required=false)]
        public string Sign { get; set; }

        /// <summary>
        /// <para>短信类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("SmsType")]
        [Validation(Required=false)]
        public long? SmsType { get; set; }

        /// <summary>
        /// <para>模板状态</para>
        /// 
        /// <b>Example:</b>
        /// <para>92</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>模板ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>83</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>模板类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>19</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public long? TemplateType { get; set; }

    }

}
