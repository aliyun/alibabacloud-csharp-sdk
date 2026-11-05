// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogShipperStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The log delivery status collection.</para>
        /// </summary>
        [NameInMap("LogShipperStatus")]
        [Validation(Required=false)]
        public DescribeLogShipperStatusResponseBodyLogShipperStatus LogShipperStatus { get; set; }
        public class DescribeLogShipperStatusResponseBodyLogShipperStatus : TeaModel {
            /// <summary>
            /// <para>The service authorization status of the log analysis feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b>: Authorized.</description></item>
            /// <item><description><b>no</b>: Not authorized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public string AuthStatus { get; set; }

            /// <summary>
            /// <para>The purchase status of the log analysis feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b>: Purchased.</description></item>
            /// <item><description><b>no</b>: Not purchased.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("BuyStatus")]
            [Validation(Required=false)]
            public string BuyStatus { get; set; }

            /// <summary>
            /// <para>The version of the delivered fields for log analysis. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SAS_V1</b></description></item>
            /// <item><description><b>SAS_V2</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SAS_V1</para>
            /// </summary>
            [NameInMap("EtlMetaVersion")]
            [Validation(Required=false)]
            public string EtlMetaVersion { get; set; }

            /// <summary>
            /// <para>The activation status of log delivery. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b>: Enabled.</description></item>
            /// <item><description><b>no</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("OpenStatus")]
            [Validation(Required=false)]
            public string OpenStatus { get; set; }

            /// <summary>
            /// <para>The activation status of the pay-as-you-go billing method for the log analysis feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b>: Activated.</description></item>
            /// <item><description><b>no</b>: Not activated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("PostPaidOpenStatus")]
            [Validation(Required=false)]
            public string PostPaidOpenStatus { get; set; }

            /// <summary>
            /// <para>The support status of the pay-as-you-go billing method for the log analysis feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b>: Supported.</description></item>
            /// <item><description><b>no</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("PostPaidSupportStatus")]
            [Validation(Required=false)]
            public string PostPaidSupportStatus { get; set; }

            /// <summary>
            /// <para>The status of the LogProject used for log analysis. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: Normal.</description></item>
            /// <item><description><b>Disable</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("SlsProjectStatus")]
            [Validation(Required=false)]
            public string SlsProjectStatus { get; set; }

            /// <summary>
            /// <para>The activation status of Simple Log Service (SLS). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b>: Activated.</description></item>
            /// <item><description><b>no</b>: Not activated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("SlsServiceStatus")]
            [Validation(Required=false)]
            public string SlsServiceStatus { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
