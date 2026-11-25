// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetUserTmpIdentityForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>The authorization purpose.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BindDomain</para>
        /// </summary>
        [NameInMap("AuthPurpose")]
        [Validation(Required=false)]
        public string AuthPurpose { get; set; }

        /// <summary>
        /// <para>The customer business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Specifies whether fuzzy match is supported for port numbers. To enable fuzzy match, set this parameter to <b>1</b>. Any other value or an empty value indicates that fuzzy match is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;deliveryNodeName&quot;:&quot;Visual Design Confirmation&quot;,&quot;deliveryNodeStatus&quot;:&quot;Reject&quot;,&quot;deliveryOperatorRole&quot;:&quot;Customer&quot;}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The service-linked role.</para>
        /// <remarks>
        /// <para>For more information about the service-linked roles supported by RDS, see <a href="https://help.aliyun.com/document_detail/342840.html">Service-linked roles</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForSasCspm</para>
        /// </summary>
        [NameInMap("ServiceLinkedRole")]
        [Validation(Required=false)]
        public string ServiceLinkedRole { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231331311</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
