// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ipv4</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BaseBandwidth")]
        [Validation(Required=false)]
        public string BaseBandwidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public string DomainCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>coop</para>
        /// </summary>
        [NameInMap("EditionSale")]
        [Validation(Required=false)]
        public string EditionSale { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FunctionVersion")]
        [Validation(Required=false)]
        public string FunctionVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-6ja1y6p5****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("NormalBandwidth")]
        [Validation(Required=false)]
        public string NormalBandwidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NormalQps")]
        [Validation(Required=false)]
        public string NormalQps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PortCount")]
        [Validation(Required=false)]
        public string PortCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ProductPlan")]
        [Validation(Required=false)]
        public string ProductPlan { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ServiceBandwidth")]
        [Validation(Required=false)]
        public string ServiceBandwidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>coop-line-001</para>
        /// </summary>
        [NameInMap("ServicePartner")]
        [Validation(Required=false)]
        public string ServicePartner { get; set; }

    }

}
