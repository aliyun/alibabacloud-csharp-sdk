// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEipInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The maximum bandwidth of the EIP. Default value: 5. Valid values: 5 to 10000. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>The description of the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-suzhou-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The billing method of the EIP. Set the value to <b>PostPaid</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The metering method of the EIP. Set the value to <b>95BandwidthByMonth</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95BandwidthByMonth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The Internet service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cmcc</b>: China Mobile.</description></item>
        /// <item><description><b>unicom</b>: China Unicom.</description></item>
        /// <item><description><b>telecom</b>: China Telecom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cmcc</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The name of the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EIP1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEipInstanceRequestTag> Tag { get; set; }
        public class CreateEipInstanceRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
