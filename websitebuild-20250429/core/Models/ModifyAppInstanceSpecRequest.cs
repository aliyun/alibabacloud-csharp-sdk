// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModifyAppInstanceSpecRequest : TeaModel {
        /// <summary>
        /// <para>The application type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a unique value from your client. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2108341e17661121129745384e79f9</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The deployment region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HongKong</para>
        /// </summary>
        [NameInMap("DeployArea")]
        [Validation(Required=false)]
        public string DeployArea { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;deliveryNodeName\&quot;:\&quot;网站验收\&quot;,\&quot;deliveryNodeStatus\&quot;:\&quot;Reject\&quot;,\&quot;deliveryOperatorRole\&quot;:\&quot;Customer\&quot;}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The payment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The website version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public string SiteVersion { get; set; }

    }

}
