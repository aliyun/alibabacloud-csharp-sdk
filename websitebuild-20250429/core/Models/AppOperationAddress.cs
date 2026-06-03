// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppOperationAddress : TeaModel {
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<AppOperateAction> Actions { get; set; }

        [NameInMap("AiCustomerConfigUrl")]
        [Validation(Required=false)]
        public string AiCustomerConfigUrl { get; set; }

        [NameInMap("AiDesignUrl")]
        [Validation(Required=false)]
        public string AiDesignUrl { get; set; }

        [NameInMap("AppPublishUrl")]
        [Validation(Required=false)]
        public string AppPublishUrl { get; set; }

        [NameInMap("DashboardActions")]
        [Validation(Required=false)]
        public List<AppOperateAction> DashboardActions { get; set; }

        [NameInMap("DesignUrl")]
        [Validation(Required=false)]
        public string DesignUrl { get; set; }

        [NameInMap("InstanceLoginUrl")]
        [Validation(Required=false)]
        public string InstanceLoginUrl { get; set; }

        [NameInMap("RenewBuyUrl")]
        [Validation(Required=false)]
        public string RenewBuyUrl { get; set; }

        [NameInMap("ServerDeliveryUrl")]
        [Validation(Required=false)]
        public string ServerDeliveryUrl { get; set; }

        [NameInMap("UpgradeBuyUrl")]
        [Validation(Required=false)]
        public string UpgradeBuyUrl { get; set; }

    }

}
