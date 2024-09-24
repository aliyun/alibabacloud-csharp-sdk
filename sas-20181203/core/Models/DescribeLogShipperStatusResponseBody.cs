// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogShipperStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status information.</para>
        /// </summary>
        [NameInMap("LogShipperStatus")]
        [Validation(Required=false)]
        public DescribeLogShipperStatusResponseBodyLogShipperStatus LogShipperStatus { get; set; }
        public class DescribeLogShipperStatusResponseBodyLogShipperStatus : TeaModel {
            /// <summary>
            /// <para>Indicates whether Security Center is authorized to access Log Service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b></description></item>
            /// <item><description><b>no</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public string AuthStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the log analysis feature is purchased. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b></description></item>
            /// <item><description><b>no</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("BuyStatus")]
            [Validation(Required=false)]
            public string BuyStatus { get; set; }

            /// <summary>
            /// <para>The version of the log analysis field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SAS_V1</description></item>
            /// <item><description>SAS_V2</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SAS_V1</para>
            /// </summary>
            [NameInMap("EtlMetaVersion")]
            [Validation(Required=false)]
            public string EtlMetaVersion { get; set; }

            /// <summary>
            /// <para>The status of the log analysis feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b>: enabled</description></item>
            /// <item><description><b>no</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("OpenStatus")]
            [Validation(Required=false)]
            public string OpenStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the pay-as-you-go billing method is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b></description></item>
            /// <item><description><b>no</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("PostPaidOpenStatus")]
            [Validation(Required=false)]
            public string PostPaidOpenStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the log analysis feature supports the pay-as-you-go billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b></description></item>
            /// <item><description><b>no</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("PostPaidSupportStatus")]
            [Validation(Required=false)]
            public string PostPaidSupportStatus { get; set; }

            /// <summary>
            /// <para>The status of the dedicated Log Service project. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: normal</description></item>
            /// <item><description><b>Disable</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("SlsProjectStatus")]
            [Validation(Required=false)]
            public string SlsProjectStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether Log Service is activated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b></description></item>
            /// <item><description><b>no</b></description></item>
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
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
