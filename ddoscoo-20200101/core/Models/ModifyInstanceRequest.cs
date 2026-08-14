// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyInstanceRequest : TeaModel {
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        [NameInMap("BaseBandwidth")]
        [Validation(Required=false)]
        public string BaseBandwidth { get; set; }

        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public string DomainCount { get; set; }

        [NameInMap("EditionSale")]
        [Validation(Required=false)]
        public string EditionSale { get; set; }

        [NameInMap("FunctionVersion")]
        [Validation(Required=false)]
        public string FunctionVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("NormalBandwidth")]
        [Validation(Required=false)]
        public string NormalBandwidth { get; set; }

        [NameInMap("NormalQps")]
        [Validation(Required=false)]
        public string NormalQps { get; set; }

        [NameInMap("PortCount")]
        [Validation(Required=false)]
        public string PortCount { get; set; }

        [NameInMap("ProductPlan")]
        [Validation(Required=false)]
        public string ProductPlan { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("ServiceBandwidth")]
        [Validation(Required=false)]
        public string ServiceBandwidth { get; set; }

        [NameInMap("ServicePartner")]
        [Validation(Required=false)]
        public string ServicePartner { get; set; }

    }

}
