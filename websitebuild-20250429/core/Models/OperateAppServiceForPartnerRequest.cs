// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class OperateAppServiceForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>Business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS00001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Additional extension information in JSON structure, facilitating future parameter extensions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;user_device_id\&quot;:\&quot;6bef45cb0c76de284d24de074c088b73\&quot;}\n</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>Operation event:<br>SERVICE_FINISH: Service completed</para>
        /// 
        /// <b>Example:</b>
        /// <para>SERVICE_FINISH</para>
        /// </summary>
        [NameInMap("OperateEvent")]
        [Validation(Required=false)]
        public string OperateEvent { get; set; }

        /// <summary>
        /// <para>Service Type.  </para>
        /// <para>Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><para>private: Deployed under the user\&quot;s account.  </para>
        /// </description></item>
        /// <item><description><para>managed: Hosted under the service provider\&quot;s account.  </para>
        /// </description></item>
        /// <item><description><para>operation: Alibaba Cloud Managed Services.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSITE_DESIGN</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
