// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class SetServiceSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBEC8072-BEC2-478E-8EAE-E723BA79CF19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of service settings.</para>
        /// </summary>
        [NameInMap("ServiceSettings")]
        [Validation(Required=false)]
        public List<SetServiceSettingsResponseBodyServiceSettings> ServiceSettings { get; set; }
        public class SetServiceSettingsResponseBodyServiceSettings : TeaModel {
            /// <summary>
            /// <para>The name of OSS bucket to deliver.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OssBucketName</para>
            /// </summary>
            [NameInMap("DeliveryOssBucketName")]
            [Validation(Required=false)]
            public string DeliveryOssBucketName { get; set; }

            /// <summary>
            /// <para>Whether to enable OSS delivery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeliveryOssEnabled")]
            [Validation(Required=false)]
            public bool? DeliveryOssEnabled { get; set; }

            /// <summary>
            /// <para>The key prefix of OSS to deliver.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oos/execution</para>
            /// </summary>
            [NameInMap("DeliveryOssKeyPrefix")]
            [Validation(Required=false)]
            public string DeliveryOssKeyPrefix { get; set; }

            /// <summary>
            /// <para>Whether to enable SLS delivery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeliverySlsEnabled")]
            [Validation(Required=false)]
            public bool? DeliverySlsEnabled { get; set; }

            /// <summary>
            /// <para>The name of SLS project to deliver.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SlsProjectName</para>
            /// </summary>
            [NameInMap("DeliverySlsProjectName")]
            [Validation(Required=false)]
            public string DeliverySlsProjectName { get; set; }

            /// <summary>
            /// <para>The id of RDC Enterprise.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RdcEnterpriseId</para>
            /// </summary>
            [NameInMap("RdcEnterpriseId")]
            [Validation(Required=false)]
            public string RdcEnterpriseId { get; set; }

        }

    }

}
