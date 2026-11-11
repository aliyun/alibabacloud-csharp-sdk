// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListMyAgenticNotificationChannelConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of notification channel configurations for the current user.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMyAgenticNotificationChannelConfigsResponseBodyData> Data { get; set; }
        public class ListMyAgenticNotificationChannelConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The notification channel type. Valid values: FEISHU (Lark).</para>
            /// 
            /// <b>Example:</b>
            /// <para>FEISHU</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The channel configuration information. Both keys and values are strings, which include bound identity information such as openId, mobile, or email. Sensitive values are always displayed as ****** and are not returned in plaintext.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;openId&quot;:&quot;<b><b><b>&quot;,&quot;mobile&quot;:&quot;</b></b></b>&quot;,&quot;email&quot;:&quot;******&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public Dictionary<string, string> Config { get; set; }

            /// <summary>
            /// <para>Indicates whether the notification channel is enabled. If the channel has never been configured, false is returned.</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INVALID_PARAMETER</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel must be FEISHU</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page used for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. This parameter is empty if no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MjA</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values: true and false.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
