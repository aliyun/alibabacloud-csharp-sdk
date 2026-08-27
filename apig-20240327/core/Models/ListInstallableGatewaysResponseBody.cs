// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListInstallableGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListInstallableGatewaysResponseBodyData Data { get; set; }
        public class ListInstallableGatewaysResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListInstallableGatewaysResponseBodyDataItems> Items { get; set; }
            public class ListInstallableGatewaysResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2.1.10</para>
                /// </summary>
                [NameInMap("engineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-xxxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("gatewayPhase")]
                [Validation(Required=false)]
                public string GatewayPhase { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("installable")]
                [Validation(Required=false)]
                public bool? Installable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VERSION_NOT_MATCH</para>
                /// </summary>
                [NameInMap("installableFalseReasonType")]
                [Validation(Required=false)]
                public string InstallableFalseReasonType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("installedPluginVersion")]
                [Validation(Required=false)]
                public string InstalledPluginVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my-gateway</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>43</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FA163-3664-5D34-81D1-5FFFC94AD7D5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
