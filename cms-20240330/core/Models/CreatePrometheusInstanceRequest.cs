// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("archiveDuration")]
        [Validation(Required=false)]
        public int? ArchiveDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("authFreeReadPolicy")]
        [Validation(Required=false)]
        public string AuthFreeReadPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("authFreeWritePolicy")]
        [Validation(Required=false)]
        public string AuthFreeWritePolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeRead")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeRead { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeWrite")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeWrite { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthToken")]
        [Validation(Required=false)]
        public bool? EnableAuthToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name1</para>
        /// </summary>
        [NameInMap("prometheusInstanceName")]
        [Validation(Required=false)]
        public string PrometheusInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("storageDuration")]
        [Validation(Required=false)]
        public int? StorageDuration { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreatePrometheusInstanceRequestTags> Tags { get; set; }
        public class CreatePrometheusInstanceRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>110109200001214284</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wokspace1</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
