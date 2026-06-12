// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class UpdateUserInformationRequest : TeaModel {
        /// <summary>
        /// <para>The configurations to modify.</para>
        /// </summary>
        [NameInMap("DeliverySettings")]
        [Validation(Required=false)]
        public UpdateUserInformationRequestDeliverySettings DeliverySettings { get; set; }
        public class UpdateUserInformationRequestDeliverySettings : TeaModel {
            /// <summary>
            /// <para>Specifies whether to deliver ActionTrail events to OSS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Delivery is enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Delivery is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ActiontrailDeliveryToOssEnabled")]
            [Validation(Required=false)]
            public bool? ActiontrailDeliveryToOssEnabled { get; set; }

            /// <summary>
            /// <para>The name of the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;mybucket&quot;</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <para>Specifies whether to deliver data to Object Storage Service (OSS). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Delivery is enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Delivery is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OssEnabled")]
            [Validation(Required=false)]
            public bool? OssEnabled { get; set; }

            /// <summary>
            /// <para>The number of days to retain screen recordings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("OssExpirationDays")]
            [Validation(Required=false)]
            public long? OssExpirationDays { get; set; }

            /// <summary>
            /// <para>The OSS path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;path1/path2/&quot;</para>
            /// </summary>
            [NameInMap("OssPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
