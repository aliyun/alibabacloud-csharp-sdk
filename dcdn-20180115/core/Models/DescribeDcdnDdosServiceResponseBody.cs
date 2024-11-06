// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDdosServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the renewed service takes effect. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        /// <summary>
        /// <para>The metering method after the configuration changes Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByBandwidth</b></description></item>
        /// <item><description><b>PayByTraffic</b></description></item>
        /// <item><description><b>PayByBandwidth95</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("ChangingChargeType")]
        [Validation(Required=false)]
        public string ChangingChargeType { get; set; }

        /// <summary>
        /// <para>The number of protected domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ChangingDomianNum")]
        [Validation(Required=false)]
        public int? ChangingDomianNum { get; set; }

        /// <summary>
        /// <para>The protection edition for which the configuration changes take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>poc</b>: POC Edition</description></item>
        /// <item><description><b>basic</b>: Basic Edition</description></item>
        /// <item><description><b>insurance</b>: Insurance Edition</description></item>
        /// <item><description><b>unlimited</b>: Unlimited Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("ChangingEdition")]
        [Validation(Required=false)]
        public string ChangingEdition { get; set; }

        /// <summary>
        /// <para>The number of mitigation sessions with configuration changes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ChangingProtectNum")]
        [Validation(Required=false)]
        public int? ChangingProtectNum { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByBandwidth</b></description></item>
        /// <item><description><b>PayByTraffic</b></description></item>
        /// <item><description><b>PayByBandwidth95</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The number of protected domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DomianNum")]
        [Validation(Required=false)]
        public int? DomianNum { get; set; }

        /// <summary>
        /// <para>The protection edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>poc</b>: POC Edition</description></item>
        /// <item><description><b>basic</b>: Basic Edition</description></item>
        /// <item><description><b>insurance</b>: Insurance Edition</description></item>
        /// <item><description><b>unlimited</b>: Unlimited Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>poc</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The activation status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public string Enabled { get; set; }

        /// <summary>
        /// <para>The service expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-26T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndingTime")]
        [Validation(Required=false)]
        public string EndingTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-12345</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The time when the service was enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-26T16:00:00Z</para>
        /// </summary>
        [NameInMap("OpeningTime")]
        [Validation(Required=false)]
        public string OpeningTime { get; set; }

        /// <summary>
        /// <para>The number of mitigation sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProtectNum")]
        [Validation(Required=false)]
        public int? ProtectNum { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b></description></item>
        /// <item><description><b>WaitForExpire</b></description></item>
        /// <item><description><b>expired</b></description></item>
        /// <item><description><b>Released</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
