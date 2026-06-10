// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CheckResourceMeasureRequest : TeaModel {
        /// <summary>
        /// <para>Belonging ID (site ID or Alibaba Cloud User ID)</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BelongId")]
        [Validation(Required=false)]
        public string BelongId { get; set; }

        /// <summary>
        /// <para>Belonging ID Type (siteId, uid)</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("BelongIdType")]
        [Validation(Required=false)]
        public string BelongIdType { get; set; }

        /// <summary>
        /// <para>ESP business type</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>ESP business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>p20202933455</para>
        /// </summary>
        [NameInMap("EspBizId")]
        [Validation(Required=false)]
        public string EspBizId { get; set; }

        /// <summary>
        /// <para>Order module information (when empty, espBizId and bizType cannot be empty)</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;siteversion&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("OrderComponentParams")]
        [Validation(Required=false)]
        public string OrderComponentParams { get; set; }

        /// <summary>
        /// <para>Resource identity</para>
        /// 
        /// <b>Example:</b>
        /// <para>InspirationTokens</para>
        /// </summary>
        [NameInMap("ResourceCode")]
        [Validation(Required=false)]
        public string ResourceCode { get; set; }

        /// <summary>
        /// <para>Resource value; default is empty. Required only for feature-type resources. 0 indicates not supported, and 1 indicates supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceValue")]
        [Validation(Required=false)]
        public long? ResourceValue { get; set; }

    }

}
