// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CheckResourceMeasureRequest : TeaModel {
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
        /// <para>The owner ID type. Valid values: siteId and uid.</para>
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
        /// <para>This parameter is used only for APP_WORKSPACE. It specifies the final total amount of issues or competitors after editing. For legacy APP or USER, it retains the incremental semantics of ResourceValue.</para>
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
        /// <para>The order component parameters. If this parameter is empty, EspBizId and BizType cannot be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;siteversion&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("OrderComponentParams")]
        [Validation(Required=false)]
        public string OrderComponentParams { get; set; }

        /// <summary>
        /// <para>The resource identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InspirationTokens</para>
        /// </summary>
        [NameInMap("ResourceCode")]
        [Validation(Required=false)]
        public string ResourceCode { get; set; }

        /// <summary>
        /// <para>The resource value. This parameter is required only for feature resources and is empty by default. Valid values:</para>
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
