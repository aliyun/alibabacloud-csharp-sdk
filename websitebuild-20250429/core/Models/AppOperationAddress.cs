// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppOperationAddress : TeaModel {
        /// <summary>
        /// <para>The operation button list.</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<AppOperateAction> Actions { get; set; }

        /// <summary>
        /// <para>The customer service design URL.</para>
        /// </summary>
        [NameInMap("AiCustomerConfigUrl")]
        [Validation(Required=false)]
        public string AiCustomerConfigUrl { get; set; }

        /// <summary>
        /// <para>The AI design URL.</para>
        /// </summary>
        [NameInMap("AiDesignUrl")]
        [Validation(Required=false)]
        public string AiDesignUrl { get; set; }

        /// <summary>
        /// <para>The application publishing URL.</para>
        /// </summary>
        [NameInMap("AppPublishUrl")]
        [Validation(Required=false)]
        public string AppPublishUrl { get; set; }

        /// <summary>
        /// <para>The overview page operation button list.</para>
        /// </summary>
        [NameInMap("DashboardActions")]
        [Validation(Required=false)]
        public List<AppOperateAction> DashboardActions { get; set; }

        /// <summary>
        /// <para>The professional design URL.</para>
        /// </summary>
        [NameInMap("DesignUrl")]
        [Validation(Required=false)]
        public string DesignUrl { get; set; }

        /// <summary>
        /// <para>The application instance logon URL.</para>
        /// </summary>
        [NameInMap("InstanceLoginUrl")]
        [Validation(Required=false)]
        public string InstanceLoginUrl { get; set; }

        /// <summary>
        /// <para>The renewal purchase URL.</para>
        /// </summary>
        [NameInMap("RenewBuyUrl")]
        [Validation(Required=false)]
        public string RenewBuyUrl { get; set; }

        /// <summary>
        /// <para>The service delivery URL.</para>
        /// </summary>
        [NameInMap("ServerDeliveryUrl")]
        [Validation(Required=false)]
        public string ServerDeliveryUrl { get; set; }

        /// <summary>
        /// <para>The upgrade purchase URL.</para>
        /// </summary>
        [NameInMap("UpgradeBuyUrl")]
        [Validation(Required=false)]
        public string UpgradeBuyUrl { get; set; }

    }

}
