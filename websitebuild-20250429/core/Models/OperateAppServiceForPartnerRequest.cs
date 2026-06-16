// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class OperateAppServiceForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS00001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Other extended information in JSON format for future parameter expansion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;user_device_id\&quot;:\&quot;6bef45cb0c76de284d24de074c088b73\&quot;}\n</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The operation event. Valid values:
        /// SERVICE_FINISH: the service is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SERVICE_FINISH</para>
        /// </summary>
        [NameInMap("OperateEvent")]
        [Validation(Required=false)]
        public string OperateEvent { get; set; }

        /// <summary>
        /// <para>The service type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>private: deployment under the user account.</para>
        /// </description></item>
        /// <item><description><para>managed: hosted under the service provider account.</para>
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
