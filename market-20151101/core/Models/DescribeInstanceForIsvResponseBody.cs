// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInstanceForIsvResponseBody : TeaModel {
        [NameInMap("ActiveAddress")]
        [Validation(Required=false)]
        public string ActiveAddress { get; set; }

        [NameInMap("AppJson")]
        [Validation(Required=false)]
        public string AppJson { get; set; }

        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public string AutoRenewal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1570634021000</para>
        /// </summary>
        [NameInMap("BeganOn")]
        [Validation(Required=false)]
        public long? BeganOn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;package_version&quot;:&quot;yuncode000111&quot;}</para>
        /// </summary>
        [NameInMap("ComponentJson")]
        [Validation(Required=false)]
        public string ComponentJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1570634018000</para>
        /// </summary>
        [NameInMap("CreatedOn")]
        [Validation(Required=false)]
        public long? CreatedOn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1602259200000</para>
        /// </summary>
        [NameInMap("EndOn")]
        [Validation(Required=false)]
        public long? EndOn { get; set; }

        [NameInMap("ExtendJson")]
        [Validation(Required=false)]
        public string ExtendJson { get; set; }

        [NameInMap("HostJson")]
        [Validation(Required=false)]
        public string HostJson { get; set; }

        [NameInMap("ImageJson")]
        [Validation(Required=false)]
        public string ImageJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1551111111</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTrial")]
        [Validation(Required=false)]
        public bool? IsTrial { get; set; }

        [NameInMap("LicenseCode")]
        [Validation(Required=false)]
        public string LicenseCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>204211111111111</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cmgj00**11</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cmgj00**11-prepay</para>
        /// </summary>
        [NameInMap("ProductSkuCode")]
        [Validation(Required=false)]
        public string ProductSkuCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("RelationalData")]
        [Validation(Required=false)]
        public DescribeInstanceForIsvResponseBodyRelationalData RelationalData { get; set; }
        public class DescribeInstanceForIsvResponseBodyRelationalData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>STARTED</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6EF60BEC-<b><b>-</b></b>-****-270359FB54A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OPENED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

    }

}
