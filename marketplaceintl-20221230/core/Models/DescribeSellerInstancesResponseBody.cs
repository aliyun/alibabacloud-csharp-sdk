// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MarketplaceIntl20221230.Models
{
    public class DescribeSellerInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>fatal</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Fatal")]
        [Validation(Required=false)]
        public bool? Fatal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance 5723f7ee-952d-411f-94f4-b942a550d9b8 does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A6A33748-D573-593C-A3BC-593E33D68311</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeSellerInstancesResponseBodyResult> Result { get; set; }
        public class DescribeSellerInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;authUrl\&quot;:\&quot;<a href="https://marketplace.alibabacloud.com/%5C%5C%22%7D">https://marketplace.alibabacloud.com/\\&quot;}</a></para>
            /// </summary>
            [NameInMap("AppInfo")]
            [Validation(Required=false)]
            public string AppInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public int? ChargeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sgcmgj000356</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1741752000000</para>
            /// </summary>
            [NameInMap("CreatedOn")]
            [Validation(Required=false)]
            public long? CreatedOn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;userName\&quot;:\&quot;marketplace\&quot;}</para>
            /// </summary>
            [NameInMap("HostInfo")]
            [Validation(Required=false)]
            public string HostInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;userName\&quot;:\&quot;marketplace\&quot;}</para>
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public string Info { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5000002763123</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OPENED</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5322460655123456</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>103</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
