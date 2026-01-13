// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetServiceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>this is a test rec engine</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EngineConfigId")]
        [Validation(Required=false)]
        public string EngineConfigId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtReleasedTime")]
        [Validation(Required=false)]
        public string GmtReleasedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ImageAuth")]
        [Validation(Required=false)]
        public string ImageAuth { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("LatestProdReleaseOrder")]
        [Validation(Required=false)]
        public GetServiceResponseBodyLatestProdReleaseOrder LatestProdReleaseOrder { get; set; }
        public class GetServiceResponseBodyLatestProdReleaseOrder : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>update golang version to 1.22</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;Pre&quot;: {
            ///     &quot;Status&quot;: &quot;Released&quot;,
            ///     &quot;GmtReleasedTime&quot; : &quot;2021-12-15T23:24:33.132+08:00&quot;,
            ///   },
            ///   &quot;Prod&quot;: {
            ///     &quot;Status&quot;: &quot;Released&quot;,
            ///     &quot;GmtReleasedTime&quot; : &quot;2021-12-15T23:24:33.132+08:00&quot;,
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("ReleaseInfo")]
            [Validation(Required=false)]
            public string ReleaseInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ReleaseOrderId")]
            [Validation(Required=false)]
            public string ReleaseOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:E-xxx.xxx-@xxx.onaliyun.com">E-xxx.xxx-@xxx.onaliyun.com</a></para>
            /// </summary>
            [NameInMap("Releaser")]
            [Validation(Required=false)]
            public string Releaser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>update version</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_rec</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D75C43DC-3D3A-5CC8-9AAC-8C77306C433B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Port&quot;:8080}</para>
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public string ServiceConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eas-resource-xxx</para>
        /// </summary>
        [NameInMap("ServiceResourceUri")]
        [Validation(Required=false)]
        public string ServiceResourceUri { get; set; }

    }

}
