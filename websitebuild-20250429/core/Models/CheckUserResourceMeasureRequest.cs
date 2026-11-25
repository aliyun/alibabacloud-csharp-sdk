// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CheckUserResourceMeasureRequest : TeaModel {
        /// <summary>
        /// <para>The owner ID, which can be a website ID or an Alibaba Cloud user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BelongId")]
        [Validation(Required=false)]
        public string BelongId { get; set; }

        /// <summary>
        /// <para>The owner ID type, such as siteId or uid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("BelongIdType")]
        [Validation(Required=false)]
        public string BelongIdType { get; set; }

        /// <summary>
        /// <para>The ESP business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The desired total for APP_WORKSPACE. This is an optional compatible total with a range of 0 to 100,000. If provided, it takes precedence over ResourceValue and does not repeatedly add the used quota. For new calls, only ResourceValue is required. This field is not used for APP or USER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("DesiredTotal")]
        [Validation(Required=false)]
        public long? DesiredTotal { get; set; }

        /// <summary>
        /// <para>The ESP business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p20202933455</para>
        /// </summary>
        [NameInMap("EspBizId")]
        [Validation(Required=false)]
        public string EspBizId { get; set; }

        /// <summary>
        /// <para>The order component information in JSON format. If this parameter is left empty, EspBizId and BizType cannot be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;siteversion&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("OrderComponentParams")]
        [Validation(Required=false)]
        public string OrderComponentParams { get; set; }

        /// <summary>
        /// <para>The resource code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InspirationTokens</para>
        /// </summary>
        [NameInMap("ResourceCode")]
        [Validation(Required=false)]
        public string ResourceCode { get; set; }

        /// <summary>
        /// <para>The resource value. This parameter is left empty by default and is required only for feature resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Not supported.</description></item>
        /// <item><description>1: Supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceValue")]
        [Validation(Required=false)]
        public long? ResourceValue { get; set; }

    }

}
