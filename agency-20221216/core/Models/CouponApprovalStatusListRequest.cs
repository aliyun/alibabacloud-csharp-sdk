// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CouponApprovalStatusListRequest : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the coupon template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5093156</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test coupon template</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The status of the coupon template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: application revoked</description></item>
        /// <item><description><b>2</b>: under review</description></item>
        /// <item><description><b>3</b>: review rejected</description></item>
        /// <item><description><b>4</b>: review approved</description></item>
        /// <item><description><b>5</b>: review approved but issuance failed</description></item>
        /// <item><description><b>6</b>: automatically approved</description></item>
        /// <item><description><b>7</b>: automatically approved but issuance failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public string TemplateStatus { get; set; }

    }

}
