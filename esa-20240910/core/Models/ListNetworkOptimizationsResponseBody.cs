// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListNetworkOptimizationsResponseBody : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListNetworkOptimizationsResponseBodyConfigs> Configs { get; set; }
        public class ListNetworkOptimizationsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>395386449776640</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Grpc")]
            [Validation(Required=false)]
            public string Grpc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Http2Origin")]
            [Validation(Required=false)]
            public string Http2Origin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SmartRouting")]
            [Validation(Required=false)]
            public string SmartRouting { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("UploadMaxFilesize")]
            [Validation(Required=false)]
            public string UploadMaxFilesize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Websocket")]
            [Validation(Required=false)]
            public string Websocket { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
